using SOAFramework.Client.Forms;
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
            if (form is BaseForm) baseform = form as BaseForm;
            foreach (var binding in bindingcontrols)
            {
                if (string.IsNullOrEmpty(binding.BindingRequestPropertyName)) continue;
                Control control = binding as Control;
                IControlBindable controlbind = control as IControlBindable;
                data[binding.BindingRequestPropertyName] = binding.CollectBindingData();
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

        public static List<Control> GetAllControl(this Form form)
        {
            List<Control> list = new List<Control>();
            foreach (Control c in form.Controls)
            {
                c.GetControl_Resc(list);
            }
            return list;
        }

        public static void GetControl_Resc(this Control control, List<Control> list)
        {
            if (list == null) list = new List<Control>();
            list.Add(control);
            foreach (Control c in control.Controls)
            {
                c.GetControl_Resc(list);
            }
        }

        public static T CollectData<T>(this Form form, T t = default(T))
        {
            if (t == null) t = Activator.CreateInstance<T>();
            var list = form.GetAllControl();
            var propertyNameList = list.OfType<IControlBindable>();
            foreach (var property in propertyNameList)
            {
                var group = property as IGroupControl;
                var control = property as Control;
                if (string.IsNullOrEmpty(group?.Group))
                {
                    if (string.IsNullOrEmpty(property.BindingSourcePropertyName)) continue;
                    var value = control.TryGetValue(property.BindingSelfPropertyName);
                    t.TrySetValue(property.BindingSourcePropertyName, value);
                }
                else
                {
                    if (group.Checked) t.TrySetValue(group.Group, group.Value);
                }
            }
            return t;
        }

        public static void SetForm(this Form form, object o)
        {
            if (o == null) return;
            var list = form.GetAllControl();
            var propertyNameList = list.OfType<IControlBindable>();
            foreach (var property in propertyNameList)
            {
                var group = property as IGroupControl;
                var control = property as Control;
                object value = null;
                if (string.IsNullOrEmpty(group?.Group))
                {
                    if (string.IsNullOrEmpty(property.BindingSourcePropertyName)) continue;
                    value = o.TryGetValue(property.BindingSourcePropertyName);
                    control.TrySetValue(property.BindingSelfPropertyName, value);
                }
                else
                {
                    value = o.TryGetValue(group.Group);
                    if (group.Value.ChangeTypeTo(value.GetType()).Equals(value)) group.Checked = true;
                    else group.Checked = false;
                }
            }
        }
    }
}
