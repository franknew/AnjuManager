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
    public partial class BaseQueryHouse : ChildForm
    {
        public BaseQueryHouse()
        {
            InitializeComponent();
            pager1.Paging += Pager1_Paging;
        }

        private void Pager1_Paging(object sender, SOAFramework.Client.Controls.Pager.PagingEventArgs e)
        {
            btnQuery.StartSyncClick(this);
        }

        protected List<FullBuilding> _buildings;

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.CurrentRow == null) return;
            FullHouse house = dgvList.CurrentRow.DataBoundItem as FullHouse;
            switch (dgvList.Columns[e.ColumnIndex].Name)
            {
                case "业主信息":
                    ViewCustomer form = new ViewCustomer();
                    form.Customer = house.Customer;
                    form.Show();
                    break;
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
            }
            if (!dgvList.Columns[e.ColumnIndex].Equals(业主信息) || dgvList.CurrentRow == null) return;

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
        }

        private void btnQuery_InitClick(object sender, EventArgs e)
        {
            pager1.CurrentPageIndex = 1;
            btnQuery.StartSyncClick(this);
        }
    }
}
