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
    public partial class ChangePassword : PopupForm
    {
        public List<string> UserNameList { get; set; }

        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
