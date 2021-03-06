﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using SOAFramework.Library;

namespace SOAFramework.Client.Controls
{
    public class RadioButton : MetroRadioButton, IServiceBindable, IControlBindable, IGroupControl
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
        [DefaultValue(false)]
        public bool Bindable { get; set; }

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

        #region group control
        [Category(ControlCategory.Category)]
        public string Group { get; set; }

        [Category(ControlCategory.Category)]
        [DefaultValue(null)]
        public string Value { get; set; }
        #endregion
    }
}
