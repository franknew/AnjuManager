using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SOAFramework.Library;

namespace SOAFramework.Client.Controls
{
    public class NumbericUpDown : System.Windows.Forms.NumericUpDown, IServiceBindable, IControlBindable, IControlEmptable
    {
        #region service binding property
        private string controlBindingPropertyName = "Text";

        [Category(ControlCategory.Category)]
        [DefaultValue("Text")]
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
            string value = this.GetValue<string>(controlBindingPropertyName);
            if (string.IsNullOrEmpty(value) && emptyToNull)
            {
                value = null;
            }
            return value;
        }

        private bool emptyToNull = false;

        /// <summary>
        /// 空值是否读出为null
        /// </summary>
        [Category(ControlCategory.Category)]
        [DefaultValue(false)]
        public bool EmptyToNull
        {
            get
            {
                return emptyToNull;
            }

            set
            {
                emptyToNull = value;
            }
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

        #region emptable property
        private bool useWarnStyle = false;
        [DefaultValue(false)]
        public bool UseWarnStyle
        {
            get { return useWarnStyle; }
            set
            {
                useWarnStyle = value;
                this.Invalidate();
            }
        }

        private bool canbeEmpty = true;
        /// <summary>
        /// 文本框是否可空
        /// </summary>
        [Category(ControlCategory.Category)]
        [DefaultValue(true)]
        public bool CanbeEmpty
        {
            get
            {
                return canbeEmpty;
            }

            set
            {
                canbeEmpty = value;
            }
        }

        [Category(ControlCategory.Category)]
        [DefaultValue(true)]
        public string EmptyWarning { get; set; }
        #endregion
    }
}
