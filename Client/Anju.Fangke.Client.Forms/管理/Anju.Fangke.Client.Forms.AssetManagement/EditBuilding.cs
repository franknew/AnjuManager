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
    public partial class EditBuilding : BaseEditBuilding
    {
        public EditBuilding()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            this.AfterLoaded += EditBuilding_Load;
        }

        private void EditBuilding_Load(object sender, EventArgs e)
        {
        }

        private void BtnSave_ClickCallback(CommonResponse response)
        {
            if (SaveClickCallBack != null)
            {
                SaveClickCallBack.Invoke(Building, null);
                this.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            EditBuildingRequest request = new EditBuildingRequest();
            request.token = this.Token;
            this.CollectData(Building);
            request.form = Building;
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, BtnSave_ClickCallback);
        }

        private void EditBuilding_InitControl(object sender, EventArgs e)
        {
        }
    }
}
