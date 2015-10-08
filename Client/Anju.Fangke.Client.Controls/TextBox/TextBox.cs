using MetroFramework.Controls;
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
        public string ControlBindingPropertyName
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
        public string ServiceBindingPropertyName { get; set; }

        public object CollectBindingData()
        {
            string value = this.GetValue<string>(controlBindingPropertyName);
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
