using MetroFramework.Controls;
using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using SOAFramework.Library;
using System.Drawing;
using SOAFramework.Client.Forms;

namespace SOAFramework.Client.Controls
{
    public class Button : MetroButton, IServiceSubmitable
    {
        #region attribute
        private BackgroundWorker _worker = null;
        private bool _status = false;
        MetroProgressSpinner spinner = new MetroProgressSpinner();
        private ErrorHandler _handler = new ErrorHandler();
        private IDictionary<string, object> data = null;
        #endregion

        #region property
        [Category(ControlCategory.Category)]
        [DefaultValue(false)]
        public bool EnableClickOnceOnAction { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue(false)]
        public bool EnableSyncClick { get; set; }

        [Browsable(false)]
        public bool IngoreCallbackOnce { get; set; }

        [Category(ControlCategory.Category)]
        public EventHandler InitClick { get; set; }

        [Category(ControlCategory.Category)]
        public EventHandler ClickCallback { get; set; }

        [Browsable(false)]
        public object Response { get; set; }

        private bool enableSyncSpinner = true;
        /// <summary>
        /// 是否异步时显示时间轴
        /// </summary>
        [DefaultValue(true)]
        [Category(ControlCategory.Category)]
        public bool EnableSyncSpinner
        {
            get { return enableSyncSpinner; }
            set { enableSyncSpinner = value; }
        }

        [Category(ControlCategory.Category)]
        public EventHandler BeforeRunSyncClick{ get; set; }
        #endregion

        #region service submitable property
        [Category(ControlCategory.Category)]
        [DefaultValue(null)]
        public string RequestName { get; set; }
        #endregion

        #region override
        protected override void OnClick(EventArgs e)
        {
            if (EnableSyncClick)
            {
                Form form = this.FindForm();
                _worker = new BackgroundWorker();
                _worker.WorkerSupportsCancellation = true;
                if (EnableClickOnceOnAction)
                {
                    _status = this.Enabled;
                    this.Enabled = false;
                }
                if (InitClick != null)
                {
                    InitClick.Invoke(this, e);
                }
                //收集窗体数据
                data = form.CollectData();
                _worker.DoWork += worker_DoWork;
                _worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                form.Enabled = false;
                InitSpinner(this.FindForm().MdiParent);
                //将异步处理传递给窗体以支持取消异步
                //dynamic dyForm = parentForm;
                //dyForm.Worker = worker;
                spinner.Visible = enableSyncSpinner;
                if (BeforeRunSyncClick != null)
                {
                    BeforeRunSyncClick.Invoke(this, e);
                }
                _worker.RunWorkerAsync();
            }
            base.OnClick(e);
        }
        #endregion

        #region event
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (_handler.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this.FindForm(), _handler.Message);
                _handler.IsError = false;
            }
            if (!IngoreCallbackOnce)
            {
                BindingResponse();
                if (ClickCallback != null)
                {
                    ClickCallback.Invoke(this, e);
                }
            }
            IngoreCallbackOnce = false;
            this.FindForm().Enabled = true;
            if (EnableClickOnceOnAction)
            {
                this.Enabled = _status;
            }
            //完成时执行回调事件
            if (spinner != null)
            {
                spinner.Hide();
            }
            this.FindForm().Enabled = true;
            DisposeWorkder(sender);
        }

        private void DisposeWorkder(object sender)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if (worker != null)
            {
                worker.Dispose();
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!string.IsNullOrEmpty(RequestName))
            {
                ContainerForm form = this.FindForm().MdiParent as ContainerForm;
                var sdk = Assembly.Load("Anju.Fangke.Client.SDK");
                if (sdk == null)
                {
                    _handler = new ErrorHandler
                    {
                        IsError = true,
                        Message = "Anju.Fangke.Client.SDK不存在！"
                    };
                    IngoreCallbackOnce = true;
                    return;
                }
                var types = sdk.GetTypes();
                var requestType = types.FirstOrDefault(t => t.Name == RequestName);
                if (requestType == null)
                {
                    _handler = new ErrorHandler
                    {
                        IsError = true,
                        Message = string.Format("Request：{0}不存在！", RequestName),
                    };
                    IngoreCallbackOnce = true;
                    return;
                }
                //给request设置参数
                var request = Activator.CreateInstance(requestType);
                foreach (var key in data.Keys)
                {
                    request.SetValue(key, data[key]);
                }
                request.SetValue("token", form.Token);
                var responseType = requestType.BaseType.GetGenericArguments()[0];

                Response = SDKFactory.Client.Execute(request, responseType);
                dynamic dyresponse = Response;
                if (dyresponse.IsError)
                {
                    _handler = new ErrorHandler
                    {
                        IsError = true,
                        Message = dyresponse.ErrorMessage,
                    };
                    IngoreCallbackOnce = true;
                    return;
                }
                //没有token或者token失效，需要重新登录
                if (dyresponse.Code == -1)
                {
                    dynamic mdiparent = this.FindForm().MdiParent;
                    mdiparent.ShowLogin();
                    IngoreCallbackOnce = true;
                }
            }
            base.OnClick(e);
        }
        #endregion

        #region helper
        private void BindingResponse()
        {
            if (Response == null)
            {
                return;
            }
            //绑定数据
            var controls = this.FindForm().GetAllControls().OfType<IServiceBindable>();
            foreach (var i in controls)
            {
                Control c = i as Control;
                if(string.IsNullOrEmpty(i.BindingResponsePropertyName))
                {
                    continue;
                }
                object value = Response.TryGetValue(i.BindingResponsePropertyName);
                c.SetValue(i.BindingControlPropertyName, value);
            }
        }

        private void InitSpinner(Form parentForm)
        {
            if (parentForm.Controls.Contains(spinner))
            {
                spinner = parentForm.Controls["spnProgressSpinner"] as MetroProgressSpinner;
            }
            else
            {
                spinner = new MetroProgressSpinner();
                spinner.Name = "spnProgressSpinner";
                spinner.Hide();
                parentForm.Controls.Add(spinner);
            }
            spinner.BringToFront();
            spinner.Size = new System.Drawing.Size(40, 40);
            spinner.Value = 50;
            spinner.Maximum = 100;
            spinner.Location = new Point(parentForm.Width / 2 - spinner.Width / 2, parentForm.Height / 2 - spinner.Height / 2);
            spinner.Show();
        }
        #endregion
    }

    public class ErrorHandler
    {
        public bool IsError { get; set; }

        public string Message { get; set; }

        public string Response { get; set; }
    }
}
