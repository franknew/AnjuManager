using MetroFramework.Controls;
using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SOAFramework.Client.Controls
{
    public class Button : MetroButton, IServiceSubmitable
    {
        #region attribute
        private BackgroundWorker _worker = null;
        private bool _status = false;
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
        #endregion

        #region service submitable property
        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string InterfaceName { get; set; }

        private ResponseBindingEnum responseBindingType = ResponseBindingEnum.Form;
        [Category(ControlCategory.Category)]
        [DefaultValue(ResponseBindingEnum.Form)]
        public ResponseBindingEnum ResponseBindingType
        {
            get
            {
                return responseBindingType;
            }

            set
            {
                responseBindingType = value;
            }
        }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string ResponseBindingControlName { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string ResponseBindingPropertyName { get; set; }

        #endregion

        #region override
        protected override void OnClick(EventArgs e)
        {
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
                _worker.DoWork += worker_DoWork;
                _worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                this.FindForm().Enabled = false;
                _worker.RunWorkerAsync();
            }
            base.OnClick(e);
        }
        #endregion

        #region event
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (IngoreCallbackOnce)
            {
                this.FindForm().Enabled = true;
                DisposeWorkder(sender);
                IngoreCallbackOnce = false;
                return;
            }
            if (ClickCallback != null)
            {
                ClickCallback.Invoke(this, e);
            }
            if (EnableClickOnceOnAction)
            {
                this.Enabled = _status;
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
            if (string.IsNullOrEmpty(InterfaceName))
            {
                Form form = this.FindForm();
                var sdk = Assembly.Load("Anju.Fangke.Client.SDK");
                if (sdk == null)
                {
                    SOAFramework.Client.Controls.MessageBox.Show(this, "Anju.Fangke.Client.SDK不存在！");
                    IngoreCallbackOnce = true;
                    return;
                }
                var types = sdk.GetTypes();
                var interfaces = types.OfType<BaseRequest<BaseResponse>>();
                var request = interfaces.FirstOrDefault(t => t.GetApi() == InterfaceName);
                if (request == null)
                {
                    SOAFramework.Client.Controls.MessageBox.Show(this, string.Format("接口名：{0}不存在！", InterfaceName));
                    IngoreCallbackOnce = true;
                    return;
                }
                var response = SDKFactory.Client.Execute(request);
                if (response.IsError)
                {
                    SOAFramework.Client.Controls.MessageBox.Show(this, response.ErrorMessage);
                    IngoreCallbackOnce = true;
                    return;
                }
                //没有token或者token失效，需要重新登录
                if (response.Code == -1)
                {
                    dynamic mdiparent = this.FindForm().MdiParent;
                    mdiparent.ShowLogin();
                    IngoreCallbackOnce = true;
                }
                try
                {
                    object value = response.GetValue(this.ResponseBindingPropertyName);
                }
                catch (Exception ex)
                {
                    SOAFramework.Client.Controls.MessageBox.Show(this, ex.Message);
                    IngoreCallbackOnce = true;
                    return;
                }
                //绑定数据
                switch (this.responseBindingType)
                {
                    case ResponseBindingEnum.Form:
                        break;
                    case ResponseBindingEnum.Grid:
                        break;
                }
            }
            base.OnClick(e);
        }
        #endregion
    }
}
