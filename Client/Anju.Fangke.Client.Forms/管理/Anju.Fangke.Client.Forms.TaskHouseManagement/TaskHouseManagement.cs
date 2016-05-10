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
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.Forms
{
    public partial class TaskHouseManagement : ChildForm
    {
        public TaskHouseManagement()
        {
            InitializeComponent();
        }

        private List<FullBuilding> _buildings;

        private void btnTaskHouse_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null) SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
            FullHouse house = dgvList.CurrentRow.DataBoundItem as FullHouse;
            TaskHouse form = new TaskHouse();
            form.House = house.House;
            form.Token = this.Token;
            form.Take_Callback += Form_Take_Callback;
            form.ShowDialog(this);
        }

        private void Form_Take_Callback(object sender, EventArgs e)
        {
            dgvList.RemoveRow<FullHouse>(dgvList.CurrentRow);
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow == null) return;
            FullHouse house = dgvList.CurrentRow.DataBoundItem as FullHouse;
            switch (dgvList.Columns[e.ColumnIndex].Name)
            {
                case "楼盘名称":
                    ViewBuilding building = new ViewBuilding();
                    building.Building = house.Building;
                    building.Token = this.Token;
                    building.Show();
                    break;
                case "房间名称":
                    ViewHouse viewhouse = new ViewHouse();
                    viewhouse.Buildings = _buildings;
                    viewhouse.House = house;
                    viewhouse.Token = Token;
                    viewhouse.Show();
                    break;
                case "业主信息":
                    ViewCustomer viewcustomer = new ViewCustomer();
                    viewcustomer.Customer = house.Customer;
                    viewcustomer.Token = Token;
                    viewcustomer.Show();
                    break;
            }
        }

        private void TaskHouseManagement_ShownOnSync(object sender, EventArgs e)
        {
            QueryBuildingRequest request = new QueryBuildingRequest();
            request.form = new BuildingQueryForm { };
            request.token = this.Token;
            var response = SDKFactory.Client.Execute(request);
            _buildings = response.List;
        }
    }
}
