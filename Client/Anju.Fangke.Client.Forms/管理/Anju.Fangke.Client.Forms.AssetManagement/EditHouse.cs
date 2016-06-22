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
using SOAFramework.Library;

namespace Anju.Fangke.Client.Forms
{
    public partial class EditHouse : BaseEditHouse
    {
        public EditHouse()
        {
            InitializeComponent();
        }

        public event EventHandler Update_Callback;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.Validate())
            {
                this.btnSave.IngoreCallbackOnce = true;
                return;
            }
            var house = this.CollectData<FullHouse>(House.Clone<FullHouse>());
            EditHouseRequest request = new EditHouseRequest();
            request.token = this.Token;
            request.form = house;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, UpdateCallBack);
        }

        private void UpdateCallBack(CommonResponse response)
        {
            this.CollectData<FullHouse>(House);
            //this.Building.CurrentHouse.House.IsRented = this.Building.CurrentHouse
            House.Building = (cmbBuilding.SelectedItem as Building).Clone<Building>();
            if (Update_Callback != null) Update_Callback.Invoke(House, null);
            SOAFramework.Client.Controls.MessageBox.Show(this, "更新成功");
            this.Close();
        }

        private void EditHouse_InitControl(object sender, EventArgs e)
        {
        }
    }
}
