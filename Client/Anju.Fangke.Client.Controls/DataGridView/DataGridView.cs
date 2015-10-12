using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;
using System.ComponentModel;
using SOAFramework.Library;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace SOAFramework.Client.Controls
{
    public class DataGridView : System.Windows.Forms.DataGridView, IServiceBindable
    {
        #region property

        #endregion

        #region service binding property
        private string controlBindingPropertyName = "DataSource";

        [Category(ControlCategory.Category)]
        [DefaultValue("DataSource")]
        public string BindingControlPropertyName
        {
            get
            {
                return controlBindingPropertyName;
            }

            set
            {
                controlBindingPropertyName = value;
            }
        }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string BindingRequestPropertyName { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string BindingResponsePropertyName { get; set; }

        public object CollectBindingData()
        {
            return this.GetValue(controlBindingPropertyName);
        }
        #endregion

        protected override void OnLayout(LayoutEventArgs e)
        {
            this.AutoGenerateColumns = false;
            this.BackgroundColor = MetroPaint.BackColor.Form(MetroFramework.MetroThemeStyle.Default);
            base.OnLayout(e);
        }
    }
}
