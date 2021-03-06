﻿using System;
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

        private void cmbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBuilding.SelectedIndex == 0) return;
            string buildingID = cmbBuilding.SelectedValue?.ToString();
            QueryHouseRequest request = new QueryHouseRequest();
            request.token = Token;
            request.form = new HouseQueryForm { BuildingID = buildingID };
            SDKSync<QueryHousePagingResponse>.CreateInstance(this).Execute(request, Building_Callback);
        }

        private void Building_Callback(QueryHousePagingResponse response)
        {
            List<ReadEnum> datasource = new List<ReadEnum>();
            foreach (var house in response.List.Record)
            {
                datasource.Add(new ReadEnum
                {
                    Text = house.House.Name,
                    Value = house.House.ID,
                });
            }
            datasource.Insert(0, new ReadEnum { Value = "-1", Text = "全部" });
            cmbHouse.DataSource = datasource;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBill.CurrentRow == null)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
                return;
            }
            if (SOAFramework.Client.Controls.MessageBox.Show(this, "是否删除选中账单？", "删除", MessageBoxButtons.YesNo) == DialogResult.No) return;
            DeleteBillRequest request = new DeleteBillRequest();
            request.billid = (dgvBill.CurrentRow.DataBoundItem as DataRowView).Row["ID"].ToString();
            request.token = this.Token;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Delete_Callback);
        }

        private void Delete_Callback(CommonResponse reponse)
        {
            dgvBill.RemoveRow<DataRowView>(dgvBill.CurrentRow);
            SOAFramework.Client.Controls.MessageBox.Show(this, "删除账单成功！");
        }
    }
}
