using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SOAFramework.Client.Controls;
using SOAFramework.Library;

namespace SOAFramework.Client.Forms
{
    public static class FormExtension
    {
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
