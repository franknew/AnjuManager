using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Anju.Fangke.Client.Main
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
