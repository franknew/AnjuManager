using SOAFramework.Client.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOAFramework.Client.Forms
{
    public partial class ChildForm : BaseForm
    {
        public bool FormClosing { get; set; }

        public ChildForm()
        {
            InitializeComponent();
            this.Padding = new Padding(5, 5, 5, 5);
        }

        protected override void OnClosed(EventArgs e)
        {
            FormClosing = true;
            var parent = this.MdiParent as ContainerForm;
            parent.Watcher.Remove(this.Name);
            base.OnClosed(e);
        }
    }
}
