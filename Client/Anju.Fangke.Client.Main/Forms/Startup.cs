using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SOAFramework.Client.Forms;
using SOAFramework.Client.Controls;
using Anju.Fangke.Client.Controls;
using System.Reflection;

namespace Anju.Fangke.Client.Main
{
    public partial class Startup : ContainerForm
    {

        public Startup()
        {
            InitializeComponent();
            tabMenu.CloseButtonClick += CloseButtonClick;
            nIcon.ContextMenu = new ContextMenu();
            nIcon.ContextMenu.MenuItems.Add(new MenuItem("显示界面", show_click));
            nIcon.ContextMenu.MenuItems.Add(new MenuItem("退出", close_Click));
        }

        #region event
        private void CloseButtonClick(object sender, TabControlCloseButtonClickEventArgs e)
        {
            _watcher.Remove(tabMenu.TabPages[e.ClickIndex].Name);
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            SetTime();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = AddMdiChild("Anju.Fangke.Client.Forms.UserManagement.dll", "Anju.Fangke.Client.Forms.UserManagement");
            _watcher.Add(form.Name, form.Text);
        }

        private void show_click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
            }
            this.WindowState = FormWindowState.Maximized;
            this.Activate();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region helper
        private void SetTime()
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void InitWatcher()
        {
            _watcher.Clear();
            _watcher.AddNoticer(new TabNoticer("tabMenu", this));
            _watcher.AddNoticer(new FormNoticer(this.Name, this));
        }
        #endregion

        #region action
        public void SetInfo(string username)
        {
            lblName.Text = username;
        }

        public void ShowLogin()
        {
            InitWatcher();
            this.Hide();
            Login form = new Login();
            form.ShowDialog(this);
            SetTime();
            timerNow.Start();
        }

        public void CreateMenu(List<SDK.Menu> menus)
        {
            if (menus != null && menus.Count > 0) menu.Items.Clear();
            var root = menus.FindAll(t => string.IsNullOrEmpty(t.ParentID));
            foreach (var r in root)
            {
                ToolStripMenuItem m = new ToolStripMenuItem(r.Name);
                m.Tag = r.Page;
                menu.Items.Add(m);
                AddSubMenu_Resc(menus, m, r.ID);
            }
        }

        private void AddSubMenu_Resc(List<SDK.Menu> menus, ToolStripMenuItem item, string menuid)
        {
            var submenus = menus.FindAll(t => t.ParentID == menuid);
            foreach (var m in submenus)
            {
                ToolStripMenuItem submenu = new ToolStripMenuItem(m.Name);
                submenu.Tag = m.Page;
                submenu.Click += menu_Click;
                item.DropDownItems.Add(submenu);
                AddSubMenu_Resc(menus, submenu, m.ID);
            }
        }
        #endregion

        #region private method
        private void menu_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            if (item.Tag == null) return;
            string page = item.Tag.ToString();
            if (string.IsNullOrEmpty(page)) return;
            var arr = page.Split('|');
            if (arr.Length == 1) InvokeMenuHandler(arr[0]);
            else if (arr.Length == 2)
            {
                Form form = AddMdiChild(arr[0] + ".dll", arr[1]);
                _watcher.Add(form.Name, form.Text);
            }
        }

        private void InvokeMenuHandler(string methodname)
        {
            MenuHandler hanlder = new MenuHandler();
            Type type = hanlder.GetType();
            var method = type.GetMethod(methodname, BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly | BindingFlags.IgnoreCase);
            if (method != null) method.Invoke(hanlder, new object[] { this });
        }
        #endregion

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 楼盘管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = AddMdiChild("Anju.Fangke.Client.Forms.AssetManagement.dll", "Anju.Fangke.Client.Forms.AssetManagement");
            _watcher.Add(form.Name, form.Text);
        }

        private void tabMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMenu.SelectedTab != null)
            {
                _watcher.Activate(tabMenu.SelectedTab.Name);
            }
        }

        private void 账单管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = AddMdiChild("Anju.Fangke.Client.Forms.BillManagement.dll", "Anju.Fangke.Client.Forms.BillManagement");
            _watcher.Add(form.Name, form.Text);
        }

        private void 退出ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.ShowLogin();
        }

        private void 角色管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = AddMdiChild("Anju.Fangke.Client.Forms.RoleManagement.dll", "Anju.Fangke.Client.Forms.RoleManagement");
            _watcher.Add(form.Name, form.Text);
        }

        private void 房东管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = AddMdiChild("Anju.Fangke.Client.Forms.CustomerManagement.dll", "Anju.Fangke.Client.Forms.CustomerManagement");
            _watcher.Add(form.Name, form.Text);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form form = AddMdiChild("Anju.Fangke.Client.Forms.AssetManagement.dll", "Anju.Fangke.Client.Forms.HouseManagement");
            _watcher.Add(form.Name, form.Text);
        }

        private void 房源分配ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = AddMdiChild("Anju.Fangke.Client.Forms.AssetManagement.dll", "Anju.Fangke.Client.Forms.HouseAllocate");
            _watcher.Add(form.Name, form.Text);
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
