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
    public class TextBox : MetroTextBox, IServiceBindable, IControlBindable, IControlEmptable
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

        #region common property
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

        /// <summary>
        /// 文本输入类型
        /// </summary>
        [Category(ControlCategory.Category)]
        [DefaultValue(InputType.文本)]
        public InputType InputType
        {
            get
            {
                return inputType;
            }

            set
            {
                inputType = value;
            }
        }
        private InputType inputType = InputType.文本;
        #endregion

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            this.UseStyleColors = true;
            this.UseWarnStyle = false;
            this.Invalidate();
        }

        protected override void OnLeave(EventArgs e)
        {
            this.UseStyleColors = false;
            this.Invalidate();
            base.OnLeave(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (inputType)
            {
                case InputType.整数:
                    if ((e.KeyChar > 57 || e.KeyChar < 48) && e.KeyChar != 8) e.Handled = true;
                    break;
                case InputType.小数:
                    if (((e.KeyChar <= 57 && e.KeyChar >= 48) || e.KeyChar == 46 || e.KeyChar == 45) && e.KeyChar != 8)
                    {
                        if (e.KeyChar == 46 && (this.Text.Contains(".") || this.SelectionStart == 0)) e.Handled = true;
                        else if (e.KeyChar == 45 && (this.Text.Contains("-") || this.SelectionStart > 0)) e.Handled = true;
                    }
                    break;
                default:
                    break;
            }
            base.OnKeyPress(e);
        }
    }
}
