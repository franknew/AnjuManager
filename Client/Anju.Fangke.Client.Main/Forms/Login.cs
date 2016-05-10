using Anju.Fangke.Client.SDK;
using MetroFramework.Forms;
using SOAFramework.Client.Controls;
using SOAFramework.Client.Forms;
using SOAFramework.Service.SDK.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SOAFramework.Library;
using System.IO;

namespace Anju.Fangke.Client.Main
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
            this.FormClosed += Login_FormClosed;
        }

        private static string _loginfilepath = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\') + @"\Config\LoginInfo.xml";

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MetroForm form = this.Owner as MetroForm;
            form.Disposed = true;
            form.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassword.Text;
            LoginRequest request = new LoginRequest();
            request.UserName = username;
            request.Password = password;
            var response = SDKFactory.Client.Execute(request);
            if (!response.IsError)
            {
                AppData.token = response.Result?.token;
                AppData.User = response.Result?.User?.User;
                AppData.UserInfo = response.Result?.User?.UserInfo;

                LoginInfo info = new LoginInfo { RemberMe = chkRemberMe.Checked, UserName = txbUserName.Text };
                string xml = XMLHelper.Serialize(info);
                FileInfo file = new FileInfo(_loginfilepath);
                if (!file.Directory.Exists) file.Directory.Create();
                File.WriteAllText(file.FullName, xml);

                Startup form = this.Owner as Startup;
                form.Token = AppData.token;
                form.SetInfo(AppData.UserInfo?.CnName);
                form.CreateMenu(response.Result.Menu);
                form.Show();
                this.Close();
            }
            else SOAFramework.Client.Controls.MessageBox.Show(this, response.ErrorMessage, "Error", MessageBoxButtons.OK);
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) btnLogin.PerformClick();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //btnLogin.PerformClick();
            this.Activate();
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(_loginfilepath);
            if (!file.Directory.Exists) file.Directory.Create();
            if (!file.Exists) return;
            string xml = File.ReadAllText(file.FullName);
            var info = XMLHelper.Deserialize<LoginInfo>(xml);
            chkRemberMe.Checked = info.RemberMe;
            if (info.RemberMe)
            {
                txbUserName.Text = info.UserName;
                txbPassword.Focus();
            }
            else txbUserName.Focus();
        }
    }
}
