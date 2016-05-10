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
using SOAFramework.Library;
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.Forms
{
    public partial class RoleManagement : ChildForm
    {
        public RoleManagement()
        {
            InitializeComponent();
        }

        private QueryRoleResponse _roleReponse = null;
        private QueryAuthorityResponse _authResponse = null;
        private QueryMenuResponse _menuResponse = null;

        private void RoleManagement_InitControl(object sender, EventArgs e)
        {
            if (_roleReponse.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, _roleReponse.ResponseBody);
                return;
            }
            var roleList = _roleReponse.Roles?.ToList();
            if (roleList != null) roleList.Insert(0, new Role { ID = "-1", Name = "全部" });
            cmbParentID.DataSource = roleList;
        }
        

        private void RoleManagement_ShownOnSync(object sender, EventArgs e)
        {
            QueryRoleRequest request = new QueryRoleRequest();
            request.token = this.Token;
            request.form = new RoleQueryForm { Enabled = 1 };
            _roleReponse = SDKFactory.Client.Execute(request);

            QueryAuthorityRequest authrequest = new QueryAuthorityRequest();
            authrequest.token = this.Token;
            _authResponse = SDKFactory.Client.Execute(authrequest);

            QueryMenuRequest menurequest = new QueryMenuRequest();
            menurequest.token = Token;
            menurequest.form = new MenuQueryForm { Enabled = 1 };
            _menuResponse = SDKFactory.Client.Execute(menurequest);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRole form = new AddRole();
            form.Token = Token;
            form.Add_Callback += Add_Callback;
            form.Role = new FullRoleInfo { Authority = _authResponse?.Authority };
            form.Roles = _roleReponse?.Roles;
            form.Menus = _menuResponse?.Menus;
            form.ShowDialog(this);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null) SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
            else
            {
                var role = dgvList.CurrentRow.DataBoundItem as FullRoleInfo;
                EditRole form = new EditRole();
                form.Token = Token;
                form.Role = role;
                form.Edit_Callback += Form_Edit_Callback;
                form.Roles = _roleReponse?.Roles;
                form.Menus = _menuResponse?.Menus;
                form.ShowDialog(this);
            }
        }

        private void Form_Edit_Callback(object sender, EventArgs e)
        {
            dgvList.Reset();
        }

        private void Add_Callback(object sender, EventArgs e)
        {
            FullRoleInfo role = sender as FullRoleInfo;
            if (dgvList.DataSource == null) dgvList.DataSource = new List<FullRoleInfo>();
            var list = dgvList.DataSource as List<FullRoleInfo>;
            list.Add(role);
            dgvList.Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null) SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
            else if (SOAFramework.Client.Controls.MessageBox.Show(this,"是否删除选中的数据？", "警告", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var role = dgvList.CurrentRow.DataBoundItem as FullRoleInfo;
                DeleteRoleRequest request = new DeleteRoleRequest();
                request.token = Token;
                request.RoleID = role.ID;
                SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Delete_Callback);
            }
        }

        private void Delete_Callback(CommonResponse response)
        {
            dgvList.RemoveRow(dgvList.CurrentRow);
            SOAFramework.Client.Controls.MessageBox.Show(this, "删除成功");
        }
    }
}
