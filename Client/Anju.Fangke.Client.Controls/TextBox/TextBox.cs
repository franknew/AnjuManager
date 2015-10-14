using MetroFramework.Controls;
using SOAFramework.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SOAFramework.Client.Controls
{
    public class TextBox : MetroTextBox, IServiceBindable, IControlBindable
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
        [DefaultValue("")]
        public string BindingResponsePropertyName { get; set; }

        public object CollectBindingData()
        {
            string value = this.GetValue<string>(controlBindingPropertyName);
            if (string.IsNullOrEmpty(value))
            {
                value = null;
            }
            return value;
        }
        #endregion

        #region control bindable
        private string bindingSelfPropertyName = "Text";

        [Category(ControlCategory.Category)]
        [DefaultValue("Text")]
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

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.UseStyleColors = true;
            this.Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            this.UseStyleColors = false;
            this.Invalidate();
            base.OnLeave(e);
        }
    }
}
