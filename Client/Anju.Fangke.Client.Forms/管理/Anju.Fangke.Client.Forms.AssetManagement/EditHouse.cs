using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;

namespace Anju.Fangke.Client.Forms
{
    public partial class EditHouse : BaseEditHouse
    {
        public EditHouse()
        {
            InitializeComponent();
            this.Shown += EditHouse_Shown;
        }

        private void EditHouse_Shown(object sender, EventArgs e)
        {
            this.txbBuildingName.Text = this.Building.Name;
            this.txbFloor.Text = this.Floor.ToString();
            this.txbHouseName.Text = this.Building.CurrentHouse.Name;
            this.txbRemark.Text = this.Building.CurrentHouse.Remark;
            this.cmbHall.SelectedItem = this.Building.CurrentHouse.HallCount;
            this.cmbRoom.SelectedItem = this.Building.CurrentHouse.RoomCount;
            this.cmbToilet.SelectedItem = this.Building.CurrentHouse.ToiletCount;
            if (this.Building.CurrentHouse.RentType == 1) rabZhengZu.Checked = true;
            else rabHezu.Checked = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void UpdateCallBack(CommonResponse response)
        {
            SOAFramework.Client.Controls.MessageBox.Show(this, "更新房间成功");
            this.Close();
        }
    }
}
