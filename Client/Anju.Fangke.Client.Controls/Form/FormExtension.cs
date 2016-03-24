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
                if (string.IsNullOrEmpty(property.BindingSourcePropertyName)) continue;
                var group = property as IGroupControl;
                if (group == null)
                {
                    var control = property as Control;
                    var value = control.TryGetValue(property.BindingSelfPropertyName);
                    control.TrySetValue(property.BindingSourcePropertyName, value);
                }
                else
                {

                }
            }
            return t;
        }
    }
}
