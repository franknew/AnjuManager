using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public interface IGroupControl
    {
        string Group { get; set; }

        string Value { get; set; }

        bool Checked { get; set; }
    }
}
