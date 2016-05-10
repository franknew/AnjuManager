using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Anju.Fangke.Client.Controls
{
    public class TabNoticer : IControlNoticer
    {
        public TabNoticer(string controlName, Form mainForm)
        {
            this.controlName = controlName;
            mainPage = mainForm.Controls[controlName] as TabControl;
            if (mainPage == null)
            {
                throw new Exception("菜单：" + controlName + "在窗体：" + mainForm.Name + "中不存在");
            }
        }

        private List<string> listForm = new List<string>();

        private string controlName;

        private TabControl mainPage;

        public ControlWatcher Watcher { get; set; }

        public void Add(string name, string text)
        {
            if (listForm.Contains(name))
            {
                return;
            }
            SOAFramework.Client.Controls.TabPage page = new SOAFramework.Client.Controls.TabPage();
            page.Name = name;
            page.Text = text;
            page.CausesValidation = false;
            mainPage.TabPages.Add(page);
            listForm.Add(name);
            Activate(name);
        }

        public void Remove(string name)
        {
            if (!listForm.Contains(name))
            {
                return;
            }
            TabPage page = mainPage.TabPages[name] as TabPage;
            if (page != null)
            {
                mainPage.TabPages.Remove(page);
            }
            listForm.Remove(name);
        }

        public void Clear()
        {
            mainPage.TabPages.Clear();
            listForm.Clear();
        }

        public void Activate(string name)
        {
            if (!listForm.Contains(name))
            {
                return;
            }
            mainPage.SelectTab(name);
        }
    }
}
