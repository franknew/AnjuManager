using SOAFramework.Client.Controls;
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

namespace Anju.Fangke.Client.Forms
{
    public partial class EditUser : BaseEditUser
    {
        public EditUser()
        {
            InitializeComponent();
        }

        public event EventHandler SaveCallback;

        private void EditUser_Load(object sender, EventArgs e)
        {
            this.SetForm(User);
        }

        private void btnSave_ClickCallback(object sender, EventArgs e)
        {
            this.CollectData<FullUser>(User);
            if (SaveCallback != null) SaveCallback.Invoke(User, e);
        }
    }
}
