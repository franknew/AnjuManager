namespace Anju.Fangke.Client.Forms
{
    partial class BaseCustomerManagement
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
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.btnDelete = new SOAFramework.Client.Controls.Button();
            this.btnEdit = new SOAFramework.Client.Controls.Button();
            this.btnAdd = new SOAFramework.Client.Controls.Button();
            this.btnQuery = new SOAFramework.Client.Controls.Button();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.txbIdentityCode = new SOAFramework.Client.Controls.TextBox();
            this.txbMobile = new SOAFramework.Client.Controls.TextBox();
            this.txbName = new SOAFramework.Client.Controls.TextBox();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.dgvList = new SOAFramework.Client.Controls.DataGridView();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.手机号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.微信 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1290, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(330, 13);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "退出";
            this.btnClose.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ClickedMessage = null;
            this.btnDelete.IngoreCallbackOnce = false;
            this.btnDelete.Location = new System.Drawing.Point(249, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Response = null;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ClickedMessage = null;
            this.btnEdit.IngoreCallbackOnce = false;
            this.btnEdit.Location = new System.Drawing.Point(168, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Response = null;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ClickedMessage = null;
            this.btnAdd.IngoreCallbackOnce = false;
            this.btnAdd.Location = new System.Drawing.Point(87, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Response = null;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.ClickedMessage = null;
            this.btnQuery.EnableSyncClick = true;
            this.btnQuery.IngoreCallbackOnce = false;
            this.btnQuery.Location = new System.Drawing.Point(6, 13);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.RequestName = "QueryOwnerRequest";
            this.btnQuery.Response = null;
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbIdentityCode);
            this.groupBox2.Controls.Add(this.txbMobile);
            this.groupBox2.Controls.Add(this.txbName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1290, 54);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询条件";
            // 
            // txbIdentityCode
            // 
            this.txbIdentityCode.BindingRequestPropertyName = "form.IdentityCode";
            this.txbIdentityCode.BindingResponsePropertyName = null;
            this.txbIdentityCode.BindingSourcePropertyName = null;
            this.txbIdentityCode.EmptyToNull = true;
            this.txbIdentityCode.EmptyWarning = null;
            this.txbIdentityCode.Lines = new string[0];
            this.txbIdentityCode.Location = new System.Drawing.Point(583, 20);
            this.txbIdentityCode.MaxLength = 32767;
            this.txbIdentityCode.Name = "txbIdentityCode";
            this.txbIdentityCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdentityCode.SelectedText = "";
            this.txbIdentityCode.SelectionLength = 0;
            this.txbIdentityCode.SelectionStart = 0;
            this.txbIdentityCode.Size = new System.Drawing.Size(172, 23);
            this.txbIdentityCode.TabIndex = 5;
            this.txbIdentityCode.UseSelectable = true;
            // 
            // txbMobile
            // 
            this.txbMobile.BindingRequestPropertyName = "form.Mobile";
            this.txbMobile.BindingResponsePropertyName = null;
            this.txbMobile.BindingSourcePropertyName = null;
            this.txbMobile.EmptyToNull = true;
            this.txbMobile.EmptyWarning = null;
            this.txbMobile.Lines = new string[0];
            this.txbMobile.Location = new System.Drawing.Point(320, 20);
            this.txbMobile.MaxLength = 32767;
            this.txbMobile.Name = "txbMobile";
            this.txbMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMobile.SelectedText = "";
            this.txbMobile.SelectionLength = 0;
            this.txbMobile.SelectionStart = 0;
            this.txbMobile.Size = new System.Drawing.Size(172, 23);
            this.txbMobile.TabIndex = 4;
            this.txbMobile.UseSelectable = true;
            // 
            // txbName
            // 
            this.txbName.BindingRequestPropertyName = "form.Name";
            this.txbName.BindingResponsePropertyName = null;
            this.txbName.BindingSourcePropertyName = null;
            this.txbName.EmptyToNull = true;
            this.txbName.EmptyWarning = null;
            this.txbName.Lines = new string[0];
            this.txbName.Location = new System.Drawing.Point(71, 20);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbName.SelectedText = "";
            this.txbName.SelectionLength = 0;
            this.txbName.SelectionStart = 0;
            this.txbName.Size = new System.Drawing.Size(172, 23);
            this.txbName.TabIndex = 3;
            this.txbName.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "身份证号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "手机号码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.BindingRequestPropertyName = null;
            this.dgvList.BindingResponsePropertyName = "Customer";
            this.dgvList.BindingSourcePropertyName = null;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名称,
            this.手机号码,
            this.身份证,
            this.微信,
            this.备注});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(5, 102);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1290, 410);
            this.dgvList.TabIndex = 2;
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "Name";
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            // 
            // 手机号码
            // 
            this.手机号码.DataPropertyName = "Mobile";
            this.手机号码.HeaderText = "手机号码";
            this.手机号码.Name = "手机号码";
            this.手机号码.ReadOnly = true;
            this.手机号码.Width = 120;
            // 
            // 身份证
            // 
            this.身份证.DataPropertyName = "IdentityCode";
            this.身份证.HeaderText = "身份证";
            this.身份证.Name = "身份证";
            this.身份证.ReadOnly = true;
            this.身份证.Width = 150;
            // 
            // 微信
            // 
            this.微信.DataPropertyName = "WX";
            this.微信.HeaderText = "微信";
            this.微信.Name = "微信";
            this.微信.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "Remark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 500;
            // 
            // BaseCustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 517);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseCustomerManagement";
            this.Text = "业主管理";
            this.InitControl += new System.EventHandler(this.CustomerManagement_InitControl);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected SOAFramework.Client.Controls.GroupBox groupBox1;
        protected SOAFramework.Client.Controls.GroupBox groupBox2;
        protected SOAFramework.Client.Controls.DataGridView dgvList;
        protected SOAFramework.Client.Controls.Button btnClose;
        protected SOAFramework.Client.Controls.Button btnDelete;
        protected SOAFramework.Client.Controls.Button btnEdit;
        protected SOAFramework.Client.Controls.Button btnAdd;
        protected SOAFramework.Client.Controls.Button btnQuery;
        protected System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        protected System.Windows.Forms.DataGridViewTextBoxColumn 手机号码;
        protected System.Windows.Forms.DataGridViewTextBoxColumn 身份证;
        protected System.Windows.Forms.DataGridViewTextBoxColumn 微信;
        protected System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        protected SOAFramework.Client.Controls.Label label1;
        protected SOAFramework.Client.Controls.Label label3;
        protected SOAFramework.Client.Controls.Label label2;
        protected SOAFramework.Client.Controls.TextBox txbIdentityCode;
        protected SOAFramework.Client.Controls.TextBox txbMobile;
        protected SOAFramework.Client.Controls.TextBox txbName;
    }
}