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
    public partial class OwnerManagement : BaseCustomerManagement
    {
        public OwnerManagement()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
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

        private void Edit_Callback(object sender, EventArgs e)
        {
            this.dgvList.Reset();
        }

        private void Add_Callback(object sender, EventArgs e)
        {
            this.dgvList.Reset();
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
    }
}
