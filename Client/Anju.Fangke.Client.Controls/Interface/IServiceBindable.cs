using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public interface IServiceBindable
    {
        string ServiceBindingPropertyName { get; set; }

        string ControlBindingPropertyName { get; set; }

        object CollectBindingData();
    }
}
