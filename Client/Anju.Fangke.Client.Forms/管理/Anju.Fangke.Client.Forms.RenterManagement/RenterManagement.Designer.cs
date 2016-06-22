namespace Anju.Fangke.Client.Forms
{
    partial class RenterManagement
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
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.pager1 = new SOAFramework.Client.Controls.Pager.Pager();
            this.dataGridView1 = new SOAFramework.Client.Controls.DataGridView();
            this.btnQuery = new SOAFramework.Client.Controls.Button();
            this.btnAdd = new SOAFramework.Client.Controls.Button();
            this.btnEdit = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.txbIdentityCode = new SOAFramework.Client.Controls.TextBox();
            this.txbMobile = new SOAFramework.Client.Controls.TextBox();
            this.txbName = new SOAFramework.Client.Controls.TextBox();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.姓名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.身份证号码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.微信 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
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
            this.groupBox2.Size = new System.Drawing.Size(1290, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // pager1
            // 
            this.pager1.BindingRequestPropertyName = null;
            this.pager1.BindingResponsePropertyName = null;
            this.pager1.CurrentPageIndex = 1;
            this.pager1.CurrentPageIndexBindingRequestPropertyName = "form.CurrentIndex";
            this.pager1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pager1.Location = new System.Drawing.Point(5, 493);
            this.pager1.Name = "pager1";
            this.pager1.PageSizeBindingRequestPropertyName = "form.PageSize";
            this.pager1.RecordCount = 0;
            this.pager1.Size = new System.Drawing.Size(1290, 19);
            this.pager1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BindingRequestPropertyName = null;
            this.dataGridView1.BindingResponsePropertyName = null;
            this.dataGridView1.BindingSourcePropertyName = null;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.姓名,
            this.电话,
            this.身份证号码,
            this.微信});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1290, 389);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.ClickedMessage = null;
            this.btnQuery.IngoreCallbackOnce = false;
            this.btnQuery.Location = new System.Drawing.Point(6, 14);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Response = null;
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            // 
            // btnAdd
            // 
            this.btnAdd.ClickedMessage = null;
            this.btnAdd.IngoreCallbackOnce = false;
            this.btnAdd.Location = new System.Drawing.Point(87, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Response = null;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseSelectable = true;
            // 
            // btnEdit
            // 
            this.btnEdit.ClickedMessage = null;
            this.btnEdit.IngoreCallbackOnce = false;
            this.btnEdit.Location = new System.Drawing.Point(168, 14);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Response = null;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(249, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "退出";
            this.btnClose.UseSelectable = true;
            // 
            // txbIdentityCode
            // 
            this.txbIdentityCode.BindingRequestPropertyName = "form.IdentityCode";
            this.txbIdentityCode.BindingResponsePropertyName = null;
            this.txbIdentityCode.BindingSourcePropertyName = null;
            this.txbIdentityCode.EmptyToNull = true;
            this.txbIdentityCode.EmptyWarning = null;
            this.txbIdentityCode.Lines = new string[0];
            this.txbIdentityCode.Location = new System.Drawing.Point(568, 20);
            this.txbIdentityCode.MaxLength = 32767;
            this.txbIdentityCode.Name = "txbIdentityCode";
            this.txbIdentityCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdentityCode.SelectedText = "";
            this.txbIdentityCode.SelectionLength = 0;
            this.txbIdentityCode.SelectionStart = 0;
            this.txbIdentityCode.Size = new System.Drawing.Size(172, 23);
            this.txbIdentityCode.TabIndex = 11;
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
            this.txbMobile.Location = new System.Drawing.Point(305, 20);
            this.txbMobile.MaxLength = 32767;
            this.txbMobile.Name = "txbMobile";
            this.txbMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMobile.SelectedText = "";
            this.txbMobile.SelectionLength = 0;
            this.txbMobile.SelectionStart = 0;
            this.txbMobile.Size = new System.Drawing.Size(172, 23);
            this.txbMobile.TabIndex = 10;
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
            this.txbName.Location = new System.Drawing.Point(56, 20);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbName.SelectedText = "";
            this.txbName.SelectionLength = 0;
            this.txbName.SelectionStart = 0;
            this.txbName.Size = new System.Drawing.Size(172, 23);
            this.txbName.TabIndex = 9;
            this.txbName.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "身份证号码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "手机号码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "姓名";
            // 
            // 姓名
            // 
            this.姓名.DataPropertyName = "Name";
            this.姓名.HeaderText = "姓名";
            this.姓名.Name = "姓名";
            this.姓名.ReadOnly = true;
            // 
            // 电话
            // 
            this.电话.DataPropertyName = "Mobile";
            this.电话.HeaderText = "电话";
            this.电话.Name = "电话";
            this.电话.ReadOnly = true;
            this.电话.Width = 120;
            // 
            // 身份证号码
            // 
            this.身份证号码.DataPropertyName = "IdentityCode";
            this.身份证号码.HeaderText = "身份证号码";
            this.身份证号码.Name = "身份证号码";
            this.身份证号码.ReadOnly = true;
            // 
            // 微信
            // 
            this.微信.DataPropertyName = "WX";
            this.微信.HeaderText = "微信";
            this.微信.Name = "微信";
            this.微信.ReadOnly = true;
            this.微信.Width = 120;
            // 
            // RenterManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RenterManagement";
            this.Text = "RenterManagement";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.GroupBox groupBox2;
        private SOAFramework.Client.Controls.Pager.Pager pager1;
        private SOAFramework.Client.Controls.DataGridView dataGridView1;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.Button btnEdit;
        private SOAFramework.Client.Controls.Button btnAdd;
        private SOAFramework.Client.Controls.Button btnQuery;
        private SOAFramework.Client.Controls.TextBox txbIdentityCode;
        private SOAFramework.Client.Controls.TextBox txbMobile;
        private SOAFramework.Client.Controls.TextBox txbName;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话;
        private System.Windows.Forms.DataGridViewTextBoxColumn 身份证号码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 微信;
    }
}