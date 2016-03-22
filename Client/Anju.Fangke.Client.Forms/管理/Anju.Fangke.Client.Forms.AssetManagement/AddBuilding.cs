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
using SOAFramework.Service.SDK.Core;

namespace Anju.Fangke.Client.Forms
{
    public partial class AddBuilding : BaseEditBuilding
    {
        public AddBuilding()
        {
            InitializeComponent();
            btnSave.EnableSyncClick = true;
            btnSave.Click += btnSave_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddBuildingRequest request = new AddBuildingRequest();
            request.token = this.Token;
            FullBuilding building = new FullBuilding();
            building.FloorCount = Convert.ToInt16(txbFloor.Text);
            building.AreaID = cmbArea.SelectedValue.ToString() == "-1" ? null : cmbArea.SelectedValue.ToString();
            building.ProvinceID = cmbProvince.SelectedValue.ToString() == "-1" ? null : cmbProvince.SelectedValue.ToString();
            building.CityID = cmbcity.SelectedValue.ToString() == "-1" ? null : cmbcity.SelectedValue.ToString();
            building.Remark = txbRemark.Text;
            building.Street = txbStreet.Text;
            building.Name = txbName.Text;
            Building = building;
            request.form = building;
            Building = building;
            SDKSync<AddModelResponse>.CreateInstance(this).Execute(request, btnSave_Callback);
        }

        private void btnSave_Callback(AddModelResponse response)
        {
            if (SaveClickCallBack != null)
            {
                Building.ID = response.ID;
                SaveClickCallBack.Invoke(Building, null);
                this.Close();
            }
        }
    }
}
