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
    public partial class FollowupManagement : ChildForm
    {
        public FollowupManagement()
        {
            InitializeComponent();
            pager1.Paging += Pager1_Paging;
        }

        private List<FullBuilding> _buildings;

        private void Pager1_Paging(object sender, SOAFramework.Client.Controls.Pager.PagingEventArgs e)
        {
            btnQuery.StartSyncClick(this);
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = dgvList.Columns[e.ColumnIndex];
            FullFollowup row = dgvList.Rows[e.RowIndex].DataBoundItem as FullFollowup;
            switch (column.Name)
            {
                case "楼盘名称":
                    ViewBuilding viewbuilding = new ViewBuilding();
                    viewbuilding.Token = Token;
                    viewbuilding.Building = row.Building;
                    viewbuilding.Show();
                    break;
                case "房间名称":
                    ViewHouse viewhouse = new ViewHouse();
                    viewhouse.Buildings = _buildings;
                    viewhouse.House = new FullHouse { House = row.House as DisplayHouse, Customer = row.Owner, Building = row.Building, Owner = row.User, };
                    viewhouse.Token = this.Token;
                    viewhouse.Show();
                    break;
                case "业主信息":
                    ViewCustomer form = new ViewCustomer();
                    form.Customer = row.Owner;
                    form.Show(this);
                    break;
                case "跟进信息":
                    ViewFollowup viewfollowup = new ViewFollowup();
                    viewfollowup.Remark = row.Followup.Remark;
                    viewfollowup.Show(this);
                    break;
            }
        }

        private void FollowupManagement_ShownOnSync(object sender, EventArgs e)
        {
            QueryBuildingRequest request = new QueryBuildingRequest();
            request.token = this.Token;
            var response = SDKFactory.Client.Execute(request);
            _buildings = response.List;
        }

        private void FollowupManagement_Shown(object sender, EventArgs e)
        {
            dtCreateTime_Start.Value = DateTime.Now.AddDays(-7);
            dtCreateTime_End.Value = DateTime.Now;
        }

        private void btnQuery_InitClick(object sender, EventArgs e)
        {
            pager1.CurrentPageIndex = 1;
            btnQuery.StartSyncClick(this);
        }
    }
}
