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

namespace Anju.Fangke.Client.Forms
{
    public partial class HouseManagement : BaseQueryHouse
    {
        public HouseManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddHouse form = new AddHouse();
            form.Token = this.Token;
            form.Buildings = _buildings;
            form.Add_Callback += Form_Add_Callback;
            form.ShowDialog(this);
        }

        private void Form_Add_Callback(object sender, EventArgs e)
        {
            var house = sender as FullHouse;
            if (dgvList.DataSource == null) dgvList.DataSource = new List<FullHouse>();
            var datasouce = dgvList.DataSource as List<FullHouse>;
            datasouce.Add(house);
            dgvList.Reset();
        }

        private void HouseManagement_OnShown(object sender, EventArgs e)
        {
            QueryBuildingRequest request = new QueryBuildingRequest();
            request.token = this.Token;
            request.form = new BuildingQueryForm { };
            SDKSync<QueryBuildingResponse>.CreateInstance(this).Execute(request, QueryBuilding_Callback);
        }

        private void QueryBuilding_Callback(QueryBuildingResponse response)
        {
            _buildings = response.List;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
                return;
            }
            EditHouse form = new EditHouse();
            form.Token = this.Token;
            form.Buildings = _buildings;
            form.House = dgvList.CurrentRow.DataBoundItem as FullHouse;
            form.Update_Callback += Form_Update_Callback; ;
            form.ShowDialog(this);
        }

        private void Form_Update_Callback(object sender, EventArgs e)
        {
            dgvList.Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
                return;
            }

            if (SOAFramework.Client.Controls.MessageBox.Show(this, "确认删除选中的数据吗？", "删除", MessageBoxButtons.YesNo) == DialogResult.No) return;
            DeleteHouseRequest request = new DeleteHouseRequest();
            request.token = Token;
            var House = dgvList.CurrentRow.DataBoundItem as FullHouse;
            request.form = new HouseQueryForm { ID = House.House.ID };
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Delete_Callback);
        }

        private void Delete_Callback(CommonResponse response)
        {
            dgvList.RemoveRow<FullHouse>(dgvList.CurrentRow);
            SOAFramework.Client.Controls.MessageBox.Show(this, "删除成功");
        }
    }
}
