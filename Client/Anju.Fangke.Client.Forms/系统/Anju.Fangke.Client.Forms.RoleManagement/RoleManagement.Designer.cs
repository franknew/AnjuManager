namespace Anju.Fangke.Client.Forms
{
    partial class RoleManagement
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
            this.cmbEnabled = new SOAFramework.Client.Controls.ComboBox();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.cmbParentID = new SOAFramework.Client.Controls.ComboBox();
            this.cmbDataAccessType = new SOAFramework.Client.Controls.ComboBox();
            this.txbName = new SOAFramework.Client.Controls.TextBox();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.dgvList = new SOAFramework.Client.Controls.DataGridView();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.数据访问类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.父级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.层级 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.启用 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.groupBox1.Location = new System.Drawing.Point(5, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1123, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(330, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Tag = "";
            this.btnClose.Text = "退出";
            this.btnClose.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ClickedMessage = null;
            this.btnDelete.IngoreCallbackOnce = false;
            this.btnDelete.Location = new System.Drawing.Point(249, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Response = null;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Tag = "";
            this.btnDelete.Text = "删除";
            this.btnDelete.UseSelectable = true;
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
            this.btnEdit.Tag = "";
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseSelectable = true;
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
            this.btnAdd.Tag = "新增";
            this.btnAdd.Text = "新增";
            this.btnAdd.UseSelectable = true;
            // 
            // btnQuery
            // 
            this.btnQuery.ClickedMessage = null;
            this.btnQuery.EnableSyncClick = true;
            this.btnQuery.IngoreCallbackOnce = false;
            this.btnQuery.Location = new System.Drawing.Point(6, 14);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.RequestName = "QueryRoleRequest";
            this.btnQuery.Response = null;
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Tag = "";
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbEnabled);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbParentID);
            this.groupBox2.Controls.Add(this.cmbDataAccessType);
            this.groupBox2.Controls.Add(this.txbName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1123, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // cmbEnabled
            // 
            this.cmbEnabled.BindingRequestPropertyName = "form.Enabled";
            this.cmbEnabled.BindingResponsePropertyName = null;
            this.cmbEnabled.BindingSourcePropertyName = null;
            this.cmbEnabled.DisplayMember = "Name";
            this.cmbEnabled.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbEnabled.FormattingEnabled = true;
            this.cmbEnabled.HasAll = true;
            this.cmbEnabled.InitableBindingGroupName = "启用状态";
            this.cmbEnabled.ItemHeight = 19;
            this.cmbEnabled.Location = new System.Drawing.Point(731, 18);
            this.cmbEnabled.Name = "cmbEnabled";
            this.cmbEnabled.Size = new System.Drawing.Size(150, 25);
            this.cmbEnabled.TabIndex = 4;
            this.cmbEnabled.UseSelectable = true;
            this.cmbEnabled.Value = null;
            this.cmbEnabled.ValueMember = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(688, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "状态";
            // 
            // cmbParentID
            // 
            this.cmbParentID.BindingRequestPropertyName = "form.ParentID";
            this.cmbParentID.BindingResponsePropertyName = null;
            this.cmbParentID.BindingSourcePropertyName = null;
            this.cmbParentID.DisplayMember = "Name";
            this.cmbParentID.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbParentID.FormattingEnabled = true;
            this.cmbParentID.InitableBindingGroupName = null;
            this.cmbParentID.ItemHeight = 19;
            this.cmbParentID.Location = new System.Drawing.Point(532, 18);
            this.cmbParentID.Name = "cmbParentID";
            this.cmbParentID.Size = new System.Drawing.Size(150, 25);
            this.cmbParentID.TabIndex = 3;
            this.cmbParentID.UseSelectable = true;
            this.cmbParentID.Value = null;
            this.cmbParentID.ValueMember = "ID";
            // 
            // cmbDataAccessType
            // 
            this.cmbDataAccessType.BindingRequestPropertyName = "form.DataAccessType";
            this.cmbDataAccessType.BindingResponsePropertyName = null;
            this.cmbDataAccessType.BindingSourcePropertyName = null;
            this.cmbDataAccessType.DisplayMember = "Name";
            this.cmbDataAccessType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbDataAccessType.FormattingEnabled = true;
            this.cmbDataAccessType.HasAll = true;
            this.cmbDataAccessType.InitableBindingGroupName = "数据访问类型";
            this.cmbDataAccessType.ItemHeight = 19;
            this.cmbDataAccessType.Location = new System.Drawing.Point(305, 18);
            this.cmbDataAccessType.Name = "cmbDataAccessType";
            this.cmbDataAccessType.Size = new System.Drawing.Size(150, 25);
            this.cmbDataAccessType.TabIndex = 2;
            this.cmbDataAccessType.UseSelectable = true;
            this.cmbDataAccessType.Value = null;
            this.cmbDataAccessType.ValueMember = "ID";
            // 
            // txbName
            // 
            this.txbName.BindingRequestPropertyName = "form.Name";
            this.txbName.BindingResponsePropertyName = null;
            this.txbName.BindingSourcePropertyName = null;
            this.txbName.EmptyToNull = true;
            this.txbName.EmptyWarning = null;
            this.txbName.Lines = new string[0];
            this.txbName.Location = new System.Drawing.Point(50, 20);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbName.SelectedText = "";
            this.txbName.SelectionLength = 0;
            this.txbName.SelectionStart = 0;
            this.txbName.Size = new System.Drawing.Size(150, 23);
            this.txbName.TabIndex = 1;
            this.txbName.UseSelectable = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(461, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "父级角色";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据访问类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.BindingRequestPropertyName = null;
            this.dgvList.BindingResponsePropertyName = "Roles";
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
            this.数据访问类型,
            this.父级,
            this.层级,
            this.启用,
            this.备注});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(5, 132);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1123, 322);
            this.dgvList.TabIndex = 2;
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "Name";
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.Width = 120;
            // 
            // 数据访问类型
            // 
            this.数据访问类型.DataPropertyName = "DataAccessTypeName";
            this.数据访问类型.HeaderText = "数据访问类型";
            this.数据访问类型.Name = "数据访问类型";
            this.数据访问类型.ReadOnly = true;
            this.数据访问类型.Width = 150;
            // 
            // 父级
            // 
            this.父级.DataPropertyName = "ParentIDName";
            this.父级.HeaderText = "父级";
            this.父级.Name = "父级";
            this.父级.ReadOnly = true;
            this.父级.Width = 120;
            // 
            // 层级
            // 
            this.层级.DataPropertyName = "LevelName";
            this.层级.HeaderText = "层级";
            this.层级.Name = "层级";
            this.层级.ReadOnly = true;
            // 
            // 启用
            // 
            this.启用.DataPropertyName = "Enabled";
            this.启用.FalseValue = "0";
            this.启用.HeaderText = "启用";
            this.启用.Name = "启用";
            this.启用.ReadOnly = true;
            this.启用.TrueValue = "1";
            this.启用.Width = 60;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "Remark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 200;
            // 
            // RoleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 459);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DisplayHeader = false;
            this.Name = "RoleManagement";
            this.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            this.Text = "角色管理";
            this.InitControl += new System.EventHandler(this.RoleManagement_InitControl);
            this.ShownOnSync += new System.EventHandler(this.RoleManagement_ShownOnSync);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.Button btnQuery;
        private SOAFramework.Client.Controls.GroupBox groupBox2;
        private SOAFramework.Client.Controls.DataGridView dgvList;
        private SOAFramework.Client.Controls.Button btnAdd;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.Button btnDelete;
        private SOAFramework.Client.Controls.Button btnEdit;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.ComboBox cmbDataAccessType;
        private SOAFramework.Client.Controls.TextBox txbName;
        private SOAFramework.Client.Controls.ComboBox cmbParentID;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.ComboBox cmbEnabled;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 数据访问类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 父级;
        private System.Windows.Forms.DataGridViewTextBoxColumn 层级;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 启用;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}