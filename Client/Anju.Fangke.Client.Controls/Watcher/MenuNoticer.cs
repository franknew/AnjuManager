using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Anju.Fangke.Client.Controls
{
    public class MenuNoticer : IControlNoticer
    {
        public MenuNoticer(string controlName, Form mainForm)
        {
            this.controlName = controlName;
            this.containerForm = mainForm;
            mainMenu = mainForm.Controls[controlName] as MenuStrip;
            if (mainMenu == null)
            {
                throw new Exception("菜单：" + controlName + "在窗体：" + mainForm.Name + "中不存在");
            }
        }

        private Form containerForm = null;

        private const string usaulMenuName = "usaulMenu";

        private const string separatorName = "formSeparator";

        private List<string> listForm = new List<string>();

        private string selectedName = "";

        private string controlName;

        private MenuStrip mainMenu;

        public ControlWatcher Watcher { get; set; }

        public void Add(string name, string text)
        {
            if (listForm.Contains(name))
            {
                return;
            }
            ToolStripMenuItem usaulMenu = mainMenu.Items[usaulMenuName] as ToolStripMenuItem;
            ToolStripSeparator separator = usaulMenu.DropDownItems[separatorName] as ToolStripSeparator;
            if (separator == null)
            {
                separator = new ToolStripSeparator();
                separator.Name = separatorName;
                usaulMenu.DropDownItems.Add(separator);
            }
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Name = name;
            item.Text = text;
            item.Click += ActivateForm;
            usaulMenu.DropDownItems.Add(item);
            listForm.Add(name);
            Activate(name);
        }

        public void Remove(string name)
        {
            if (!listForm.Contains(name))
            {
                return;
            }
            ToolStripMenuItem usaulMenu = mainMenu.Items[usaulMenuName] as ToolStripMenuItem;
            if (usaulMenu != null)
            {
                ToolStripMenuItem item = usaulMenu.DropDownItems[name] as ToolStripMenuItem;
                if (item != null)
                {
                    usaulMenu.DropDownItems.Remove(item);
                }
                listForm.Remove(name);
                if (listForm.Count == 0)
                {
                    ToolStripSeparator separator = usaulMenu.DropDownItems[separatorName] as ToolStripSeparator;
                    if (separator != null)
                    {
                        usaulMenu.DropDownItems.Remove(separator);
                    }
                }
            }
        }

        public void Clear()
        {
            mainMenu.Items.Clear();
            listForm.Clear();
        }

        public void Activate(string name)
        {
            if (!listForm.Contains(name))
            {
                return;
            }
            ToolStripMenuItem usaulMenu = mainMenu.Items[usaulMenuName] as ToolStripMenuItem;
            foreach (var menu in listForm)
            {
                ToolStripMenuItem item = usaulMenu.DropDownItems[menu] as ToolStripMenuItem;
                if (item != null)
                    item.Image = null;
            }
            ToolStripMenuItem selectedItem = usaulMenu.DropDownItems[name] as ToolStripMenuItem;
            //将item的图像设置为选中
            //if (selectedItem != null)
            //    selectedItem.Image = Properties.Resource.menuSelected;
        }

        private void ActivateForm(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            Form form = containerForm.MdiChildren.First(t => t.Name == item.Name);
            if (form == null)
            {
                return;
            }
            form.Activate();
            Watcher.Activate(item.Name);
        }
    }
}
