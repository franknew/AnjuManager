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
    public partial class EditBuilding : BaseEditBuilding
    {
        public EditBuilding()
        {
            InitializeComponent();
            btnSave.EnableSyncClick = true;
            btnSave.Click += BtnSave_Click;
            btnSave.ClickCallback += BtnSave_ClickCallback;
            this.AfterLoaded += EditBuilding_Load;
        }

        private CommonResponse _response = null;

        private void EditBuilding_Load(object sender, EventArgs e)
        {
            txbFloor.Text = Building.FloorCount.ToString();
            txbName.Text = Building.Name;
            txbRemark.Text = Building.Name;
            txbStreet.Text = Building.Street;
            cmbArea.Value = Building.AreaID;
            cmbcity.Value = Building.CityID;
            cmbProvince.Value = Building.ProvinceID;
        }

        private void BtnSave_ClickCallback(object sender, EventArgs e)
        {
            if (_response == null) return;
            if (_response.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, _response.ResponseBody);
                return;
            }
            if (this.SaveClickCallBack != null)
            {
                this.SaveClickCallBack.Invoke(this, e);
                this.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            EditBuildingRequest request = new EditBuildingRequest();
            request.token = this.Token;
            Building building = new Building
            {
                AreaID = cmbArea.SelectedValue.ToString() == "-1" ? null : cmbArea.SelectedValue.ToString(),
                CityID = cmbcity.SelectedValue.ToString() == "-1" ? null : cmbcity.SelectedValue.ToString(),
                FloorCount = Convert.ToInt16(txbFloor.Text),
                Name = txbName.Text,
                ProvinceID = cmbProvince.SelectedValue.ToString() == "-1" ? null : cmbProvince.SelectedValue.ToString(),
                Remark = txbRemark.Text,
                Street = txbStreet.Text,
                ID = Building.ID,
            };
            Building = building;
            request.form = building;
            _response = SDKFactory.Client.Execute(request);
        }
    }
}
