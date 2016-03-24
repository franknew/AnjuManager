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
            AddHouseRequest request = new AddHouseRequest();
            request.token = this.Token;
            House house = new House
            {
                BuildingID = this.Building.ID,
                Floor = this.Floor,
                HallCount = Convert.ToInt32(cmbHall.SelectedItem),
                RoomCount = Convert.ToInt32(cmbRoom.SelectedItem),
                ToiletCount = Convert.ToInt32(cmbToilet.SelectedItem),
                Remark = txbRemark.Text,
                Name = txbHouseName.Text,
                RentType = rabZhengZu.Checked ? 1 : 0,
            };
            this.Building.CurrentHouse = house;
            request.form = house;
            var response = SDKSync<AddModelResponse>.CreateInstance(this).Execute(request, AddHouse_Callback);
        }

        private void AddHouse_Callback(AddModelResponse response)
        {
            this.Building.CurrentHouse.ID = response.ID;
            Building?.House?.Add(this.Building.CurrentHouse);
            SOAFramework.Client.Controls.MessageBox.Show(this, "新增房间成功");
            this.Close();
        }
    }
}
