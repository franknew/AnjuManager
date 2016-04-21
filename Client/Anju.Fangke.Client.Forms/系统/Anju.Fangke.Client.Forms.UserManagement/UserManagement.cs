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
            this.btnDelete.Click += this.btnDelete_Click;
        }

        private CommonResponse deleteResponse;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {
            this.Binding.DataSource = new List<FullUser>();
            dgvUsers.DataSource = this.Binding;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddUser form = new AddUser();
            form.SaveCallback += btnAddClick_Callback;
            form.ShowDialog(this);
            this.dgvUsers.Reset();
        }

        private void btnAddClick_Callback(object sender, EventArgs e)
        {
            var user = sender as FullUser;
            List<FullUser> list = dgvUsers.DataSource as List<FullUser>;
            if (list == null)
            {
                list = new List<FullUser>();
                dgvUsers.DataSource = list;
            }
            list.Add(user);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                EditUser form = new EditUser();
                form.User = dgvUsers.SelectedRows[0].DataBoundItem as FullUser;
                form.SaveCallback += btnEdit_Callback;
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
            if (dgvUsers.SelectedRows.Count > 0)
            {
                if (SOAFramework.Client.Controls.MessageBox.Show(this, "是否删除选中数据？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<string> list = new List<string>();
                    foreach (DataGridViewRow row in dgvUsers.SelectedRows)
                    {
                        list.Add(row.Cells["ID"].Value.ToString());
                    }
                    DeleteUserRequest request = new DeleteUserRequest();
                    request.token = AppData.token;
                    request.IDs = list;
                    deleteResponse = SDKFactory.Client.Execute(request);
                }
            }
            else SOAFramework.Client.Controls.MessageBox.Show(this, "请选择数据！", "警告");
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                ChangePassword form = new ChangePassword();
                FullUser user = dgvUsers.SelectedRows[0].DataBoundItem as FullUser;
                form.UserName = user.Name;
                form.ShowDialog(this);
            }
            else
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "没有选择数据！", "警告");
            }
        }

        private void btnDelete_ClickCallback(object sender, EventArgs e)
        {
            if (deleteResponse == null)  return;

            if (deleteResponse.IsError) SOAFramework.Client.Controls.MessageBox.Show(this, deleteResponse.ErrorMessage, "错误");
            else
            {
                var list = dgvUsers.DataSource as List<FullUser>;
                list.Remove(dgvUsers.SelectedRows[0].DataBoundItem as FullUser);
                dgvUsers.Reset();
                SOAFramework.Client.Controls.MessageBox.Show(this, "操作成功！", "信息");
            }
        }

        private void UserManagement_InitControl(object sender, EventArgs e)
        {

        }
    }
}
