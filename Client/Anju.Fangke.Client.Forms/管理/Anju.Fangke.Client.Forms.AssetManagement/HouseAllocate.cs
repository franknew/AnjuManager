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
    public partial class HouseAllocate : BaseQueryHouse
    {
        public HouseAllocate()
        {
            InitializeComponent();
        }

        private void btnAllocate_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
                return;
            }
            FullHouse house = dgvList.SelectedRows[0].DataBoundItem as FullHouse;
            AllocatePopup form = new AllocatePopup();
            form.House = house;
            form.Token = this.Token;
            form.SaveCallback += Allocate_Callback;
            form.ShowDialog(this);
        }

        private void Allocate_Callback(object sender, EventArgs e)
        {
            dgvList.Reset();
            SOAFramework.Client.Controls.MessageBox.Show(this, "保存成功");
        }

        private void HouseAllocate_Shown(object sender, EventArgs e)
        {
            QueryUserRequest request = new QueryUserRequest();
            request.token = this.Token;
            request.form = new FullUserQueryForm();
            SDKSync<QueryUserResponse>.CreateInstance(this).Execute(request, QueryUser_Callback);
        }

        private void QueryUser_Callback(QueryUserResponse response)
        {
            if (response.Users != null) response.Users.Insert(0, new FullUser { ID = "-1", CnName = "全部" });
            cmbOwner.DataSource = response.Users;
        }
    }
}
