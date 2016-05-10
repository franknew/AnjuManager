namespace Anju.Fangke.Client.Forms
{
    partial class BaseEditRole
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
            this.chkList = new SOAFramework.Client.Controls.CheckBoxList();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.txbRemark = new SOAFramework.Client.Controls.TextBox();
            this.cmbLevel = new SOAFramework.Client.Controls.ComboBox();
            this.cmbRole = new SOAFramework.Client.Controls.ComboBox();
            this.cmbDataAccessType = new SOAFramework.Client.Controls.ComboBox();
            this.txbName = new SOAFramework.Client.Controls.TextBox();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.groupBox3 = new SOAFramework.Client.Controls.GroupBox();
            this.panel1 = new SOAFramework.Client.Controls.Panel();
            this.chkMenu = new SOAFramework.Client.Controls.CheckBoxList();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 403);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chkList
            // 
            this.chkList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkList.FormattingEnabled = true;
            this.chkList.Location = new System.Drawing.Point(0, 205);
            this.chkList.Name = "chkList";
            this.chkList.Size = new System.Drawing.Size(367, 198);
            this.chkList.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbRemark);
            this.groupBox2.Controls.Add(this.cmbLevel);
            this.groupBox2.Controls.Add(this.cmbRole);
            this.groupBox2.Controls.Add(this.cmbDataAccessType);
            this.groupBox2.Controls.Add(this.txbName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基础信息";
            // 
            // txbRemark
            // 
            this.txbRemark.BindingRequestPropertyName = null;
            this.txbRemark.BindingResponsePropertyName = null;
            this.txbRemark.BindingSourcePropertyName = "Remark";
            this.txbRemark.EmptyWarning = null;
            this.txbRemark.Lines = new string[0];
            this.txbRemark.Location = new System.Drawing.Point(89, 139);
            this.txbRemark.MaxLength = 32767;
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRemark.SelectedText = "";
            this.txbRemark.SelectionLength = 0;
            this.txbRemark.SelectionStart = 0;
            this.txbRemark.Size = new System.Drawing.Size(257, 58);
            this.txbRemark.TabIndex = 9;
            this.txbRemark.UseSelectable = true;
            // 
            // cmbLevel
            // 
            this.cmbLevel.BindingRequestPropertyName = null;
            this.cmbLevel.BindingResponsePropertyName = null;
            this.cmbLevel.BindingSourcePropertyName = "Level";
            this.cmbLevel.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.InitableBindingGroupName = null;
            this.cmbLevel.ItemHeight = 19;
            this.cmbLevel.Location = new System.Drawing.Point(89, 108);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(257, 25);
            this.cmbLevel.TabIndex = 8;
            this.cmbLevel.UseSelectable = true;
            this.cmbLevel.Value = null;
            // 
            // cmbRole
            // 
            this.cmbRole.BindingRequestPropertyName = "form.ParentID";
            this.cmbRole.BindingResponsePropertyName = null;
            this.cmbRole.BindingSourcePropertyName = "ParentID";
            this.cmbRole.DisplayMember = "Name";
            this.cmbRole.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.InitableBindingGroupName = null;
            this.cmbRole.ItemHeight = 19;
            this.cmbRole.Location = new System.Drawing.Point(89, 77);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(257, 25);
            this.cmbRole.TabIndex = 7;
            this.cmbRole.UseSelectable = true;
            this.cmbRole.Value = null;
            this.cmbRole.ValueMember = "ID";
            // 
            // cmbDataAccessType
            // 
            this.cmbDataAccessType.BindingRequestPropertyName = "form.DataAccessType";
            this.cmbDataAccessType.BindingResponsePropertyName = null;
            this.cmbDataAccessType.BindingSourcePropertyName = "DataAccessType";
            this.cmbDataAccessType.DisplayMember = "Name";
            this.cmbDataAccessType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbDataAccessType.FormattingEnabled = true;
            this.cmbDataAccessType.InitableBindingGroupName = "数据访问类型";
            this.cmbDataAccessType.ItemHeight = 19;
            this.cmbDataAccessType.Location = new System.Drawing.Point(90, 46);
            this.cmbDataAccessType.Name = "cmbDataAccessType";
            this.cmbDataAccessType.Size = new System.Drawing.Size(257, 25);
            this.cmbDataAccessType.TabIndex = 6;
            this.cmbDataAccessType.UseSelectable = true;
            this.cmbDataAccessType.Value = null;
            this.cmbDataAccessType.ValueMember = "Value";
            // 
            // txbName
            // 
            this.txbName.BindingRequestPropertyName = "form.Name";
            this.txbName.BindingResponsePropertyName = null;
            this.txbName.BindingSourcePropertyName = "Name";
            this.txbName.CanbeEmpty = false;
            this.txbName.EmptyWarning = null;
            this.txbName.Lines = new string[0];
            this.txbName.Location = new System.Drawing.Point(90, 17);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbName.SelectedText = "";
            this.txbName.SelectionLength = 0;
            this.txbName.SelectionStart = 0;
            this.txbName.Size = new System.Drawing.Size(257, 23);
            this.txbName.TabIndex = 5;
            this.txbName.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "备注";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "级别";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "上级";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据权限";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(46, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(218, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkMenu);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(368, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(295, 454);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "菜单信息";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkList);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 454);
            this.panel1.TabIndex = 4;
            // 
            // chkMenu
            // 
            this.chkMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkMenu.FormattingEnabled = true;
            this.chkMenu.Location = new System.Drawing.Point(3, 17);
            this.chkMenu.Name = "chkMenu";
            this.chkMenu.Size = new System.Drawing.Size(289, 434);
            this.chkMenu.TabIndex = 1;
            // 
            // BaseEditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 485);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Name = "BaseEditRole";
            this.Text = "BaseEditRole";
            this.InitControl += new System.EventHandler(this.BaseEditRole_InitControl);
            this.Load += new System.EventHandler(this.BaseEditRole_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected SOAFramework.Client.Controls.GroupBox groupBox1;
        protected SOAFramework.Client.Controls.Button btnSave;
        protected SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.GroupBox groupBox2;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.Label label5;
        protected SOAFramework.Client.Controls.CheckBoxList chkList;
        protected SOAFramework.Client.Controls.TextBox txbName;
        protected SOAFramework.Client.Controls.ComboBox cmbDataAccessType;
        protected SOAFramework.Client.Controls.ComboBox cmbRole;
        protected SOAFramework.Client.Controls.TextBox txbRemark;
        protected SOAFramework.Client.Controls.ComboBox cmbLevel;
        private SOAFramework.Client.Controls.GroupBox groupBox3;
        protected SOAFramework.Client.Controls.CheckBoxList chkMenu;
        private SOAFramework.Client.Controls.Panel panel1;
    }
}