using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SOAFramework.Client.Forms;

namespace Anju.Fangke.Client.Main
{
    public partial class Startup : ContainerForm
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog(this);
        }
    }
}
