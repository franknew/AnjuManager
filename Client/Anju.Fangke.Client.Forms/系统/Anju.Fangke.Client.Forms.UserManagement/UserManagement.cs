using Anju.Fangke.Client.SDK;
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

namespace Anju.Fangke.Client.Forms
{
    public partial class UserManagement : ChildForm
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private CommonResponse deleteResponse;
        private QueryRoleResponse _roleResponse;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.SaveCallback += btnAddClick_Callback;
            form.Token = Token;
            form.Roles = _roleResponse?.Roles;
            form.ShowDialog(this);
            this.dgvUsers.Reset();
        }

        private void btnAddClick_Callback(object sender, EventArgs e)
        {
            var user = sender as FullUser;
            if (dgvUsers.DataSource == null) dgvUsers.DataSource = new List<FullUser>();
            List<FullUser> list = dgvUsers.DataSource as List<FullUser>;
            list.Add(user);
            dgvUsers.Reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var user = dgvUsers.SelectedRows[0].DataBoundItem as FullUser;
                EditUser form = new EditUser();
                form.User = user;
                form.Token = Token;
                form.SaveCallback += btnEdit_Callback;
                form.Roles = _roleResponse?.Roles;
                form.ShowDialog(this);
            }
            else SOAFramework.Client.Controls.MessageBox.Show(this, "没有选择数据！", "警告");
        }

        private void btnEdit_Callback(object sender, EventArgs e)
        {
            FullUser user = sender as FullUser;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow == null) SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
            else if (SOAFramework.Client.Controls.MessageBox.Show(this, "是否删除选中数据？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                List<string> list = new List<string>();
                var user = dgvUsers.CurrentRow.DataBoundItem as FullUser;
                list.Add(user.ID);
                DeleteUserRequest request = new DeleteUserRequest();
                request.token = AppData.token;
                request.IDs = list;
                SDKSync<CommonResponse>.CreateInstance(this).Execute(request, btnDelete_ClickCallback);
            }
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                ChangePassword form = new ChangePassword();
                FullUser user = dgvUsers.CurrentRow.DataBoundItem as FullUser;
                form.UserName = user.Name;
                form.ShowDialog(this);
            }
            else SOAFramework.Client.Controls.MessageBox.Show(this, "没有选择数据", "警告");
        }

        private void btnDelete_ClickCallback(CommonResponse response)
        {
            dgvUsers.RemoveRow<FullUser>(dgvUsers.CurrentRow);
            SOAFramework.Client.Controls.MessageBox.Show(this, "删除成功！", "信息");
        }

        private void UserManagement_InitControl(object sender, EventArgs e)
        {

        }

        private void UserManagement_ShownOnSync(object sender, EventArgs e)
        {
            QueryRoleRequest request = new QueryRoleRequest();
            request.token = Token;
            request.form = new RoleQueryForm { };
            _roleResponse = SDKFactory.Client.Execute(request);
        }
    }
}
