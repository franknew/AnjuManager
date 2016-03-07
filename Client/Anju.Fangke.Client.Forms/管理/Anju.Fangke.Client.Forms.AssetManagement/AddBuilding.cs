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
    public partial class AddBuilding : BaseEditBuilding
    {
        private AddModelResponse _response = null;

        public AddBuilding()
        {
            InitializeComponent();
            btnSave.EnableSyncClick = true;
            btnSave.Click += btnSave_Click;
            btnSave.ClickCallback += btnSave_Callback;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddBuildingRequest request = new AddBuildingRequest();
            request.token = this.Token;
            Building building = new Building();
            building.FloorCount = Convert.ToInt16(txbFloor.Text);
            building.AreaID = cmbArea.SelectedValue.ToString() == "-1" ? null : cmbArea.SelectedValue.ToString();
            building.ProvinceID = cmbProvince.SelectedValue.ToString() == "-1" ? null : cmbProvince.SelectedValue.ToString();
            building.CityID = cmbcity.SelectedValue.ToString() == "-1" ? null : cmbcity.SelectedValue.ToString();
            building.Remark = txbRemark.Text;
            building.Street = txbStreet.Text;
            building.Name = txbName.Text;
            Building = building;
            request.form = building;
            _response = SDKFactory.Client.Execute(request);
        }

        private void btnSave_Callback(object sender, EventArgs e)
        {
            if (_response != null)
            {
                if (_response.IsError)
                {
                    SOAFramework.Client.Controls.MessageBox.Show(this, _response.ResponseBody);
                    return;
                }
                if (SaveClickCallBack != null)
                {
                    SaveClickCallBack.Invoke(this, e);
                    this.Close();
                }
            }
        }
    }
}
