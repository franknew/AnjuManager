using Anju.Fangke.Client.SDK;
using Anju.Fangke.Server.Model;
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
            QueryDataDictionaryByNameRequest request = new QueryDataDictionaryByNameRequest();
            request.NameList = new List<string> { "启用状态" };
            request.token = AppData.token;
            var response = SDKFactory.Client.Execute(request);
            if (response.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, response.ErrorMessage);
                return;
            }
            var form = response.Result.Find(t => t.Group.Name == "启用状态");
            form.Items.Insert(0, new DataDictionary { Value = -1, Name = "全部" });
            cmbEnabled.DataSource = form.Items;
            this.Binding.DataSource = new List<FullUser>();
            dgvUsers.DataSource = this.Binding;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvUsers.NewRow();
            row.Cells["启用"].Value = 1;
            EditUser form = new EditUser();
            form.Mode = EditMode.Add;
            form.Binding = this.Binding;
            form.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                EditUser form = new EditUser();
                form.Mode = EditMode.Edit;
                form.Binding = this.Binding;
                form.ShowDialog(this);
            }
            else
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "没有选择数据！", "警告");
            }
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
            else
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "没有选择数据！", "警告");
            }
        }

        private void btnAuthority_Click(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                ChangePassword form = new ChangePassword();
                form.Binding = this.Binding;
                form.ShowDialog(this);
            }
            else
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "没有选择数据！", "警告");
            }
        }

        private void btnDelete_ClickCallback(object sender, EventArgs e)
        {
            if (deleteResponse == null)
            {
                return;
            }

            if (deleteResponse.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, deleteResponse.ErrorMessage, "错误");
            }
            else
            {
                this.Binding.RemoveCurrent();
                SOAFramework.Client.Controls.MessageBox.Show(this, "操作成功！", "信息");
            }
        }
    }
}
