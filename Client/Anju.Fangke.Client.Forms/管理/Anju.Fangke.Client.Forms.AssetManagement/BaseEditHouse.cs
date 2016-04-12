using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;
using Anju.Fangke.Client.SDK.Entity;
using SOAFramework.Client.Controls;
using SOAFramework.Client.Forms;
using SOAFramework.Library;
using SOAFramework.Library.Validator;

namespace Anju.Fangke.Client.Forms
{
    public partial class BaseEditHouse : PopupForm
    {
        public BaseEditHouse()
        {
            InitializeComponent();
        }
        public FullBuilding Building { get; set; }
        public int Floor { get; set; }
        public SOAFramework.Client.Controls.DataGridView Grid { get; set; }

        private List<OtherFee> _otherfee = null;

        private void BaseEditHouse_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            cmbHall.SelectedIndex = 0;
            cmbRoom.SelectedIndex = 0;
            cmbToilet.SelectedIndex = 0;
            ValidatorGroup housename = new ValidatorGroup("txbHouseName", new EmptyValidator("请输入房间名称"));
            ValidatorGroup rentfee = new ValidatorGroup("txbRentFee", new EmptyValidator("请输入租金"));
            ValidatorGroup desipot = new ValidatorGroup("txbDeposit", new EmptyValidator("请输入押金"));
            ValidatorGroup cycle = new ValidatorGroup("numCycle", new EmptyValidator("请输入收租周期"));
            ValidatorGroup rentday = new ValidatorGroup("numRentDay", new EmptyValidator("请输入收租日"));

            this.ValidationManager.AddValidatorGroup(housename);
            this.ValidationManager.AddValidatorGroup(rentfee);
            this.ValidationManager.AddValidatorGroup(desipot);
            this.ValidationManager.AddValidatorGroup(cycle);
            this.ValidationManager.AddValidatorGroup(rentday);
        }

        private void BaseEditHouse_Shown(object sender, EventArgs e)
        {
            if (DesignMode) return;
            QueryOtherFeeRequest request = new QueryOtherFeeRequest();
            request.token = this.Token;
            SDKSync<QueryOtherFeeResponse>.CreateInstance(this).Execute(request, QueryOtherFee_CallBack);
        }

        private void QueryOtherFee_CallBack(QueryOtherFeeResponse response)
        {
            _otherfee = response.List;
        }

        private void btnAddOtherFee_Click(object sender, EventArgs e)
        {
            AddOtherFee form = new AddOtherFee();
            form.OtherFee = _otherfee;
            form.AddClick_Callback += AddOtherFee_Callback;
            form.ShowDialog(this);
        }

        private void AddOtherFee_Callback(object sender, EventArgs e)
        {
            var otherfee = sender as OtherFee;
            List<OtherFee> datasource = dgvOtherFee.DataSource as List<OtherFee>;
            if (datasource == null) datasource = new List<OtherFee>();
            if (!datasource.Contains(otherfee)) datasource.Add(otherfee);
            dgvOtherFee.DataSource = datasource;
            this.dgvOtherFee.Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOtherFee.SelectedRows.Count == 0)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选择一条费用");
                return;
            }
            var datasource = dgvOtherFee.DataSource as List<OtherFee>;
            datasource.Remove(dgvOtherFee.SelectedRows[0].DataBoundItem as OtherFee);
            dgvOtherFee.Reset();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
