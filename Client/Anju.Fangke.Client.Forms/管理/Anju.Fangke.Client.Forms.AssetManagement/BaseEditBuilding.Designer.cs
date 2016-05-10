namespace Anju.Fangke.Client.Forms
{
    partial class BaseEditBuilding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.numFloorCount = new SOAFramework.Client.Controls.NumbericUpDown();
            this.cmbArea = new SOAFramework.Client.Controls.ComboBox();
            this.cmbcity = new SOAFramework.Client.Controls.ComboBox();
            this.cmbProvince = new SOAFramework.Client.Controls.ComboBox();
            this.label7 = new SOAFramework.Client.Controls.Label();
            this.txbRemark = new SOAFramework.Client.Controls.TextBox();
            this.txbStreet = new SOAFramework.Client.Controls.TextBox();
            this.txbName = new SOAFramework.Client.Controls.TextBox();
            this.label6 = new SOAFramework.Client.Controls.Label();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFloorCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numFloorCount);
            this.groupBox1.Controls.Add(this.cmbArea);
            this.groupBox1.Controls.Add(this.cmbcity);
            this.groupBox1.Controls.Add(this.cmbProvince);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbRemark);
            this.groupBox1.Controls.Add(this.txbStreet);
            this.groupBox1.Controls.Add(this.txbName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(1, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // numFloorCount
            // 
            this.numFloorCount.BindingRequestPropertyName = null;
            this.numFloorCount.BindingResponsePropertyName = null;
            this.numFloorCount.BindingSourcePropertyName = "FloorCount";
            this.numFloorCount.EmptyWarning = null;
            this.numFloorCount.Location = new System.Drawing.Point(90, 112);
            this.numFloorCount.Name = "numFloorCount";
            this.numFloorCount.Size = new System.Drawing.Size(156, 21);
            this.numFloorCount.TabIndex = 14;
            // 
            // cmbArea
            // 
            this.cmbArea.BindingRequestPropertyName = null;
            this.cmbArea.BindingResponsePropertyName = null;
            this.cmbArea.BindingSourcePropertyName = "AreaID";
            this.cmbArea.DisplayMember = "Name";
            this.cmbArea.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbArea.FormattingEnabled = true;
            this.cmbArea.InitableBindingGroupName = "深圳市";
            this.cmbArea.ItemHeight = 19;
            this.cmbArea.Location = new System.Drawing.Point(295, 81);
            this.cmbArea.Name = "cmbArea";
            this.cmbArea.Size = new System.Drawing.Size(152, 25);
            this.cmbArea.TabIndex = 13;
            this.cmbArea.UseSelectable = true;
            this.cmbArea.Value = null;
            this.cmbArea.ValueMember = "Value";
            // 
            // cmbcity
            // 
            this.cmbcity.BindingRequestPropertyName = null;
            this.cmbcity.BindingResponsePropertyName = null;
            this.cmbcity.BindingSourcePropertyName = "CityID";
            this.cmbcity.DisplayMember = "Name";
            this.cmbcity.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbcity.FormattingEnabled = true;
            this.cmbcity.InitableBindingGroupName = "广东省";
            this.cmbcity.ItemHeight = 19;
            this.cmbcity.Location = new System.Drawing.Point(90, 81);
            this.cmbcity.Name = "cmbcity";
            this.cmbcity.Size = new System.Drawing.Size(156, 25);
            this.cmbcity.TabIndex = 12;
            this.cmbcity.UseSelectable = true;
            this.cmbcity.Value = null;
            this.cmbcity.ValueMember = "Value";
            // 
            // cmbProvince
            // 
            this.cmbProvince.BindingRequestPropertyName = null;
            this.cmbProvince.BindingResponsePropertyName = null;
            this.cmbProvince.BindingSourcePropertyName = "ProvinceID";
            this.cmbProvince.DisplayMember = "Name";
            this.cmbProvince.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbProvince.FormattingEnabled = true;
            this.cmbProvince.InitableBindingGroupName = "省份";
            this.cmbProvince.ItemHeight = 19;
            this.cmbProvince.Location = new System.Drawing.Point(295, 48);
            this.cmbProvince.Name = "cmbProvince";
            this.cmbProvince.Size = new System.Drawing.Size(152, 25);
            this.cmbProvince.TabIndex = 11;
            this.cmbProvince.UseSelectable = true;
            this.cmbProvince.Value = null;
            this.cmbProvince.ValueMember = "Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "层数";
            // 
            // txbRemark
            // 
            this.txbRemark.BindingRequestPropertyName = null;
            this.txbRemark.BindingResponsePropertyName = null;
            this.txbRemark.BindingSourcePropertyName = "Remark";
            this.txbRemark.EmptyWarning = null;
            this.txbRemark.Lines = new string[0];
            this.txbRemark.Location = new System.Drawing.Point(90, 221);
            this.txbRemark.MaxLength = 32767;
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRemark.SelectedText = "";
            this.txbRemark.SelectionLength = 0;
            this.txbRemark.SelectionStart = 0;
            this.txbRemark.Size = new System.Drawing.Size(357, 84);
            this.txbRemark.TabIndex = 8;
            this.txbRemark.UseSelectable = true;
            // 
            // txbStreet
            // 
            this.txbStreet.BindingRequestPropertyName = null;
            this.txbStreet.BindingResponsePropertyName = null;
            this.txbStreet.BindingSourcePropertyName = "Street";
            this.txbStreet.EmptyWarning = null;
            this.txbStreet.Lines = new string[0];
            this.txbStreet.Location = new System.Drawing.Point(90, 141);
            this.txbStreet.MaxLength = 32767;
            this.txbStreet.Multiline = true;
            this.txbStreet.Name = "txbStreet";
            this.txbStreet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbStreet.SelectedText = "";
            this.txbStreet.SelectionLength = 0;
            this.txbStreet.SelectionStart = 0;
            this.txbStreet.Size = new System.Drawing.Size(357, 74);
            this.txbStreet.TabIndex = 7;
            this.txbStreet.UseSelectable = true;
            // 
            // txbName
            // 
            this.txbName.BindingRequestPropertyName = null;
            this.txbName.BindingResponsePropertyName = null;
            this.txbName.BindingSourcePropertyName = "Name";
            this.txbName.CanbeEmpty = false;
            this.txbName.EmptyWarning = "请输入楼盘名称";
            this.txbName.Lines = new string[0];
            this.txbName.Location = new System.Drawing.Point(90, 48);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbName.SelectedText = "";
            this.txbName.SelectionLength = 0;
            this.txbName.SelectionStart = 0;
            this.txbName.Size = new System.Drawing.Size(156, 23);
            this.txbName.TabIndex = 6;
            this.txbName.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "备注";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "地址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "区域";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "城市";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "省份";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "楼盘名称";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(1, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(295, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "退出";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // BaseEditBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BaseEditBuilding";
            this.Text = "编辑楼盘";
            this.InitControl += new System.EventHandler(this.BaseEditBuilding_InitControl);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFloorCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public SOAFramework.Client.Controls.GroupBox groupBox1;
        public SOAFramework.Client.Controls.GroupBox groupBox2;
        public SOAFramework.Client.Controls.Button btnClose;
        public SOAFramework.Client.Controls.TextBox txbRemark;
        public SOAFramework.Client.Controls.TextBox txbStreet;
        public SOAFramework.Client.Controls.TextBox txbName;
        public SOAFramework.Client.Controls.ComboBox cmbArea;
        public SOAFramework.Client.Controls.ComboBox cmbcity;
        public SOAFramework.Client.Controls.ComboBox cmbProvince;
        public SOAFramework.Client.Controls.Label label6;
        public SOAFramework.Client.Controls.Label label5;
        public SOAFramework.Client.Controls.Label label4;
        public SOAFramework.Client.Controls.Label label3;
        public SOAFramework.Client.Controls.Label label2;
        public SOAFramework.Client.Controls.Label label1;
        public SOAFramework.Client.Controls.Label label7;
        protected SOAFramework.Client.Controls.NumbericUpDown numFloorCount;
    }
}