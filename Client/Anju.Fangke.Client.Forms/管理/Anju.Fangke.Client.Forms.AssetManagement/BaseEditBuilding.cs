﻿using SOAFramework.Client.Forms;
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

namespace Anju.Fangke.Client.Forms
{
    public partial class BaseEditBuilding : PopupForm
    {
        public BaseEditBuilding()
        {
            InitializeComponent();
        }

        public FullBuilding Building { get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        public EventHandler SaveClickCallBack { get; set; }
    }
}
