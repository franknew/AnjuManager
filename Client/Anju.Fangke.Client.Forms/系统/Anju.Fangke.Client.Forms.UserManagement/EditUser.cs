using SOAFramework.Client.Controls;
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
    public partial class EditUser : BaseEditUser
    {
        public EditUser()
        {
            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            _needRemoveCurrent = false;
        }

        private void btnSave_ClickCallback(object sender, EventArgs e)
        {
            this.FlushBinding();
        }
    }
}
