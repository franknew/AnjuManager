using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;
using SOAFramework.Client.Controls;
using SOAFramework.Client.Forms;

namespace Anju.Fangke.Client.Forms
{
    public partial class ChangeSelfPassword : PopupForm
    {
        public ChangeSelfPassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!txbNewPassword.Text.Equals(txbConfirmPassword.Text))
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "密码和确认密码不一致");
                return;
            }
            ChangeSelfPasswordRequest request = new ChangeSelfPasswordRequest();
            request.token = Token;
            request.newpassword = txbNewPassword.Text;
            request.oldpassword = txbOldPassword.Text;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request);
        }

        private void Save_Callback(CommonResponse response)
        {
            SOAFramework.Client.Controls.MessageBox.Show(this, "保存成功");
            this.Close();
        }
    }
}
