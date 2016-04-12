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
    public partial class AddOtherFee : PopupForm
    {
        public AddOtherFee()
        {
            InitializeComponent();
        }

        public List<OtherFee> OtherFee { get; set; }

        public event EventHandler AddClick_Callback;

        private void AddOtherFee_Shown(object sender, EventArgs e)
        {
            if (DesignMode) return;
            if (OtherFee == null) return;
            cmbOtherFee.DataSource = OtherFee;
            cmbOtherFee.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbOtherFee.SelectedIndex == -1)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一个费用");
                return;
            }
            var selected = OtherFee.Find(t => t.ID.Equals(cmbOtherFee.SelectedValue?.ToString()));
            if (AddClick_Callback != null) AddClick_Callback.Invoke(selected, e);
        }
    }
}
