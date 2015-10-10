using MetroFramework.Controls;
using SOAFramework.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace SOAFramework.Client.Controls
{
    public class TextBox : MetroTextBox, IServiceBindable
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
