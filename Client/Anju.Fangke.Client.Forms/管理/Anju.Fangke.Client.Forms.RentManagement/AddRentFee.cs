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
using SOAFramework.Library;

namespace Anju.Fangke.Client.Forms
{
    public partial class AddRentFee : BaseEditRentFee
    {
        public AddRentFee()
        {
            InitializeComponent();
        }

        public event EventHandler Add_Callback;

        private void btnSave_Click(object sender, EventArgs e)
        {
            var house = FullHouse.Clone();
            AddRentFeeRequest request = new AddRentFeeRequest();
            this.CollectData(house);
            request.form = house;
            SDKSync<AddModelResponse>.CreateInstance(this).Execute(request, Save_Callback);
        }

        private void Save_Callback(AddModelResponse response)
        {
            this.CollectData(FullHouse);
            if (Add_Callback != null) Add_Callback.Invoke(FullHouse, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "保存成功");
            Close();
        }
    }
}
