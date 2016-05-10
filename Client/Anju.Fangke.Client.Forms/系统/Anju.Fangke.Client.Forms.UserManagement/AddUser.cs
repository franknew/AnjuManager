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

namespace Anju.Fangke.Client.Forms
{
    public partial class AddUser : BaseEditUser
    {
        public AddUser()
        {
            InitializeComponent();
        }

        public event EventHandler SaveCallback;

        private void btnSave_ClickCallback(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User = this.CollectData<FullUser>(User);
            AddUserRequest request = new AddUserRequest();
            request.token = Token;
            request.Form = User;
            request.Form.Roles = GetCheckedRoles();
            SDKSync<AddUserResponse>.CreateInstance(this).Execute(request, Add_Callback);
        }

        private void Add_Callback(AddUserResponse response)
        {
            if (SaveCallback != null) SaveCallback.Invoke(User, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "保存成功");
            this.Close();
        }
    }
}
