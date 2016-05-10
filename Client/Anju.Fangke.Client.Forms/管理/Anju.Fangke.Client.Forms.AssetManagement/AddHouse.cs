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
    public partial class AddHouse : BaseEditHouse
    {
        public AddHouse()
        {
            InitializeComponent();
            this.Text = "新增房间";
            this.btnSave.Click += BtnSave_Click;
            this.Shown += AddHouse_Shown;
        }

        public event EventHandler Add_Callback;

        private void AddHouse_Shown(object sender, EventArgs e)
        {
            this.txbFloor.Text = this.Floor.ToString();
        }
        
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validate())
            {
                this.btnSave.IngoreCallbackOnce = true;
                return;
            }
            AddHouseRequest request = new AddHouseRequest();
            request.token = this.Token;
            House = this.CollectData<FullHouse>();
            request.form = House;
            var response = SDKSync<AddHouseResponse>.CreateInstance(this).Execute(request, AddHouse_Callback);
        }

        private void AddHouse_Callback(AddHouseResponse response)
        {
            House.House.ID = response.Result.HouseID;
            House.Building = cmbBuilding.SelectedItem as Building;
            //this.Building.CurrentHouse.RentFee.ID = response.Result.RentFeeID;
            if (Add_Callback != null) Add_Callback.Invoke(House, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "新增房间成功");
            this.Close();
        }
    }
}
