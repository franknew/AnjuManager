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
using SOAFramework.Library.Validator;
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.Forms
{
    public partial class BaseEditHouse : PopupForm
    {
        public BaseEditHouse()
        {
            InitializeComponent();
        }

        public int Floor { get; set; }

        public List<FullBuilding> Buildings { get; set; }

        public FullHouse House { get; set; }

        public string BuildingID { get; set; }

        private QueryOwnerResponse _ownerResponse = null;

        private void BaseEditHouse_Load(object sender, EventArgs e)
        {
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
        }
        
        private void QueryOwner_Callback(QueryOwnerResponse response)
        {
        }

        private void QueryOtherFee_CallBack(QueryOtherFeeResponse response)
        {
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
            QueryOwnerRequest ownerrequest = new QueryOwnerRequest();
            ownerrequest.token = this.Token;
            _ownerResponse = SDKFactory.Client.Execute(ownerrequest);
            //SDKSync<QueryOwnerResponse>.CreateInstance(this).Execute(ownerrequest, QueryOwner_Callback);
        }

        private void BaseEditHouse_InitControl(object sender, EventArgs e)
        {
            if (!this.CheckLoginValid(_ownerResponse)) return;
            cmbCustomer.DataSource = _ownerResponse.Customer;
            cmbBuilding.DataSource = Buildings;
            cmbBuilding.Enabled = string.IsNullOrEmpty(BuildingID);
            if(House != null) this.SetForm(House);
            if (!string.IsNullOrEmpty(BuildingID)) cmbBuilding.SelectedValue = BuildingID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddFollowup form = new AddFollowup();
            form.House = House;
            form.Add_Callback += AddFollowup_Callback;
            form.ShowDialog(this);
        }

        private void AddFollowup_Callback(object sender, EventArgs e)
        {
            if (dgvFollowup.DataSource == null) dgvFollowup.DataSource = new List<Followup>();
            var list = dgvFollowup.DataSource as List<Followup>;
            var data = sender as Followup;
            list.Add(data);
            dgvFollowup.Reset();
        }
    }
}
