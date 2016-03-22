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
using System.Diagnostics;

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
        public event EventHandler InitClick;

        [Category(ControlCategory.Category)]
        public event EventHandler ClickCallback;

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
        public event EventHandler BeforeRunSyncClick;

        [Category(ControlCategory.Category)]
        [DefaultValue(false)]
        public bool CheckFormEmpty { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue(false)]
        public bool CloseFormAfterInvoke { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string ClickedMessage { get; set; }
        #endregion

        #region service submitable property
        [Category(ControlCategory.Category)]
        [DefaultValue(null)]
        public string RequestName { get; set; }
        #endregion

        #region override
        protected override void OnClick(EventArgs e)
        {
            BaseForm form = this.FindForm() as BaseForm;
            if (CheckFormEmpty)
            {
                //检查窗体输入项为空情况
                if (CheckFormInputEmpty(form))
                {
                    return;
                }
            }
            if (EnableSyncClick)
            {
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
                Form parent = form;
                if (form.MdiParent != null)
                {
                    parent = form.MdiParent;
                }
                form.ShowSpinner();
                //将异步处理传递给窗体以支持取消异步
                //dynamic dyForm = parentForm;
                //dyForm.Worker = worker;
                if (BeforeRunSyncClick != null)
                {
                    BeforeRunSyncClick.Invoke(this, e);
                }
                _worker.RunWorkerAsync();
            }
            else
            {
                base.OnClick(e);
                ShowClickedMessage(form);
                CloseParentForm(form);
            }
        }
        #endregion

        #region event
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BaseForm form = this.FindForm() as BaseForm;

            if (_handler.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(form, _handler.Message, "错误");
                _handler.IsError = false;
                return;
            }

            if (!IngoreCallbackOnce)
            {
                BindingResponse();
                if (ClickCallback != null)
                {
                    ClickCallback.Invoke(this, e);
                }
                IngoreCallbackOnce = false;
            }
            form.HideSpinner();
            if (EnableClickOnceOnAction)
            {
                this.Enabled = _status;
            }
            ShowClickedMessage(form);
            DisposeWorkder(sender);
            CloseParentForm(form);
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(RequestName))
                {
                    Form form = this.FindForm();
                    ContainerForm container = null;
                    if (form is PopupForm)
                    {
                        if (form.Owner is ContainerForm)
                        {
                            container = form.Owner as ContainerForm;
                        }
                        else if (form.Owner != null)
                        {
                            container = form.Owner.MdiParent as ContainerForm;
                        }
                    }
                    else
                    {
                        container = form.MdiParent as ContainerForm;
                    }
                    var sdk = Assembly.Load("Anju.Fangke.Client.SDK");
                    if (sdk == null)
                    {
                        _handler = new ErrorHandler
                        {
                            IsError = true,
                            Message = "Anju.Fangke.Client.SDK不存在！"
                        };
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
                        return;
                    }
                    //给request设置参数
                    var request = Activator.CreateInstance(requestType);
                    foreach (var key in data.Keys)
                    {
                        request.SetValue(key, data[key]);
                    }
                    request.SetValue("token", container.Token);
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
            }
            catch (Exception ex)
            {
                _handler = new ErrorHandler
                {
                    IsError = true,
                    Message = string.Format(ex.Message),
                };
                return;
            }
            if (this.InvokeRequired)
            {
                this.Invoke(new ButtonClickInvoker(base.OnClick), e);
            }
            else
            {
                base.OnClick(e);
            }
        }
        #endregion

        #region helper
        private void DisposeWorkder(object sender)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            if (worker != null)
            {
                worker.Dispose();
            }
        }

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
                if (string.IsNullOrEmpty(i.BindingResponsePropertyName))
                {
                    continue;
                }
                object value = Response.TryGetValue(i.BindingResponsePropertyName);
                if (c is DataGridView)
                {
                    BaseForm form = this.FindForm() as BaseForm;
                    form.Binding.DataSource = value;
                    value = form.Binding;
                }
                c.SetValue(i.BindingControlPropertyName, value);
            }
        }

        private void InitSpinner(Form parentForm)
        {
            if (!enableSyncSpinner)
            {
                return;
            }
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

        private bool CheckFormInputEmpty(Form form)
        {
            //检查窗体文本为空情况
            bool hasEmtpy = false;
            var controls = form.GetAllControls().OfType<IControlEmptable>();
            foreach (var control in controls)
            {
                if (!control.CanbeEmpty && string.IsNullOrEmpty(control.Text))
                {
                    dynamic c = control as Control;
                    try
                    {
                        c.PromptText = control.EmptyWarning;
                    }
                    catch
                    {

                    }
                    control.UseWarnStyle = true;
                    hasEmtpy = true;
                }
            }
            return hasEmtpy;
        }

        private void ShowClickedMessage(Form form)
        {
            if (!string.IsNullOrEmpty( this.ClickedMessage))
            {
                SOAFramework.Client.Controls.MessageBox.Show(form, ClickedMessage, "信息");
            }
        }

        private void CloseParentForm (Form form)
        {
            if (CloseFormAfterInvoke)
            {
                form.Close();
                var mainform = Form.FromHandle(Process.GetCurrentProcess().MainWindowHandle) as Form;
                mainform.Activate();
            }
        }
        #endregion
        private delegate void ButtonClickInvoker(EventArgs e); 
    }


    public class ErrorHandler
    {
        public bool IsError { get; set; }

        public string Message { get; set; }

        public string Response { get; set; }
    }
}
