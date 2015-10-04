using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public class TextBox : MetroTextBox
    {
        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.UseStyleColors = true;
            this.Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            this.UseStyleColors = false;
            this.Invalidate();
            base.OnLeave(e);
        }
    }
}
