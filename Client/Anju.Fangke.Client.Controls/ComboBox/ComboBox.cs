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
            var value = this.GetValue(controlBindingPropertyName);
            if (value.ToString().Trim() == emptyValue)
            {
                value = null;
            }
            return value;
        }
        #endregion

        #region property
        [Category(ControlCategory.Category)]
        [DefaultValue("-1")]
        private string emptyValue = "-1";

        public string EmptyValue
        {
            get
            {
                return emptyValue;
            }

            set
            {
                emptyValue = value;
            }
        }
        #endregion
    }
}
