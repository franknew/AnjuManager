using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public interface IInitableBinding
    {
        string InitableBindingGroupName { get; set; }

        string InitableBindingControlPropertyName { get; set; }

        bool HasAll { get; set; }
    }
}
