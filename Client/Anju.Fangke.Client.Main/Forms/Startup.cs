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
            _watcher.Add("UserManagement", form.Text);
        }

        private void show_click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
            }
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
        #endregion
    }
}
