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

namespace Anju.Fangke.Client.Forms
{
    public partial class BaseTakeHouse : PopupForm
    {
        public BaseTakeHouse()
        {
            InitializeComponent();
        }

        public House House { get; set; }

        private void BaseTakeHouse_InitControl(object sender, EventArgs e)
        {
            if (House != null) this.SetForm(House);
        }
    }
}
