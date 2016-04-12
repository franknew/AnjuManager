using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOAFramework.Client.Controls
{
    public interface IControlBindable
    {
        string BindingSourcePropertyName { get; set; }

        string BindingSelfPropertyName { get; set; }

        DataSourceUpdateMode DataSourceUpdateMode { get; set; }

        object DBNullValue { get; set; }

        bool Bindable { get; set; }
    }
}
