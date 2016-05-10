using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SOAFramework.Client.Controls;
using SOAFramework.Client.Forms;

namespace Anju.Fangke.Client.Forms
{
    public partial class ViewCustomer : BaseEditCustomer
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void ViewCustomer_Shown(object sender, EventArgs e)
        {
            this.SetForm(Customer);
        }
    }
}
