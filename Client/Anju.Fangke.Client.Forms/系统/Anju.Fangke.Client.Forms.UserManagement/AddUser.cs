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
    public partial class AddUser : BaseEditUser
    {
        public AddUser()
        {
            InitializeComponent();
        }

        public event EventHandler SaveCallback;

        private void btnSave_ClickCallback(object sender, EventArgs e)
        {
            var user = this.CollectData<FullUser>();
            if (SaveCallback != null) SaveCallback.Invoke(user, e);
        }
    }
}
