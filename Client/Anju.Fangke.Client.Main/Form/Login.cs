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

namespace Anju.Fangke.Client.Main
{
    public partial class Login : BaseForm
    {
        public Login()
        {
            InitializeComponent();
            this.ShowInTaskbar = true;
            this.ShowIcon = true;
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
                AppData.token = response.Result.token;
                AppData.User = response.Result.User.User;
                AppData.UserInfo = response.Result.User.UserInfo;
                Startup form = this.Owner as Startup;
                form.SetInfo(AppData.UserInfo.CnName);
                form.Show();
                this.Close();
            }
            else
            {
                ClientMessageBox.Show(this, response.ErrorMessage, "Error", MessageBoxButtons.YesNo);
            }
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
