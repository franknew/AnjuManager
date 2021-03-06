﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SOAFramework.Client.Forms;
using SOAFramework.Service.SDK.Core;

namespace SOAFramework.Client.Controls
{
    public class SDKSync<T> where T : BaseResponse
    {
        public SDKSync(BaseForm form)
        {
            _currentform = form;
        }

        public static SDKSync<T> CreateInstance(BaseForm form)
        {
            return new SDKSync<T>(form);
        }

        private BaseForm _currentform = null;
        private T t = default(T);
        public T Execute(IRequest<T> request, ExecuteCallBackDelegate<T> callBack = null)
        {
            T t = default(T);
            if (callBack == null) t = SDKFactory.Client.Execute(request);
            else
            {
                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += Worker_DoWork;
                worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
                _currentform?.ShowSpinner();
                dynamic r = request;
                r.token = _currentform.Token;
                worker.RunWorkerAsync(new SDKSyncParam<T> { CallBack = callBack, Request = request });
            }
            return t;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _currentform?.HideSpinner();
            var param = e.Result as SDKSyncParam<T>;
            if (!_currentform.CheckLoginValid(param.Response)) return; ;
            param.CallBack?.Invoke(param.Response);
            _currentform?.Activate();
            _currentform?.ActiveControl?.Focus();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var param = e.Argument as SDKSyncParam<T>;
                t = SDKFactory.Client.Execute(param.Request);
                e.Result = new SDKSyncParam<T> { CallBack = param.CallBack, Response = t };
            }
            catch (Exception ex)
            {
                SOAFramework.Client.Controls.MessageBox.Show(null, ex.Message);
            }
        }

        private static ChildForm GetCurrentActiveChildForm()
        {
            if (Form.ActiveForm != null)
            {
                if (Form.ActiveForm is ContainerForm)
                {
                    ContainerForm container = Form.ActiveForm as ContainerForm;
                    return container.MdiChildren.FirstOrDefault(t => t.Focused) as ChildForm;
                }
            }
            return null;
        }
    }

    public class SDKSyncParam<T> where T : BaseResponse
    {
        public ExecuteCallBackDelegate<T> CallBack { get; set; }

        public IRequest<T> Request { get; set; }

        public T Response { get; set; }
    }

    public delegate void ExecuteCallBackDelegate<T>(T t) where T : BaseResponse;
}
