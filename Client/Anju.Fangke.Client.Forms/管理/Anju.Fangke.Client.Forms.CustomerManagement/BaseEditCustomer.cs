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
    public partial class BaseEditCustomer : PopupForm
    {
        public BaseEditCustomer()
        {
            InitializeComponent();
        }

        public Customer Customer { get; set; }

        public List<Customer> DataSource { get; set; }
    }
}
