using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anju.Fangke.Client.Controls
{
    public class ControlWatcher
    {
        private List<IControlNoticer> noticeList = new List<IControlNoticer>();

        public void AddNoticer(IControlNoticer noticer)
        {
            noticeList.Add(noticer);
            noticer.Watcher = this;
        }

        public void Add(string name, string text)
        {
            foreach (IControlNoticer noticer in noticeList)
            {
                noticer.Add(name, text);
            }
        }

        public void Remove(string name)
        {
            foreach (IControlNoticer noticer in noticeList)
            {
                noticer.Remove(name);
            }
        }

        public void Clear()
        {
            foreach (IControlNoticer noticer in noticeList)
            {
                noticer.Clear();
            }
        }

        public void Activate(string name)
        {
            foreach (IControlNoticer noticer in noticeList)
            {
                noticer.Activate(name);
            }
        }
    }
}
