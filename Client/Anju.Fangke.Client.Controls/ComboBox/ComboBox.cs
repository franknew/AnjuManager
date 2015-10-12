using MetroFramework.Controls;
using SOAFramework.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public class ComboBox : MetroComboBox, IServiceBindable
    {
        #region service binding property
        private string controlBindingPropertyName = "Value";

        [Category(ControlCategory.Category)]
        [DefaultValue("Value")]
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
    }
}
