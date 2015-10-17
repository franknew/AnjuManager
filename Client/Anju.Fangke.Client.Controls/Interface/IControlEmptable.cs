using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public interface IControlEmptable
    {
        bool UseWarnStyle { get; set; }

        bool CanbeEmpty { get; set; }

        string Text { get; set; }

        string EmptyWarning { get; set; }
    }
}
