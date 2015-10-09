using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anju.Fangke.Client.Main
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

        public static ControlWatcher CreateCenterWatcher(Form form)
        {
            ControlWatcher watcher = new ControlWatcher();
            MenuNoticer menunoticer = new MenuNoticer("mainMenu", form);
            menunoticer.Watcher = watcher;
            TabNoticer tabnoticer = new TabNoticer("tabTitle", form);
            tabnoticer.Watcher = watcher;
            FormNoticer formnoticer = new FormNoticer("", form);
            formnoticer.Watcher = watcher;

            watcher.AddNoticer(formnoticer);
            watcher.AddNoticer(menunoticer);
            watcher.AddNoticer(tabnoticer);
            return watcher;
        }

        public static ControlWatcher CreateSiteWatcher(Form form)
        {
            ControlWatcher watcher = new ControlWatcher();
            TabNoticer tabnoticer = new TabNoticer("tabTitle", form);
            tabnoticer.Watcher = watcher;
            FormNoticer formnoticer = new FormNoticer("", form);
            formnoticer.Watcher = watcher;

            watcher.AddNoticer(formnoticer);
            watcher.AddNoticer(tabnoticer);
            return watcher;
        }
    }
}
