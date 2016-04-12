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
using MetroFramework.Controls;
using SOAFramework.Library.Validator;

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

        private MetroProgressSpinner spinner = new MetroProgressSpinner();
        private List<Control> _allcontrols = new List<Control>();
        private Dictionary<string, bool> _enableDic = null;

        #region property
        private CustomBindingSource binding = new CustomBindingSource();
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CustomBindingSource Binding
        {
            get { return binding; }
            set { binding = value; }
        }

        public string Token { get; set; }

        public bool EnableEscClose { get; set; }

        public ValidatorManager ValidationManager
        {
            get
            {
                return validationManager;
            }

            set
            {
                validationManager = value;
            }
        }

        private ValidatorManager validationManager = new ValidatorManager();
        #endregion

        public event EventHandler AfterLoaded;
        public event EventHandler InitControl;

        public Dictionary<string, object> DataDictionary = new Dictionary<string, object>();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;

            var _allcontrols = this.GetAllControls();

            #region 添加绑定
            var controls = _allcontrols.OfType<IControlBindable>();
            if (this.Binding.DataSource == null)
            {
                DataTable source = new DataTable();
                foreach (var bindable in controls)
                {
                    if (!bindable.Bindable) continue;
                    if (!string.IsNullOrEmpty(bindable.BindingSourcePropertyName))
                    {
                        source.Columns.Add(bindable.BindingSourcePropertyName);
                    }
                }
                this.Binding.DataSource = source;
            }
            foreach (var control in controls)
            {
                if (!control.Bindable) continue;
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
            
            if (AfterLoaded != null) AfterLoaded.Invoke(this, e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            if (EnableEscClose) if (e.KeyCode.Equals(Keys.Escape)) this.Close();
        }

        #region action
        public void ShowSpinner()
        {
            //this.Enabled = false;
            if (_enableDic == null)
            {
                _enableDic = new Dictionary<string, bool>();
                foreach (Control control in this.Controls)
                {
                    _enableDic[control.Name] = control.Enabled;
                    control.Enabled = false;
                }
            }
            if (this.Controls.Contains(spinner)) spinner = this.Controls["spnProgressSpinner"] as MetroProgressSpinner;
            else
            {
                spinner = new MetroProgressSpinner();
                spinner.Name = "spnProgressSpinner";
                spinner.Hide();
                this.Controls.Add(spinner);
            }
            spinner.BringToFront();
            spinner.Size = new System.Drawing.Size(40, 40);
            spinner.Value = 50;
            spinner.Maximum = 100;
            spinner.Location = new Point(this.Width / 2 - spinner.Width / 2, this.Height / 2 - spinner.Height / 2);
            spinner.Show();
        }

        public void HideSpinner()
        {
            if (spinner != null) spinner.Hide();
            if (_enableDic != null)
            {
                //this.Enabled = true;
                foreach (Control control in this.Controls)
                {
                    if (_enableDic.ContainsKey(control.Name)) control.Enabled = _enableDic[control.Name];
                }
                _enableDic = null;
            }
            this.Activate();
        }

        public bool Validate()
        {
            return validationManager.ValidateInForm(this).IsValid;
        }
        #endregion

        #region events
        private void BaseForm_Shown(object sender, EventArgs e)
        {
            if (DesignMode) return;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            this.ShowSpinner();
            _allcontrols = this.GetAllControls();
            worker.RunWorkerAsync(_allcontrols);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var initablebindings = _allcontrols.OfType<IInitableBinding>();
            if (e.Result == null)
            {
                this.HideSpinner();
                if (InitControl != null) InitControl.Invoke(this, e);
                return;
            }
            dynamic dyresponse = e.Result;
            if (dyresponse.IsError)
            {
                this.HideSpinner();
                Client.Controls.MessageBox.Show(this, dyresponse.ErrorMessage);
                if (InitControl != null) InitControl.Invoke(this, e);
                return;
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
                        Type itemType = result.Items.GetType();
                        if (itemType == null)
                        {
                            this.HideSpinner();
                            return;
                        }
                        Type modelType = itemType.GetGenericArguments()[0];
                        if (modelType == null)
                        {
                            this.HideSpinner();
                            return;
                        }
                        dynamic datadictionary = Activator.CreateInstance(modelType);
                        datadictionary.Name = "全部";
                        datadictionary.Value = -1;
                        result.Items.Insert(0, datadictionary);
                    }
                    property.SetValue(c, result.Items, null);
                }
                DataDictionary[binding.InitableBindingGroupName] = result.Items;
            }
            this.HideSpinner();
            if (InitControl != null) InitControl.Invoke(this, e);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            #region 绑定数据字典
            _allcontrols = e.Argument as List<Control>;
            var initablebindings = _allcontrols.OfType<IInitableBinding>();
            List<string> groups = new List<string>();
            foreach (var binding in initablebindings)
            {
                if (!string.IsNullOrEmpty(binding.InitableBindingGroupName)) groups.Add(binding.InitableBindingGroupName);
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
            e.Result = Response;
            
            #endregion
        }
        #endregion
    }

    public class WorkResult
    {
        public object Response { get; set; }

        public List<Control> Controls { get; set; }
    }
}
