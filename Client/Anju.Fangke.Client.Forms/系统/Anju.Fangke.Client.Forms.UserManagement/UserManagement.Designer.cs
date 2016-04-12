namespace Anju.Fangke.Client.Forms
{
    partial class UserManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAuthority = new SOAFramework.Client.Controls.Button();
            this.btnChangePassword = new SOAFramework.Client.Controls.Button();
            this.btnDelete = new SOAFramework.Client.Controls.Button();
            this.btnEdit = new SOAFramework.Client.Controls.Button();
            this.btnAdd = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.btnSearch = new SOAFramework.Client.Controls.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbEnabled = new SOAFramework.Client.Controls.ComboBox();
            this.txbMobile = new SOAFramework.Client.Controls.TextBox();
            this.txbName = new SOAFramework.Client.Controls.TextBox();
            this.txbId = new SOAFramework.Client.Controls.TextBox();
            this.txbUserName = new SOAFramework.Client.Controls.TextBox();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.dgvUsers = new SOAFramework.Client.Controls.DataGridView();
            this.用户名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手机 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.微信 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.启用 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAuthority);
            this.groupBox1.Controls.Add(this.btnChangePassword);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1184, 54);
            this.groupBox1.TabIndex = 100;
            this.groupBox1.TabStop = false;
            // 
            // btnAuthority
            // 
            this.btnAuthority.ClickedMessage = null;
            this.btnAuthority.IngoreCallbackOnce = false;
            this.btnAuthority.Location = new System.Drawing.Point(412, 17);
            this.btnAuthority.Name = "btnAuthority";
            this.btnAuthority.Response = null;
            this.btnAuthority.Size = new System.Drawing.Size(75, 23);
            this.btnAuthority.TabIndex = 6;
            this.btnAuthority.Text = "配置权限";
            this.btnAuthority.UseSelectable = true;
            this.btnAuthority.Click += new System.EventHandler(this.btnAuthority_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.ClickedMessage = null;
            this.btnChangePassword.IngoreCallbackOnce = false;
            this.btnChangePassword.Location = new System.Drawing.Point(331, 17);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Response = null;
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 5;
            this.btnChangePassword.Text = "修改密码";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ClickedMessage = null;
            this.btnDelete.EnableClickOnceOnAction = true;
            this.btnDelete.EnableSyncClick = true;
            this.btnDelete.IngoreCallbackOnce = false;
            this.btnDelete.Location = new System.Drawing.Point(249, 17);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Response = null;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.ClickCallback += new System.EventHandler(this.btnDelete_ClickCallback);
            // 
            // btnEdit
            // 
            this.btnEdit.ClickedMessage = null;
            this.btnEdit.IngoreCallbackOnce = false;
            this.btnEdit.Location = new System.Drawing.Point(168, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Response = null;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ClickedMessage = null;
            this.btnAdd.IngoreCallbackOnce = false;
            this.btnAdd.Location = new System.Drawing.Point(87, 17);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Response = null;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(493, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ClickedMessage = null;
            this.btnSearch.EnableClickOnceOnAction = true;
            this.btnSearch.EnableSyncClick = true;
            this.btnSearch.IngoreCallbackOnce = false;
            this.btnSearch.Location = new System.Drawing.Point(6, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RequestName = "QueryUserRequest";
            this.btnSearch.Response = null;
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbEnabled);
            this.groupBox2.Controls.Add(this.txbMobile);
            this.groupBox2.Controls.Add(this.txbName);
            this.groupBox2.Controls.Add(this.txbId);
            this.groupBox2.Controls.Add(this.txbUserName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1184, 89);
            this.groupBox2.TabIndex = 200;
            this.groupBox2.TabStop = false;
            // 
            // cmbEnabled
            // 
            this.cmbEnabled.BindingRequestPropertyName = "Enabled";
            this.cmbEnabled.BindingResponsePropertyName = null;
            this.cmbEnabled.BindingSourcePropertyName = null;
            this.cmbEnabled.DisplayMember = "Name";
            this.cmbEnabled.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbEnabled.FormattingEnabled = true;
            this.cmbEnabled.HasAll = true;
            this.cmbEnabled.InitableBindingGroupName = "启用状态";
            this.cmbEnabled.ItemHeight = 19;
            this.cmbEnabled.Location = new System.Drawing.Point(330, 51);
            this.cmbEnabled.Name = "cmbEnabled";
            this.cmbEnabled.Size = new System.Drawing.Size(155, 25);
            this.cmbEnabled.TabIndex = 10;
            this.cmbEnabled.UseSelectable = true;
            this.cmbEnabled.Value = null;
            this.cmbEnabled.ValueMember = "Value";
            // 
            // txbMobile
            // 
            this.txbMobile.BindingRequestPropertyName = "Mobile";
            this.txbMobile.BindingResponsePropertyName = null;
            this.txbMobile.BindingSourcePropertyName = null;
            this.txbMobile.EmptyToNull = true;
            this.txbMobile.EmptyWarning = null;
            this.txbMobile.Lines = new string[0];
            this.txbMobile.Location = new System.Drawing.Point(567, 17);
            this.txbMobile.MaxLength = 32767;
            this.txbMobile.Name = "txbMobile";
            this.txbMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMobile.SelectedText = "";
            this.txbMobile.SelectionLength = 0;
            this.txbMobile.Size = new System.Drawing.Size(156, 23);
            this.txbMobile.TabIndex = 8;
            this.txbMobile.UseSelectable = true;
            // 
            // txbName
            // 
            this.txbName.BindingRequestPropertyName = "CnName";
            this.txbName.BindingResponsePropertyName = null;
            this.txbName.BindingSourcePropertyName = null;
            this.txbName.EmptyToNull = true;
            this.txbName.EmptyWarning = null;
            this.txbName.Lines = new string[0];
            this.txbName.Location = new System.Drawing.Point(330, 17);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbName.SelectedText = "";
            this.txbName.SelectionLength = 0;
            this.txbName.Size = new System.Drawing.Size(156, 23);
            this.txbName.TabIndex = 7;
            this.txbName.UseSelectable = true;
            // 
            // txbId
            // 
            this.txbId.BindingRequestPropertyName = "Identity";
            this.txbId.BindingResponsePropertyName = null;
            this.txbId.BindingSourcePropertyName = null;
            this.txbId.EmptyToNull = true;
            this.txbId.EmptyWarning = null;
            this.txbId.Lines = new string[0];
            this.txbId.Location = new System.Drawing.Point(87, 51);
            this.txbId.MaxLength = 32767;
            this.txbId.Name = "txbId";
            this.txbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbId.SelectedText = "";
            this.txbId.SelectionLength = 0;
            this.txbId.Size = new System.Drawing.Size(156, 23);
            this.txbId.TabIndex = 9;
            this.txbId.UseSelectable = true;
            // 
            // txbUserName
            // 
            this.txbUserName.BindingRequestPropertyName = "Form.CnName";
            this.txbUserName.BindingResponsePropertyName = null;
            this.txbUserName.BindingSourcePropertyName = null;
            this.txbUserName.EmptyToNull = true;
            this.txbUserName.EmptyWarning = null;
            this.txbUserName.Lines = new string[0];
            this.txbUserName.Location = new System.Drawing.Point(87, 17);
            this.txbUserName.MaxLength = 32767;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUserName.SelectedText = "";
            this.txbUserName.SelectionLength = 0;
            this.txbUserName.Size = new System.Drawing.Size(156, 23);
            this.txbUserName.TabIndex = 6;
            this.txbUserName.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "是否启用";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "手机";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "证件号码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoGenerateColumns = false;
            this.dgvUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsers.BindingRequestPropertyName = null;
            this.dgvUsers.BindingResponsePropertyName = "Users";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.用户名,
            this.姓名,
            this.手机,
            this.QQ,
            this.微信,
            this.启用,
            this.备注,
            this.ID});
            this.dgvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsers.Location = new System.Drawing.Point(5, 144);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowTemplate.Height = 23;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(1184, 341);
            this.dgvUsers.TabIndex = 2;
            // 
            // 用户名
            // 
            this.用户名.DataPropertyName = "Name";
            this.用户名.HeaderText = "用户名";
            this.用户名.Name = "用户名";
            this.用户名.ReadOnly = true;
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "CnName";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 手机
            // 
            this.手机.DataPropertyName = "Mobile";
            this.手机.HeaderText = "手机";
            this.手机.Name = "手机";
            this.手机.ReadOnly = true;
            this.手机.Width = 120;
            // 
            // QQ
            // 
            this.QQ.DataPropertyName = "QQ";
            this.QQ.HeaderText = "QQ";
            this.QQ.Name = "QQ";
            this.QQ.ReadOnly = true;
            this.QQ.Width = 120;
            // 
            // 微信
            // 
            this.微信.DataPropertyName = "WX";
            this.微信.HeaderText = "微信";
            this.微信.Name = "微信";
            this.微信.ReadOnly = true;
            // 
            // 启用
            // 
            this.启用.DataPropertyName = "Enabled";
            this.启用.FalseValue = "0";
            this.启用.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.启用.HeaderText = "启用";
            this.启用.Name = "启用";
            this.启用.ReadOnly = true;
            this.启用.TrueValue = "1";
            this.启用.Width = 80;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "Remark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 200;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // UserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 490);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DisplayHeader = false;
            this.Name = "UserManagement";
            this.Padding = new System.Windows.Forms.Padding(5, 1, 5, 5);
            this.Text = "员工管理";
            this.InitControl += new System.EventHandler(this.UserManagement_InitControl);
            this.Load += new System.EventHandler(this.UserManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private SOAFramework.Client.Controls.Button btnDelete;
        private SOAFramework.Client.Controls.Button btnEdit;
        private SOAFramework.Client.Controls.Button btnAdd;
        private SOAFramework.Client.Controls.Label label5;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.TextBox txbMobile;
        private SOAFramework.Client.Controls.TextBox txbName;
        private SOAFramework.Client.Controls.TextBox txbId;
        private SOAFramework.Client.Controls.TextBox txbUserName;
        private SOAFramework.Client.Controls.ComboBox cmbEnabled;
        private SOAFramework.Client.Controls.DataGridView dgvUsers;
        private SOAFramework.Client.Controls.Button btnAuthority;
        private SOAFramework.Client.Controls.Button btnChangePassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 手机;
        private System.Windows.Forms.DataGridViewTextBoxColumn QQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn 微信;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 启用;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}