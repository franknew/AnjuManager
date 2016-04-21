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

        private void AddHouse_Shown(object sender, EventArgs e)
        {
            this.txbBuildingName.Text = this.Building.Name;
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
            var house = this.CollectData<FullHouse>();
            this.Building.CurrentHouse = house;
            house.House.BuildingID = this.Building.ID;
            request.form = house;
            var response = SDKSync<AddHouseResponse>.CreateInstance(this).Execute(request, AddHouse_Callback);
        }

        private void AddHouse_Callback(AddHouseResponse response)
        {
            this.Building.CurrentHouse.House.ID = response.Result.HouseID;
            //this.Building.CurrentHouse.RentFee.ID = response.Result.RentFeeID;
            Building?.House?.Add(this.Building.CurrentHouse);
            SOAFramework.Client.Controls.MessageBox.Show(this, "新增房间成功");
            this.Close();
        }
    }
}
