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
            DateTime data = Convert.ToDateTime(this.GetValue(controlBindingPropertyName));
            if (!string.IsNullOrEmpty(CollectFormat)) data = Convert.ToDateTime(data.ToString(CollectFormat));
            return data;
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
        [DefaultValue(false)]
        public bool Bindable { get; set; }

        private DataSourceUpdateMode dataSourceUpdateMode = DataSourceUpdateMode.OnValidation;
        [Category(ControlCategory.Category)]
        [DefaultValue(DataSourceUpdateMode.OnValidation)]
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

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string CollectFormat { get; set; }
    }
}
