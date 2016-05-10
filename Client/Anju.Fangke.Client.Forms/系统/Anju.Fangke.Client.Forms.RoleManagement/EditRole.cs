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

namespace Anju.Fangke.Client.Forms
{
    public partial class EditRole : BaseEditRole
    {
        public EditRole()
        {
            InitializeComponent();
        }

        public event EventHandler Edit_Callback;
        private FullRoleInfo _tmpRole;

        private void EditRole_InitControl(object sender, EventArgs e)
        {
            this.SetForm(Role);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _tmpRole = Role.Clone();
            this.CollectData(_tmpRole);
            _tmpRole.Authority = new List<AuthorityNodeForCheck>();
            for (int i = 0; i < chkList.Items.Count; i++)
            {
                if (chkList.GetItemChecked(i))
                {
                    var auth = chkList.Items[i] as AuthorityNodeForCheck;
                    auth.Checked = true;
                    _tmpRole.Authority.Add(auth);
                }
            }
            _tmpRole.Menus = new List<SDK.Menu>();
            for (int i = 0; i < chkMenu.Items.Count; i++)
            {
                if (chkMenu.GetItemChecked(i))
                {
                    var menu = chkMenu.Items[i] as SDK.Menu;
                    _tmpRole.Menus.Add(menu);
                }
            }
            UpdateRoleReuqest request = new UpdateRoleReuqest();
            request.token = Token;
            request.form = _tmpRole;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Save_Callback);
        }

        private void Save_Callback(CommonResponse response)
        {
            this.CollectData(Role);
            Role.Authority = _tmpRole.Authority;
            Role.Menus = _tmpRole.Menus;
            if (Edit_Callback != null) Edit_Callback.Invoke(Role, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "保存成功");
            this.Close();
        }
    }
}
