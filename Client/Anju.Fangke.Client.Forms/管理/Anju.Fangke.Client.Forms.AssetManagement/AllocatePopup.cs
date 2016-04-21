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
    public partial class AllocatePopup : PopupForm
    {
        public AllocatePopup()
        {
            InitializeComponent();
        }

        public FullHouse House { get; set; }

        public event EventHandler SaveCallback;

        private void LoadUser_Callback(QueryUserResponse response)
        {
            cmbEmployee.DataSource = response.Users;
        }

        private void AllocatePopup_Shown(object sender, EventArgs e)
        {
            QueryUserRequest request = new QueryUserRequest();
            request.token = this.Token;
            request.form = new FullUserQueryForm { };
            SDKSync<QueryUserResponse>.CreateInstance(this).Execute(request, LoadUser_Callback);
        }

        private void AllocatePopup_InitControl(object sender, EventArgs e)
        {
            txbHouseID.Text = House.House.ID;
            cmbEmployee.SelectedValue = House.House.OwnerID;
        }

        private void btnSave_ClickCallback(object sender, EventArgs e)
        {
            House.Owner = cmbEmployee.SelectedItem as FullUser;
            if (SaveCallback != null) SaveCallback.Invoke(sender, e);
            this.Close();
        }
    }
}
