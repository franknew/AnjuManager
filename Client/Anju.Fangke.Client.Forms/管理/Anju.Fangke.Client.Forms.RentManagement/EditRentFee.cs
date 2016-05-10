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
    public partial class EditRentFee : BaseEditRentFee
    {
        public EditRentFee()
        {
            InitializeComponent();
        }

        public event EventHandler Update_Callback;

        private void btnSave_Click(object sender, EventArgs e)
        {
            var house = FullHouse.Clone();
            UpdateRentFeeRequest request = new UpdateRentFeeRequest();
            this.CollectData(house);
            request.form = house;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Save_Callback);
        }

        private void Save_Callback(CommonResponse response)
        {
            this.CollectData(FullHouse);
            if (Update_Callback != null) Update_Callback.Invoke(FullHouse, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "保存成功");
            this.Close();
        }
    }
}
