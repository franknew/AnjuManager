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
using SOAFramework.Client.Forms;

namespace Anju.Fangke.Client.Forms
{
    public partial class BaseEditHouse : PopupForm
    {
        public BaseEditHouse()
        {
            InitializeComponent();
        }
        public FullBuilding Building { get; set; }
        public int Floor { get; set; }
        public SOAFramework.Client.Controls.DataGridView Grid { get; set; }

        private void BaseEditHouse_Load(object sender, EventArgs e)
        {
            cmbHall.SelectedIndex = 0;
            cmbRoom.SelectedIndex = 0;
            cmbToilet.SelectedIndex = 0;
        }
    }
}
