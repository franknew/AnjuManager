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
using SOAFramework.Library;

namespace Anju.Fangke.Client.Forms
{
    public partial class EditHouseOwner : BaseEditCustomer
    {
        public EditHouseOwner()
        {
            InitializeComponent();
        }

        public event EventHandler Edit_Callback;

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = this.Customer.Clone();
            this.CollectData<Customer>(customer);
            UpdateCustomerRequest request = new UpdateCustomerRequest();
            request.token = Token;
            request.form = customer;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Save_Callback);
        }

        private void Save_Callback(CommonResponse reponse)
        {
            this.CollectData<Customer>(this.Customer);
            if (Edit_Callback != null) Edit_Callback.Invoke(reponse, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "保存成功");
            this.Close();
        }

        private void EditHouseOwner_InitControl(object sender, EventArgs e)
        {
            this.SetForm(Customer);
        }
    }
}
