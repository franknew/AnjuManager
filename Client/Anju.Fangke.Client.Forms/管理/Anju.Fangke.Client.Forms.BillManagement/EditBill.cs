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
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.Forms
{
    public partial class EditBill : PopupForm
    {
        public EditBill()
        {
            InitializeComponent();
        }

        public System.Windows.Forms.DataGridView Grid { get; set; }

        public string BillID { get; set; }

        public BillModel Bill { get; set; }
        private QuerySingleBillResponse _response = null;

        private void EditBill_Shown(object sender, EventArgs e)
        {
            QuerySingleBillRequest request = new QuerySingleBillRequest();
            request.token = Token;
            request.BillID = BillID;
            _response = SDKFactory.Client.Execute(request);
        }

        private void EditBill_InitControl(object sender, EventArgs e)
        {
            if (_response.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, _response.ErrorMessage);
                return;
            }
            this.SetForm(_response.Bill);
            txbRentDay.Text = new DateTime(_response.Bill.Bill.Year.Value, _response.Bill.Bill.Month.Value, _response.Bill.Bill.RentDay).ToString("yyyy-MM-dd");
        }

        private void dgvList_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvList.EndEdit();
            if (dgvList.Columns[e.ColumnIndex].Name == "上月计数" || dgvList.Columns[e.ColumnIndex].Name == "本月计数")
            {
                DataGridViewRow row = dgvList.Rows[e.RowIndex];
                var bill = dgvList.Rows[e.RowIndex].DataBoundItem as FullOtherFeeBill;

                var unitprice = bill.OtherFee.UnitPrice;
                var startvalue = Convert.ToInt32(row.Cells["上月计数"].GetValue());
                var endvalue = Convert.ToInt32(row.Cells["本月计数"].GetValue());
                bill.OtherFeeBill.StartValue = startvalue;
                bill.OtherFeeBill.EndValue = endvalue;
                if (endvalue <= 0) return;
                var fee = (endvalue - startvalue) * unitprice;
                bill.OtherFeeBill.Fee = fee;
                decimal totalfee = 0;
                List<FullOtherFeeBill> source = dgvList.DataSource as List<FullOtherFeeBill>;
                foreach (var r in source)
                {
                    totalfee += r.OtherFeeBill.Fee.Value;
                }
                totalfee += Convert.ToDecimal(txbRentFee.Text);
                updShouldPay.Value = totalfee;
                dgvList.Invalidate();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.CollectData<BillModel>(Bill);
            UpdateBillModelRequest request = new UpdateBillModelRequest();
            request.token = Token;
            request.Bill = Bill;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Save_Callback);
        }

        private void Save_Callback(CommonResponse response)
        {
            SOAFramework.Client.Controls.MessageBox.Show(this, "账单更新成功");
        }
    }
}
