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
    public partial class BaseCustomerManagement : ChildForm
    {
        public BaseCustomerManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
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

    }
}
