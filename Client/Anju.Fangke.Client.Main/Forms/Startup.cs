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

namespace Anju.Fangke.Client.Main
{
    public partial class Startup : ContainerForm
    {
        private ControlWatcher _watcher = new ControlWatcher();

        public Startup()
        {
            InitializeComponent();
            tabMenu.CloseButtonClick += CloseButtonClick;
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

        private void SetTime()
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public void SetInfo(string username)
        {
            lblName.Text = username;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddMdiChild("Anju.Fangke.Client.Forms.UserManagement.dll", "Anju.Fangke.Client.Forms.UserManagement");
            _watcher.Add("UserManagement", "用户管理");
        }

        private void InitWatcher()
        {
            _watcher.AddNoticer(new TabNoticer("tabMenu", this));
            _watcher.AddNoticer(new FormNoticer(this.Name, this));
        }
    }
}
