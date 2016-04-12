using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOAFramework.Client.Controls
{
    public static class DataGridViewExtension
    {
        public static object GetValue(this DataGridViewCell cell)
        {
            object value = cell.Value;
            if (value == null) value = cell.FormattedValue;
            return value;
        }
    }
}
