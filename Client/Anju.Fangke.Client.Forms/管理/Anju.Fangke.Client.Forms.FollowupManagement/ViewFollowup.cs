using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SOAFramework.Client.Forms;

namespace Anju.Fangke.Client.Forms
{
    public partial class ViewFollowup : PopupForm
    {
        public ViewFollowup()
        {
            InitializeComponent();
        }

        public string Remark
        {
            get { return txbDetail.Text; }
            set { txbDetail.Text = value; }
        }
    }
}
