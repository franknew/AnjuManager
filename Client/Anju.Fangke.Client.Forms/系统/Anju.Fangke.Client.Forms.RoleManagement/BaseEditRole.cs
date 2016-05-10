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
using SOAFramework.Library.Validator;

namespace Anju.Fangke.Client.Forms
{
    public partial class BaseEditRole : PopupForm
    {
        public BaseEditRole()
        {
            InitializeComponent();
        }

        public List<Role> Roles { get; set; }

        public List<SDK.Menu> Menus { get; set; }

        public FullRoleInfo Role { get; set; }

        private void BaseEditRole_InitControl(object sender, EventArgs e)
        {
            chkList.DisplayMember = "Name";
            chkList.ValueMember = "ID";
            if (Role.Authority != null)
            {
                for (int i = 0; i < Role.Authority.Count; i++)
                {
                    var auth = Role.Authority[i];
                    chkList.Items.Add(auth);
                    chkList.SetItemChecked(i, auth.Checked);
                }
            }

            chkMenu.DisplayMember = "Name";
            chkMenu.ValueMember = "ID";
            if (Menus != null)
            {
                for (int i = 0; i < Menus.Count; i++)
                {
                    var menu = Menus[i];
                    chkMenu.Items.Add(menu);
                    if (Role != null && Role.Menus != null) if (Role.Menus.Exists(t => t.ID.Equals(menu.ID))) chkMenu.SetItemChecked(i, true);
                }
            }

            var roles = Roles.ToList();
            roles.Insert(0, new Role { ID = "-1", Name = "" });
            cmbRole.DataSource = roles;
        }

        private void BaseEditRole_Load(object sender, EventArgs e)
        {
            ValidatorGroup name = new ValidatorGroup("txbName", new EmptyValidator("请输入角色名称"));
            this.ValidationManager.AddValidatorGroup(name);
        }
    }
}
