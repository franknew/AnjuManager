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
using System.Dynamic;
using System.Reflection;
using SOAFramework.Service.SDK.Core;

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

        private CustomBindingSource binding = new CustomBindingSource();
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CustomBindingSource Binding
        {
            get { return binding; }
            set { binding = value; }
        }

        public string Token { get; set; }

        public event EventHandler AfterLoaded;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var allcontrols = this.GetAllControls();

            #region 添加绑定
            var controls = allcontrols.OfType<IControlBindable>();
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
                    CustomBinding binding = new CustomBinding(control.BindingSelfPropertyName, Binding, control.BindingSourcePropertyName, true, control.DataSourceUpdateMode);
                    binding.DataSourceNullValue = control.DBNullValue;
                    binding.NullValue = control.DBNullValue;
                    component.DataBindings.Add(binding);
                }
            }
            #endregion

            #region 绑定数据字典
            var initablebindings = allcontrols.OfType<IInitableBinding>();
            List<string> groups = new List<string>();
            foreach (var binding in initablebindings)
            {
                if (!string.IsNullOrEmpty(binding.InitableBindingGroupName))
                {
                    groups.Add(binding.InitableBindingGroupName);
                }
            }
            if (groups.Count == 0) return;
            var sdk = Assembly.Load("Anju.Fangke.Client.SDK");
            if (sdk == null) return;
            var types = sdk.GetTypes();
            var requestType = types.FirstOrDefault(t => t.Name == "QueryDataDictionaryByNameRequest");
            if (requestType == null) return;
            dynamic request = Activator.CreateInstance(requestType);
            request.NameList = groups;
            request.token = this.Token;
            var responseType = requestType.BaseType.GetGenericArguments()[0];

            object Response = SDKFactory.Client.Execute(request, responseType);
            dynamic dyresponse = Response;
            if (dyresponse.IsError)
            {
                Client.Controls.MessageBox.Show(this, dyresponse.ErrorMessage);
            }
            foreach (dynamic result in dyresponse.Result)
            {
                var binding = initablebindings.FirstOrDefault(t => t.InitableBindingGroupName == result.Group.Name);
                Control c = binding as Control;
                PropertyInfo property = c.GetType().GetProperty(binding.InitableBindingControlPropertyName);
                if (property != null)
                {
                    if (binding.HasAll)
                    {
                        var modeldll = Assembly.Load("Anju.Fangke.Server.Model");
                        if (modeldll == null) return;
                        var modelType = modeldll.GetType("DataDictionary");
                        if (modelType == null) return;
                        dynamic datadictionary = Activator.CreateInstance(modelType);
                        datadictionary.Name = "全部";
                        datadictionary.Value = -1;
                        result.Items.Insert(0, datadictionary);
                    }
                    property.SetValue(c, result.Items, null);
                }
            }
            #endregion

            if (AfterLoaded != null)
            {
                AfterLoaded.Invoke(this, e);
            }
        }
    }
}
