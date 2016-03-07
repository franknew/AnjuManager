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

namespace Anju.Fangke.Client.Forms
{
    public partial class BaseEditUser : PopupForm
    {
        protected bool _needRemoveCurrent = true;

        public BaseEditUser()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_ClickCallback(object sender, EventArgs e)
        {
            this.FlushBinding();
        }

        private void BeforeClick(object sender, EventArgs e)
        {
            //switch (Mode)
            //{
            //    case EditMode.Add:
            //        btnSave.RequestName = "AddUserRequest";
            //        break;
            //    default:
            //        btnSave.RequestName = "UpdateUserRequest";
            //        break;
            //}
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            //txbUserName.Enabled = Mode == EditMode.Add;
            //switch (Mode)
            //{
            //    case EditMode.Add:
            //        txbUserName.Focus();
            //        break;
            //    case EditMode.Edit:
            //        txbCnName.Focus();
            //        _needRemoveCurrent = false;
            //        break;
            //}
        }

        private void BaseEditUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_needRemoveCurrent)
            {
                this.Binding.RemoveCurrent();
            }
        }
    }
}
