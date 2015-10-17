﻿using SOAFramework.Client.Forms;
using SOAFramework.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOAFramework.Client.Controls
{
    public static class FormExtension
    {
        public static List<Control> GetAllControls(this Form form)
        {
            List<Control> list = new List<Control>();
            foreach (Control c in form.Controls)
            {
                list.Add(c);
                GetControls(list, c);
            }
            return list;
        }

        public static Dictionary<string, object> CollectData(this Form form)
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            var bindingcontrols = form.GetAllControls().OfType<IServiceBindable>();
            BaseForm baseform = null;
            if (form is BaseForm)
            {
                baseform = form as BaseForm;
            }
            foreach (var binding in bindingcontrols)
            {
                if (string.IsNullOrEmpty(binding.BindingRequestPropertyName))
                {
                    continue;
                }
                Control control = binding as Control;
                IControlBindable controlbind = control as IControlBindable;
                if (control.Visible)
                {
                    data[binding.BindingRequestPropertyName] = binding.CollectBindingData();
                }
                else
                {
                    if (baseform != null)
                    {
                        object value = baseform.Binding.Current.GetValue(controlbind.BindingSourcePropertyName);
                        if (value != null)
                        {
                            data[binding.BindingRequestPropertyName] = value;
                        }
                    }
                }
            }
            return data;
        }

        private static void GetControls(List<Control> list, Control control)
        {
            foreach (Control c in control.Controls)
            {
                list.Add(c);
                GetControls(list, c);
            }
        }

        public static void FlushBinding(this Control control)
        {
            IControlBindable bindable = control as IControlBindable;
            IServiceBindable servicebind = control as IServiceBindable;
            foreach (Binding binding in control.DataBindings)
            {
                BindingSource source = binding.DataSource as BindingSource;
                source.Current.SetValue(bindable.BindingSourcePropertyName, servicebind.CollectBindingData());
            }
        }

        public static void FlushBinding(this BaseForm form)
        {
            var list = form.GetAllControls();
            foreach (var control in list)
            {
                control.FlushBinding();
            }
            form.Binding.EndEdit();
            form.Binding.ResetBindings(false);
        }
    }
}
