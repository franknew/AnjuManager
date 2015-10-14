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
            foreach (var binding in bindingcontrols)
            {
                if (string.IsNullOrEmpty(binding.BindingRequestPropertyName))
                {
                    continue;
                }
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
    }
}
