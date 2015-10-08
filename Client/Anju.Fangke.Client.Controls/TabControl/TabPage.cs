using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public class TabPage : MetroTabPage
    {
        public override string Text
        {
            get
            {
                return base.Text + "  ";
            }

            set
            {
                base.Text = value;
            }
        }
    }
}
