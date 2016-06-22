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
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.Forms
{
    public partial class RentManagement : ChildForm
    {
        public RentManagement()
        {
            InitializeComponent();
        }

        private QueryOtherFeeResponse _otherfeeresponse;
        private QueryOwnerResponse _renterResponse;
        protected List<FullBuilding> _buildings;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
                return;
            }
            FullHouse house = dgvList.CurrentRow.DataBoundItem as FullHouse;
            AddRentFee form = new AddRentFee();
            form.Token = Token;
            form.FullHouse = house;
            form.OtherFees = _otherfeeresponse.List;
            form.Add_Callback += Form_Add_Callback;
            form.ShowDialog(this);
        }

        private void Form_Add_Callback(object sender, EventArgs e)
        {
            dgvList.Reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
                return;
            }
            FullHouse house = dgvList.CurrentRow.DataBoundItem as FullHouse;
            EditRentFee form = new EditRentFee();
            form.Token = Token;
            form.FullHouse = house;
            form.Update_Callback += Form_Update_Callback;
            form.OtherFees = _otherfeeresponse.List;
            form.Renters = _renterResponse.Customer;
            form.ShowDialog(this);
        }

        private void Form_Update_Callback(object sender, EventArgs e)
        {
            dgvList.Reset();
        }

        private void RentManagement_ShownOnSync(object sender, EventArgs e)
        {
            QueryOtherFeeRequest request = new QueryOtherFeeRequest();
            request.token = this.Token;
            _otherfeeresponse = SDKFactory.Client.Execute(request);

            QueryBuildingRequest buildingrequest = new QueryBuildingRequest();
            buildingrequest.token = this.Token;
            buildingrequest.form = new BuildingQueryForm();
            var buildingResposne = SDKSync<QueryBuildingResponse>.CreateInstance(this).Execute(buildingrequest);
            _buildings = buildingResposne.List;

            QueryRenterRequest renterrequest = new QueryRenterRequest();
            renterrequest.token = this.Token;
            _renterResponse = SDKFactory.Client.Execute(renterrequest);
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow == null) return;
            FullHouse house = dgvList.CurrentRow.DataBoundItem as FullHouse;
            switch (dgvList.Columns[e.ColumnIndex].Name)
            {
                case "房间名称":
                    ViewHouse viewhouse = new ViewHouse();
                    viewhouse.Buildings = _buildings;
                    viewhouse.House = house;
                    viewhouse.Token = this.Token;
                    viewhouse.Show();
                    break;
                case "楼盘名称":
                    ViewBuilding viewbuilding = new ViewBuilding();
                    viewbuilding.Token = Token;
                    viewbuilding.Building = house.Building;
                    viewbuilding.Show();
                    break;
                case "租客":
                    ViewCustomer viewcustomer = new ViewCustomer();
                    viewcustomer.Customer = house.Renter;
                    viewcustomer.Token = this.Token;
                    viewcustomer.Show();
                    break;

            }
        }

        private void btnQuery_InitClick(object sender, EventArgs e)
        {
            
        }
    }
}
