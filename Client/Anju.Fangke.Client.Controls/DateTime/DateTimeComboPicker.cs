using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MetroFramework.Controls;
using System.ComponentModel;
using SOAFramework.Library;
using System.Windows.Forms;

namespace SOAFramework.Client.Controls
{
    public class DateTimeComboPicker : MetroDateTime, IServiceBindable, IControlBindable
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

        #region control bindable
        private string bindingSelfPropertyName = "Value";

        [Category(ControlCategory.Category)]
        [DefaultValue("Value")]
        public string BindingSelfPropertyName
        {
            get
            {
                return bindingSelfPropertyName;
            }

            set
            {
                bindingSelfPropertyName = value;
            }
        }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string BindingSourcePropertyName { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue(DataSourceUpdateMode.OnValidation)]
        private DataSourceUpdateMode dataSourceUpdateMode = DataSourceUpdateMode.OnValidation;
        public DataSourceUpdateMode DataSourceUpdateMode
        {
            get
            {
                return dataSourceUpdateMode;
            }

            set
            {
                dataSourceUpdateMode = value;
            }
        }

        [Category(ControlCategory.Category)]
        [DefaultValue(null)]
        public object DBNullValue { get; set; }
        #endregion
    }
}
