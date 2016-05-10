using SOAFramework.Client.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;
using SOAFramework.Client.Forms;
using SOAFramework.Library;

namespace Anju.Fangke.Client.Forms
{
    public partial class EditUser : BaseEditUser
    {
        public EditUser()
        {
            InitializeComponent();
        }

        public event EventHandler SaveCallback;

        private void EditUser_Load(object sender, EventArgs e)
        {
            this.SetForm(User);
        }

        private void btnSave_ClickCallback(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = User.Clone();
            this.CollectData<FullUser>(user);
            UpdateUserRequest request = new UpdateUserRequest();
            request.token = Token;
            request.Form = user;
            request.Form.Roles = GetCheckedRoles();
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Save_Callback);
        }

        private void Save_Callback(CommonResponse response)
        {
            this.CollectData<FullUser>(User);
            if (SaveCallback != null) SaveCallback.Invoke(User, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "保存成功");
            this.Close();
        }
    }
}
