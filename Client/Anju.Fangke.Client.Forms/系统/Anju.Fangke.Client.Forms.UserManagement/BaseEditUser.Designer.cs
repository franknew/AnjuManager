namespace Anju.Fangke.Client.Forms
{
    partial class BaseEditUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbRemark = new SOAFramework.Client.Controls.TextBox();
            this.txbAddress = new SOAFramework.Client.Controls.TextBox();
            this.txbIdentity = new SOAFramework.Client.Controls.TextBox();
            this.txbWX = new SOAFramework.Client.Controls.TextBox();
            this.txbQQ = new SOAFramework.Client.Controls.TextBox();
            this.txbMobile = new SOAFramework.Client.Controls.TextBox();
            this.txbCnName = new SOAFramework.Client.Controls.TextBox();
            this.label9 = new SOAFramework.Client.Controls.Label();
            this.label8 = new SOAFramework.Client.Controls.Label();
            this.label7 = new SOAFramework.Client.Controls.Label();
            this.label6 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbID = new SOAFramework.Client.Controls.TextBox();
            this.chkEnabled = new SOAFramework.Client.Controls.CheckBox();
            this.txbUserName = new SOAFramework.Client.Controls.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(1, 383);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 47);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbRemark);
            this.groupBox2.Controls.Add(this.txbAddress);
            this.groupBox2.Controls.Add(this.txbIdentity);
            this.groupBox2.Controls.Add(this.txbWX);
            this.groupBox2.Controls.Add(this.txbQQ);
            this.groupBox2.Controls.Add(this.txbMobile);
            this.groupBox2.Controls.Add(this.txbCnName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(1, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 292);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "详细信息";
            // 
            // txbRemark
            // 
            this.txbRemark.BindingRequestPropertyName = "Form.Remark";
            this.txbRemark.BindingResponsePropertyName = null;
            this.txbRemark.BindingSourcePropertyName = "Remark";
            this.txbRemark.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            this.txbRemark.EmptyWarning = null;
            this.txbRemark.Lines = new string[0];
            this.txbRemark.Location = new System.Drawing.Point(78, 220);
            this.txbRemark.MaxLength = 32767;
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRemark.SelectedText = "";
            this.txbRemark.SelectionLength = 0;
            this.txbRemark.Size = new System.Drawing.Size(452, 55);
            this.txbRemark.TabIndex = 8;
            this.txbRemark.UseSelectable = true;
            // 
            // txbAddress
            // 
            this.txbAddress.BindingRequestPropertyName = "Form.Address";
            this.txbAddress.BindingResponsePropertyName = null;
            this.txbAddress.BindingSourcePropertyName = "Address";
            this.txbAddress.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            this.txbAddress.EmptyWarning = null;
            this.txbAddress.Lines = new string[0];
            this.txbAddress.Location = new System.Drawing.Point(78, 166);
            this.txbAddress.MaxLength = 32767;
            this.txbAddress.Multiline = true;
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbAddress.SelectedText = "";
            this.txbAddress.SelectionLength = 0;
            this.txbAddress.Size = new System.Drawing.Size(452, 48);
            this.txbAddress.TabIndex = 7;
            this.txbAddress.UseSelectable = true;
            // 
            // txbIdentity
            // 
            this.txbIdentity.BindingRequestPropertyName = "Form.Identity";
            this.txbIdentity.BindingResponsePropertyName = null;
            this.txbIdentity.BindingSourcePropertyName = "Identity";
            this.txbIdentity.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            this.txbIdentity.EmptyWarning = null;
            this.txbIdentity.Lines = new string[0];
            this.txbIdentity.Location = new System.Drawing.Point(78, 126);
            this.txbIdentity.MaxLength = 32767;
            this.txbIdentity.Name = "txbIdentity";
            this.txbIdentity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdentity.SelectedText = "";
            this.txbIdentity.SelectionLength = 0;
            this.txbIdentity.Size = new System.Drawing.Size(452, 23);
            this.txbIdentity.TabIndex = 6;
            this.txbIdentity.UseSelectable = true;
            // 
            // txbWX
            // 
            this.txbWX.BindingRequestPropertyName = "Form.WX";
            this.txbWX.BindingResponsePropertyName = null;
            this.txbWX.BindingSourcePropertyName = "WX";
            this.txbWX.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            this.txbWX.EmptyWarning = null;
            this.txbWX.Lines = new string[0];
            this.txbWX.Location = new System.Drawing.Point(357, 78);
            this.txbWX.MaxLength = 32767;
            this.txbWX.Name = "txbWX";
            this.txbWX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbWX.SelectedText = "";
            this.txbWX.SelectionLength = 0;
            this.txbWX.Size = new System.Drawing.Size(173, 23);
            this.txbWX.TabIndex = 5;
            this.txbWX.UseSelectable = true;
            // 
            // txbQQ
            // 
            this.txbQQ.BindingRequestPropertyName = "Form.QQ";
            this.txbQQ.BindingResponsePropertyName = null;
            this.txbQQ.BindingSourcePropertyName = "QQ";
            this.txbQQ.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            this.txbQQ.EmptyWarning = null;
            this.txbQQ.Lines = new string[0];
            this.txbQQ.Location = new System.Drawing.Point(78, 78);
            this.txbQQ.MaxLength = 32767;
            this.txbQQ.Name = "txbQQ";
            this.txbQQ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbQQ.SelectedText = "";
            this.txbQQ.SelectionLength = 0;
            this.txbQQ.Size = new System.Drawing.Size(173, 23);
            this.txbQQ.TabIndex = 4;
            this.txbQQ.UseSelectable = true;
            // 
            // txbMobile
            // 
            this.txbMobile.BindingRequestPropertyName = "Form.Mobile";
            this.txbMobile.BindingResponsePropertyName = null;
            this.txbMobile.BindingSourcePropertyName = "Mobile";
            this.txbMobile.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            this.txbMobile.EmptyWarning = null;
            this.txbMobile.Lines = new string[0];
            this.txbMobile.Location = new System.Drawing.Point(357, 34);
            this.txbMobile.MaxLength = 32767;
            this.txbMobile.Name = "txbMobile";
            this.txbMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMobile.SelectedText = "";
            this.txbMobile.SelectionLength = 0;
            this.txbMobile.Size = new System.Drawing.Size(173, 23);
            this.txbMobile.TabIndex = 3;
            this.txbMobile.UseSelectable = true;
            // 
            // txbCnName
            // 
            this.txbCnName.BindingRequestPropertyName = "Form.CnName";
            this.txbCnName.BindingResponsePropertyName = null;
            this.txbCnName.BindingSourcePropertyName = "CnName";
            this.txbCnName.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            this.txbCnName.EmptyWarning = null;
            this.txbCnName.Lines = new string[0];
            this.txbCnName.Location = new System.Drawing.Point(78, 34);
            this.txbCnName.MaxLength = 32767;
            this.txbCnName.Name = "txbCnName";
            this.txbCnName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCnName.SelectedText = "";
            this.txbCnName.SelectionLength = 0;
            this.txbCnName.Size = new System.Drawing.Size(173, 23);
            this.txbCnName.TabIndex = 2;
            this.txbCnName.UseSelectable = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 220);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "备注：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "地址：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "证件号码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "微信：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "QQ：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "手机：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbID);
            this.groupBox3.Controls.Add(this.chkEnabled);
            this.groupBox3.Controls.Add(this.txbUserName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(1, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(573, 61);
            this.groupBox3.TabIndex = 100;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "基础信息";
            // 
            // txbID
            // 
            this.txbID.BindingRequestPropertyName = "Form.ID";
            this.txbID.BindingResponsePropertyName = "ID";
            this.txbID.BindingSourcePropertyName = "ID";
            this.txbID.EmptyWarning = null;
            this.txbID.Enabled = false;
            this.txbID.Lines = new string[0];
            this.txbID.Location = new System.Drawing.Point(358, 28);
            this.txbID.MaxLength = 32767;
            this.txbID.Name = "txbID";
            this.txbID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbID.SelectedText = "";
            this.txbID.SelectionLength = 0;
            this.txbID.Size = new System.Drawing.Size(172, 23);
            this.txbID.TabIndex = 2;
            this.txbID.UseSelectable = true;
            this.txbID.Visible = false;
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.BindingChecked = 1;
            this.chkEnabled.BindingRequestPropertyName = "Form.Enabled";
            this.chkEnabled.BindingResponsePropertyName = null;
            this.chkEnabled.BindingSelfPropertyName = "BindingChecked";
            this.chkEnabled.BindingSourcePropertyName = "Enabled";
            this.chkEnabled.Checked = true;
            this.chkEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnabled.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            this.chkEnabled.Group = null;
            this.chkEnabled.Location = new System.Drawing.Point(304, 34);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(47, 15);
            this.chkEnabled.TabIndex = 1;
            this.chkEnabled.Text = "启用";
            this.chkEnabled.UseSelectable = true;
            // 
            // txbUserName
            // 
            this.txbUserName.BindingRequestPropertyName = "Form.Name";
            this.txbUserName.BindingResponsePropertyName = null;
            this.txbUserName.BindingSourcePropertyName = "Name";
            this.txbUserName.CanbeEmpty = false;
            this.txbUserName.DataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never;
            this.txbUserName.EmptyWarning = "请输入用户名";
            this.txbUserName.Lines = new string[0];
            this.txbUserName.Location = new System.Drawing.Point(78, 28);
            this.txbUserName.MaxLength = 32767;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUserName.SelectedText = "";
            this.txbUserName.SelectionLength = 0;
            this.txbUserName.Size = new System.Drawing.Size(173, 23);
            this.txbUserName.TabIndex = 0;
            this.txbUserName.UseSelectable = true;
            // 
            // BaseEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 431);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseEditUser";
            this.Text = "编辑用户";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BaseEditUser_FormClosing);
            this.Load += new System.EventHandler(this.EditUser_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label9;
        private SOAFramework.Client.Controls.Label label8;
        private SOAFramework.Client.Controls.Label label7;
        private SOAFramework.Client.Controls.Label label6;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.Label label5;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.GroupBox groupBox3;
        protected SOAFramework.Client.Controls.TextBox txbUserName;
        protected SOAFramework.Client.Controls.CheckBox chkEnabled;
        protected SOAFramework.Client.Controls.TextBox txbRemark;
        protected SOAFramework.Client.Controls.TextBox txbAddress;
        protected SOAFramework.Client.Controls.TextBox txbIdentity;
        protected SOAFramework.Client.Controls.TextBox txbWX;
        protected SOAFramework.Client.Controls.TextBox txbQQ;
        protected SOAFramework.Client.Controls.TextBox txbMobile;
        protected SOAFramework.Client.Controls.TextBox txbCnName;
        protected SOAFramework.Client.Controls.TextBox txbID;
    }
}