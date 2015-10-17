using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anju.Fangke.Client.Controls
{
    public interface IControlNoticer
    {
        void Add(string name, string text);

        void Remove(string name);

        void Clear();

        void Activate(string name);

        ControlWatcher Watcher { get; set; }
    }
}
