using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.Forms
{
    public partial class AddHouse : BaseEditHouse
    {
        public AddHouse()
        {
            InitializeComponent();
            this.Text = "新增房间";
            this.btnSave.ClickCallback += BtnSave_ClickCallback;
            this.btnSave.Click += BtnSave_Click;
        }

        public House House { get; set; }
        public string BuildingID { get; set; }
        public int Floor { get; set; }


        private void BtnSave_Click(object sender, EventArgs e)
        {
            AddHouseRequest request = new AddHouseRequest();
            request.token = this.Token;
            House house = new House
            {
                BuildingID = this.BuildingID,
                Floor = this.Floor,
                HallCount = (int)cmbHall.SelectedValue,
                RoomCount = (int)cmbRoom.SelectedValue,
                ToiletCount = (int)cmbToilet.SelectedValue,
                Remark = txbRemark.Text,
                Name = txbHouseName.Text,
                RentType = chkRentType.Checked ? 1 : 0,
            };
            var response = SDKFactory.Client.Execute(request);
        }

        private void BtnSave_ClickCallback(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
