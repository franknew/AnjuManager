using MetroFramework.Controls;
using SOAFramework.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SOAFramework.Client.Controls
{
    public class ComboBox : MetroComboBox, IServiceBindable, IControlBindable 
    {
        #region service binding property
        private string controlBindingPropertyName = "SelectedValue";

        [Category(ControlCategory.Category)]
        [DefaultValue("SelectedValue")]
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

        #region control bindable
        private string bindingSelfPropertyName = "SelectedValue";

        [Category(ControlCategory.Category)]
        [DefaultValue("SelectedValue")]
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
