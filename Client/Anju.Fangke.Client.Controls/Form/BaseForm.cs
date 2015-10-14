using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using SOAFramework.Client.Controls;

namespace SOAFramework.Client.Forms
{
    public partial class BaseForm : MetroForm
    {
        public BaseForm()
        {
            InitializeComponent();
            this.BorderStyle = MetroFormBorderStyle.FixedSingle;
            this.ShadowType = MetroFormShadowType.AeroShadow;
        }

        private BindingSource binding = new BindingSource();
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public BindingSource Binding
        {
            get { return binding; }
            set { binding = value; }
        }

        protected override void OnLoad(EventArgs e)
        {
            //添加绑定
            var controls = this.GetAllControls().OfType<IControlBindable>();
            if (this.Binding.DataSource == null)
            {
                DataTable source = new DataTable();
                foreach (var bindable in controls)
                {
                    if (!string.IsNullOrEmpty(bindable.BindingSourcePropertyName))
                    {
                        source.Columns.Add(bindable.BindingSourcePropertyName);
                    }
                }
                this.Binding.DataSource = source;
            }
            foreach (var control in controls)
            {
                IBindableComponent component = control as IBindableComponent;
                if (!string.IsNullOrEmpty(control.BindingSelfPropertyName) && !string.IsNullOrEmpty(control.BindingSourcePropertyName))
                {
                    Binding binding = new Binding(control.BindingSelfPropertyName, Binding, control.BindingSourcePropertyName, false, control.DataSourceUpdateMode);
                    binding.DataSourceNullValue = control.DBNullValue;
                    binding.NullValue = control.DBNullValue;
                    component.DataBindings.Add(binding);
                }
            }

            base.OnLoad(e);
        }
    }
}
