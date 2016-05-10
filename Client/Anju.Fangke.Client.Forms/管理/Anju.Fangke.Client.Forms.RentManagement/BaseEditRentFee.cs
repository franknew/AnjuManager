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
    public partial class BaseEditRentFee : PopupForm
    {
        public BaseEditRentFee()
        {
            InitializeComponent();
        }

        public List<OtherFee> OtherFees { get; set; }

        public FullHouse FullHouse { get; set; }

        private void btnAddFee_Click(object sender, EventArgs e)
        {
            AddOtherFee form = new AddOtherFee();
            form.OtherFee = OtherFees;
            form.Token = Token;
            form.AddClick_Callback += Form_AddClick_Callback;
            form.ShowDialog(this);
        }

        private void Form_AddClick_Callback(object sender, EventArgs e)
        {
            OtherFee of = sender as OtherFee;
            bool hasFee = false;
            foreach (DataGridViewRow row in dgvOtherFee.Rows)
            {
                OtherFee rowFee = row.DataBoundItem as OtherFee;
                if (of.ID.Equals(rowFee.ID))
                {
                    hasFee = true;
                    break;
                }
            }
            if (dgvOtherFee.DataSource == null) dgvOtherFee.DataSource = new List<OtherFee>();
            var list = dgvOtherFee.DataSource as List<OtherFee>;
            if (!hasFee) list.Add(of);
            dgvOtherFee.Reset();
        }

        private void BaseEditRentFee_InitControl(object sender, EventArgs e)
        {
            if (FullHouse != null) this.SetForm(FullHouse);
        }
    }
}
