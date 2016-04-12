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
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.Forms
{
    public partial class BillManagement : ChildForm
    {
        public BillManagement()
        {
            InitializeComponent();
        }

        private QueryBuildingResponse _buildingResponse = null;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BillManagement_InitControl(object sender, EventArgs e)
        {
            if (_buildingResponse.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, _buildingResponse.ResponseBody);
                return;
            }
            _buildingResponse.List.Insert(0, new FullBuilding { ID = "-1", Name = "全部" });
            cmbBuilding.DataSource = _buildingResponse.List;
        }

        private void BillManagement_Shown(object sender, EventArgs e)
        {
            QueryBuildingRequest request = new QueryBuildingRequest();
            request.token = Token;
            request.form = new BuildingQueryForm { };
            _buildingResponse = SDKFactory.Client.Execute(request);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBill.SelectedRows.Count == 0)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条账单");
                return;
            }
            EditBill form = new EditBill();
            form.Token = this.Token;
            form.Grid = this.dgvBill;
            form.BillID = this.dgvBill.SelectedRows[0].Cells["ID"].Value.ToString();
            form.ShowDialog(this);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            GenerateBillRequest request = new GenerateBillRequest();
            request.token = this.Token;
            SDKSync<GenerateBillResponse>.CreateInstance(this).Execute(request, Generate_Callback);
        }

        private void Generate_Callback(GenerateBillResponse response)
        {
            SOAFramework.Client.Controls.MessageBox.Show(this, "产生了" + response.Count.ToString() + "条账单，请点击查询按钮进行查询");
            btnQuery.Focus();
        }
    }
}
