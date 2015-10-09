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
                StringBuilder emtpy = new StringBuilder();
                foreach (var c in base.Text)
                {
                    emtpy.Append("  ");
                }

                return emtpy.AppendFormat("{0}{1}", base.Text, emtpy.ToString()).ToString();
            }

            set
            {
                base.Text = value;
            }
        }
    }
}
