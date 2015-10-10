using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public interface IServiceBindable
    {
        string BindingRequestPropertyName { get; set; }

        string BindingControlPropertyName { get; set; }

        object CollectBindingData();

        string BindingResponsePropertyName { get; set; }
    }
}
