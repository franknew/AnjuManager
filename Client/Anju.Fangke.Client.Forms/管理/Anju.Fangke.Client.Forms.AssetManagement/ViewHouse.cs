using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;

namespace Anju.Fangke.Client.Forms
{
    public partial class ViewHouse : BaseEditHouse
    {
        public ViewHouse()
        {
            InitializeComponent();
        }

        private void ViewHouse_InitControl(object sender, EventArgs e)
        {
            var customers = cmbCustomer.DataSource as List<Customer>;
            if (!customers.Exists(t => t.ID.Equals(House.Customer.ID)))
            {
                cmbCustomer.Items.Add(House.Customer);
                cmbCustomer.SelectedItem = House.Customer;
            }
        }
    }
}
