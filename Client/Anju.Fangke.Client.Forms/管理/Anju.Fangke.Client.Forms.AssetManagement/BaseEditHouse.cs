using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;
using Anju.Fangke.Client.SDK.Entity;
using SOAFramework.Client.Controls;
using SOAFramework.Client.Forms;
using SOAFramework.Library;
using SOAFramework.Library.Validator;

namespace Anju.Fangke.Client.Forms
{
    public partial class BaseEditHouse : PopupForm
    {
        public BaseEditHouse()
        {
            InitializeComponent();
        }
        public FullBuilding Building { get; set; }
        public int Floor { get; set; }
        public SOAFramework.Client.Controls.DataGridView Grid { get; set; }

        private List<OtherFee> _otherfee = null;

        private void BaseEditHouse_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            cmbHall.SelectedIndex = 0;
            cmbRoom.SelectedIndex = 0;
            cmbToilet.SelectedIndex = 0;
            ValidatorGroup housename = new ValidatorGroup("txbHouseName", new EmptyValidator("请输入房间名称"));
            ValidatorGroup cycle = new ValidatorGroup("txbArea", new EmptyValidator("请输入面积"));

            this.ValidationManager.AddValidatorGroup(housename);
            this.ValidationManager.AddValidatorGroup(cycle);
        }

        private void BaseEditHouse_Shown(object sender, EventArgs e)
        {
            if (DesignMode) return;
            cmbCustomer.BindingContext = new BindingContext();
            QueryOtherFeeRequest request = new QueryOtherFeeRequest();
            request.token = this.Token;
            SDKSync<QueryOtherFeeResponse>.CreateInstance(this).Execute(request, QueryOtherFee_CallBack);

            QueryOwnerRequest ownerrequest = new QueryOwnerRequest();
            ownerrequest.token = this.Token;
            SDKSync<QueryOwnerResponse>.CreateInstance(this).Execute(ownerrequest, QueryOwner_Callback);
        }
        
        private void QueryOwner_Callback(QueryOwnerResponse response)
        {
            cmbCustomer.DataSource = response.Customer;
        }

        private void QueryOtherFee_CallBack(QueryOtherFeeResponse response)
        {
            _otherfee = response.List;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddHouseOwner form = new AddHouseOwner();
            form.Token = this.Token;
            form.DataSource = cmbCustomer.DataSource as List<Customer>;
            form.Add_Callback += AddCustomer_Callback;
            form.ShowDialog();
        }

        private void AddCustomer_Callback(object sender, EventArgs e)
        {
            cmbCustomer.Reset();
            //cmbCustomer.CreateControl();
            cmbCustomer.SelectedIndex = cmbCustomer.Items.Count - 1;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = cmbCustomer.SelectedItem as Customer;
            txbMobile.Text = customer.Mobile;
        }

        private void BaseEditHouse_ShownOnSync(object sender, EventArgs e)
        {

        }
    }
}
