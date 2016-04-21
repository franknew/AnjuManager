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

        private void RoleManagement_InitControl(object sender, EventArgs e)
        {
            if (_roleReponse.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, _roleReponse.ResponseBody);
                return;
            }
            if (_roleReponse.Roles != null) _roleReponse.Roles.Insert(0, new Role { ID = "-1", Name = "全部" });
            cmbParentID.DataSource = _roleReponse.Roles;
        }
        

        private void RoleManagement_ShownOnSync(object sender, EventArgs e)
        {
            QueryRoleRequest request = new QueryRoleRequest();
            request.token = this.Token;
            request.form = new RoleQueryForm { Enabled = 1 };
            _roleReponse = SDKFactory.Client.Execute(request);
        }
    }
}
