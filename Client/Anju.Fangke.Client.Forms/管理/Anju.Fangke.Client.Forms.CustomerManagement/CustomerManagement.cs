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

namespace Anju.Fangke.Client.Forms
{
    public partial class CustomerManagement : ChildForm
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddHouseOwner form = new AddHouseOwner();
            form.DataSource = dgvList.DataSource as List<Customer>;
            form.Token = this.Token;
            form.Add_Callback += Add_Callback;
            form.ShowDialog(this);
            this.Activate();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvList.SelectedRows.Count == 0)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
                return;
            }
            EditHouseOwner form = new EditHouseOwner();
            form.DataSource = dgvList.DataSource as List<Customer>;
            form.Token = this.Token;
            form.Customer = dgvList.SelectedRows[0].DataBoundItem as Customer;
            form.Edit_Callback += Edit_Callback;
            form.ShowDialog(this);
            this.Activate();
        }

        private void CustomerManagement_InitControl(object sender, EventArgs e)
        {
            if (dgvList.DataSource == null) dgvList.DataSource = new List<Customer>();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvList.CurrentRow == null)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条数据");
                return;
            }
            if (SOAFramework.Client.Controls.MessageBox.Show(this, "确认删除选中的数据吗？", "删除", MessageBoxButtons.YesNo) == DialogResult.No) return;
            DeleteCustomerRequest request = new DeleteCustomerRequest();
            request.token = this.Token;
            var customer = dgvList.CurrentRow.DataBoundItem as Customer;
            request.id = customer.ID;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Delete_Callback);
        }

        private void Delete_Callback(CommonResponse response)
        {
            dgvList.RemoveRow<Customer>(dgvList.SelectedRows[0]);
            SOAFramework.Client.Controls.MessageBox.Show(this, "删除成功");
        }

        private void Edit_Callback(object sender, EventArgs e)
        {
            this.dgvList.Reset();
        }

        private void Add_Callback(object sender, EventArgs e)
        {
            this.dgvList.Reset();
        }
    }
}
