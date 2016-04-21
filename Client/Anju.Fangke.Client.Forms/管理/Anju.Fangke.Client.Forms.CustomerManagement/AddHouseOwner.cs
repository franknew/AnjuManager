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
    public partial class AddHouseOwner : BaseEditCustomer
    {
        public AddHouseOwner()
        {
            InitializeComponent();
        }
        public event EventHandler Add_Callback;

        private void btnSave_ClickCallback(object sender, EventArgs e)
        {
            AddModelResponse response = btnSave.Response as AddModelResponse;
            if (response == null) return;
            Customer customer = this.CollectData<Customer>();
            customer.ID = response.ID;
            if (DataSource == null) DataSource = new List<Customer>();
            DataSource.Add(customer);
            if (Add_Callback != null) Add_Callback.Invoke(btnSave.Response, e);
            SOAFramework.Client.Controls.MessageBox.Show(this, "保存成功");
            this.Close();
        }
    }
}
