using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;
using System.ComponentModel;

namespace SOAFramework.Client.Controls
{
    public class DataGridView : MetroGrid, IServiceBindable
    {
        #region service binding property
        private string controlBindingPropertyName = "DataSource";

        [Category(ControlCategory.Category)]
        [DefaultValue("DataSource")]
        public string ControlBindingPropertyName
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
        public string ServiceBindingPropertyName { get; set; }

        public object CollectBindingData()
        {
            return this.GetValue(controlBindingPropertyName);
        }
        #endregion
    }
}
