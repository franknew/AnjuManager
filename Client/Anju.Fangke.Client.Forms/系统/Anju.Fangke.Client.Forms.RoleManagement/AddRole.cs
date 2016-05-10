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
    public partial class AddRole : BaseEditRole
    {
        public AddRole()
        {
            InitializeComponent();
        }

        public event EventHandler Add_Callback;

        private void AddRole_InitControl(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validate()) return;
            var role = this.CollectData<FullRoleInfo>();
            role.Authority = new List<AuthorityNodeForCheck>();
            for(int i = 0; i < chkList.Items.Count; i++)
            {
                if (chkList.GetItemChecked(i))
                {
                    var auth = chkList.Items[i] as AuthorityNodeForCheck;
                    auth.Checked = true;
                    role.Authority.Add(auth);
                }
            }
            role.Menus = new List<SDK.Menu>();
            for (int i = 0; i < chkMenu.Items.Count; i++)
            {
                if (chkMenu.GetItemChecked(i))
                {
                    var menu = chkMenu.Items[i] as SDK.Menu;
                    role.Menus.Add(menu);
                }
            }
            AddRoleRequest request = new AddRoleRequest();
            request.token = Token;
            request.form = role;
            SDKSync<AddModelResponse>.CreateInstance(this).Execute(request, Save_Callback);
        }

        private void Save_Callback(AddModelResponse response)
        {
            if (Add_Callback != null) Add_Callback.Invoke(Role, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "新增角色成功");
        }
    }
}
