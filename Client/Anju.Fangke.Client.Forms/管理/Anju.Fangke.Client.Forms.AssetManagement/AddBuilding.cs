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
    public partial class AddBuilding : BaseEditBuilding
    {
        public AddBuilding()
        {
            InitializeComponent();
            btnSave.Click += btnSave_Click;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AddBuildingRequest request = new AddBuildingRequest();
            Building = this.CollectData<FullBuilding>();
            request.form = Building;
            request.token = this.Token;
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
