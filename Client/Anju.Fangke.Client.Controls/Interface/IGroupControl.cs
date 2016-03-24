using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public interface IGroupControl
    {
        string Group { get; set; }

        object Value { get; set; }
    }
}
