using SOAFramework.Client.Controls;
using SOAFramework.Client.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;

namespace Anju.Fangke.Client.Forms
{
    public partial class BaseEditUser : PopupForm
    {
        protected bool _needRemoveCurrent = true;

        public BaseEditUser()
        {
            InitializeComponent();
        }

        public FullUser User { get; set; }

        public List<Role> Roles { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaseEditUser_OnShown(object sender, EventArgs e)
        {
            chkRole.ValueMember = "ID";
            chkRole.DisplayMember = "Remark";
            if (Roles != null)
            {
                for (int i = 0; i < Roles.Count; i++)
                {
                    var role = Roles[i];
                    chkRole.Items.Add(role);
                    if (User != null && User.Roles != null) if (User.Roles.Exists(t => t.ID.Equals(role.ID))) chkRole.SetItemChecked(i, true);
                }
            }
        }

        public List<Role> GetCheckedRoles()
        {
            List<Role> list = new List<Role>();
            for (int i = 0; i < chkRole.Items.Count; i++)
            {
                var Role = chkRole.Items[i] as Role;
                if (chkRole.GetItemChecked(i)) list.Add(Role);
            }
            return list;
        }
    }
}
