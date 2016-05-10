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
    public partial class AddFollowup : BaseEditFollowup
    {
        public AddFollowup()
        {
            InitializeComponent();
        }

        public event EventHandler Add_Callback;

        private void btnSave_Click(object sender, EventArgs e)
        {
            Followup f = new Followup { HouseID = House.House.ID, Remark = txbRemark.Text, CreatorName = AppData.UserInfo.CnName };
            if (Add_Callback != null) Add_Callback.Invoke(f, e);
            this.Close();
        }
    }
}
