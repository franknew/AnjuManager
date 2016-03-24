using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SOAFramework.Library;

namespace SOAFramework.Client.Controls
{
    public delegate object PropertyGetterInvokerDelegate(Control control, string property);
    public delegate void PropertySetterInvokerDelegate(Control control, string property, object value);

    public class SyncPropertyInvoker
    {
        public static object GetValue(Control control, string property)
        {
            return control.GetValue(property, true);
        }

        public static void SetValue(Control control, string property, object value)
        {
            control.TrySetValue(property, value);
        }
    }
}
