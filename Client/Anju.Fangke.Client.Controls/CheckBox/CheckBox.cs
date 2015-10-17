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
    public class CheckBox : MetroCheckBox, IServiceBindable, IControlBindable
    {
        #region service binding property
        private string controlBindingPropertyName = "BindingChecked";

        [Category(ControlCategory.Category)]
        [DefaultValue("BindingChecked")]
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
            return value;
        }
        #endregion

        #region control bindable
        private string bindingSelfPropertyName = "Checked";

        [Category(ControlCategory.Category)]
        [DefaultValue("Checked")]
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
        /// <summary>
        /// 用来绑定整形的Checked属性
        /// </summary>
        [Browsable(false)]
        public int BindingChecked
        {
            set
            {
                this.Checked = (value != 0);
            }
            get
            {
                if (this.Checked)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
        #endregion
    }
}
