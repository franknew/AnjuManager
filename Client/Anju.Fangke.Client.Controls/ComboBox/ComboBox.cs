using MetroFramework.Controls;
using SOAFramework.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace SOAFramework.Client.Controls
{
    public class ComboBox : MetroComboBox, IServiceBindable, IControlBindable, IInitableBinding
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
        [DefaultValue(false)]
        public bool Bindable { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string BindingResponsePropertyName { get; set; }

        public object CollectBindingData()
        {
            var value = this.GetValue(controlBindingPropertyName);
            if (value != null && value.ToString().Trim() == emptyValue) value = null;
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

        #region initable binding
        [Category(ControlCategory.Category)]
        [DefaultValue("")]
        public string InitableBindingGroupName
        {
            get; set;
        }

        private string initableBindingControlPropertyName = "DataSource";
        [Category(ControlCategory.Category)]
        [DefaultValue("DataSource")]
        public string InitableBindingControlPropertyName
        {
            get
            {
                return initableBindingControlPropertyName;
            }

            set
            {
                initableBindingControlPropertyName = value;
            }
        }

        [Category(ControlCategory.Category)]
        [DefaultValue(false)]
        public bool HasAll { get; set; }
        #endregion

        #region property
        private string emptyValue = "-1";

        [Category(ControlCategory.Category)]
        [DefaultValue("-1")]
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


        public object Value
        {
            get { return this.SelectedValue; }
            set
            {
                if (value == null)
                {
                    this.SelectedIndex = -1;
                    return;
                }
                foreach (var item in this.Items)
                {
                    object objValue = item.TryGetValue(this.ValueMember);
                    if (value.Equals(objValue.ChangeTypeTo(value.GetType())))
                    {
                        this.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        #endregion
    }
}
