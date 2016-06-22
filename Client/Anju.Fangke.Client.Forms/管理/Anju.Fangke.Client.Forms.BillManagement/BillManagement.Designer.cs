namespace Anju.Fangke.Client.Forms
{
    partial class BillManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.btnDelete = new SOAFramework.Client.Controls.Button();
            this.btnEdit = new SOAFramework.Client.Controls.Button();
            this.btnGenerate = new SOAFramework.Client.Controls.Button();
            this.btnQuery = new SOAFramework.Client.Controls.Button();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.txbRentDay = new SOAFramework.Client.Controls.TextBox();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.cmbHouse = new SOAFramework.Client.Controls.ComboBox();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.cmbBuilding = new SOAFramework.Client.Controls.ComboBox();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.dateTimeComboPicker1 = new SOAFramework.Client.Controls.DateTimeComboPicker();
            this.dgvBill = new SOAFramework.Client.Controls.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.账单名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.楼栋名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.交租日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.应收 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已收 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1290, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(330, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.RequestName = "";
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
            this.btnDelete.Location = new System.Drawing.Point(249, 15);
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
            this.btnEdit.Location = new System.Drawing.Point(87, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Response = null;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "编辑账单";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.ClickedMessage = null;
            this.btnGenerate.IngoreCallbackOnce = false;
            this.btnGenerate.Location = new System.Drawing.Point(168, 15);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Response = null;
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "生成账单";
            this.btnGenerate.UseSelectable = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.ClickedMessage = null;
            this.btnQuery.EnableSyncClick = true;
            this.btnQuery.IngoreCallbackOnce = false;
            this.btnQuery.Location = new System.Drawing.Point(6, 15);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.RequestName = "QueryBillRequest";
            this.btnQuery.Response = null;
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbRentDay);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbHouse);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbBuilding);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimeComboPicker1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1290, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txbRentDay
            // 
            this.txbRentDay.BindingRequestPropertyName = "form.RentDay";
            this.txbRentDay.BindingResponsePropertyName = null;
            this.txbRentDay.BindingSourcePropertyName = null;
            this.txbRentDay.EmptyToNull = true;
            this.txbRentDay.EmptyWarning = null;
            this.txbRentDay.InputType = SOAFramework.Client.Controls.InputType.整数;
            this.txbRentDay.Lines = new string[0];
            this.txbRentDay.Location = new System.Drawing.Point(430, 14);
            this.txbRentDay.MaxLength = 32767;
            this.txbRentDay.Name = "txbRentDay";
            this.txbRentDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRentDay.SelectedText = "";
            this.txbRentDay.SelectionLength = 0;
            this.txbRentDay.SelectionStart = 0;
            this.txbRentDay.Size = new System.Drawing.Size(117, 23);
            this.txbRentDay.TabIndex = 8;
            this.txbRentDay.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "收租日";
            // 
            // cmbHouse
            // 
            this.cmbHouse.BindingRequestPropertyName = "form.HouseID";
            this.cmbHouse.BindingResponsePropertyName = null;
            this.cmbHouse.BindingSourcePropertyName = null;
            this.cmbHouse.DisplayMember = "Text";
            this.cmbHouse.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbHouse.FormattingEnabled = true;
            this.cmbHouse.InitableBindingGroupName = null;
            this.cmbHouse.ItemHeight = 19;
            this.cmbHouse.Location = new System.Drawing.Point(229, 14);
            this.cmbHouse.Name = "cmbHouse";
            this.cmbHouse.Size = new System.Drawing.Size(121, 25);
            this.cmbHouse.TabIndex = 6;
            this.cmbHouse.UseSelectable = true;
            this.cmbHouse.Value = null;
            this.cmbHouse.ValueMember = "Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "房间";
            // 
            // cmbBuilding
            // 
            this.cmbBuilding.BindingRequestPropertyName = "form.BuildingID";
            this.cmbBuilding.BindingResponsePropertyName = null;
            this.cmbBuilding.BindingSourcePropertyName = null;
            this.cmbBuilding.DisplayMember = "Name";
            this.cmbBuilding.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbBuilding.FormattingEnabled = true;
            this.cmbBuilding.InitableBindingGroupName = null;
            this.cmbBuilding.ItemHeight = 19;
            this.cmbBuilding.Location = new System.Drawing.Point(48, 14);
            this.cmbBuilding.Name = "cmbBuilding";
            this.cmbBuilding.Size = new System.Drawing.Size(121, 25);
            this.cmbBuilding.TabIndex = 4;
            this.cmbBuilding.UseSelectable = true;
            this.cmbBuilding.Value = null;
            this.cmbBuilding.ValueMember = "ID";
            this.cmbBuilding.SelectedIndexChanged += new System.EventHandler(this.cmbBuilding_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "楼栋";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(734, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "至";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(553, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "租房日期";
            this.label1.Visible = false;
            // 
            // dateTimeComboPicker1
            // 
            this.dateTimeComboPicker1.BindingRequestPropertyName = null;
            this.dateTimeComboPicker1.BindingResponsePropertyName = null;
            this.dateTimeComboPicker1.BindingSourcePropertyName = null;
            this.dateTimeComboPicker1.CollectFormat = null;
            this.dateTimeComboPicker1.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dateTimeComboPicker1.Location = new System.Drawing.Point(624, 13);
            this.dateTimeComboPicker1.MinimumSize = new System.Drawing.Size(0, 25);
            this.dateTimeComboPicker1.Name = "dateTimeComboPicker1";
            this.dateTimeComboPicker1.Size = new System.Drawing.Size(104, 25);
            this.dateTimeComboPicker1.TabIndex = 0;
            this.dateTimeComboPicker1.Visible = false;
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToOrderColumns = true;
            this.dgvBill.AutoGenerateColumns = false;
            this.dgvBill.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvBill.BindingRequestPropertyName = null;
            this.dgvBill.BindingResponsePropertyName = "Table";
            this.dgvBill.BindingSourcePropertyName = null;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.房间ID,
            this.账单名称,
            this.楼栋名称,
            this.房间名称,
            this.交租日期,
            this.应收,
            this.已收});
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.Location = new System.Drawing.Point(5, 143);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.ReadOnly = true;
            this.dgvBill.RowTemplate.Height = 23;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(1290, 369);
            this.dgvBill.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // 房间ID
            // 
            this.房间ID.DataPropertyName = "房间ID";
            this.房间ID.HeaderText = "房间ID";
            this.房间ID.Name = "房间ID";
            this.房间ID.ReadOnly = true;
            this.房间ID.Visible = false;
            // 
            // 账单名称
            // 
            this.账单名称.DataPropertyName = "账单名称";
            this.账单名称.HeaderText = "账单名称";
            this.账单名称.Name = "账单名称";
            this.账单名称.ReadOnly = true;
            this.账单名称.Width = 120;
            // 
            // 楼栋名称
            // 
            this.楼栋名称.DataPropertyName = "楼栋名称";
            this.楼栋名称.HeaderText = "楼栋名称";
            this.楼栋名称.Name = "楼栋名称";
            this.楼栋名称.ReadOnly = true;
            this.楼栋名称.Width = 150;
            // 
            // 房间名称
            // 
            this.房间名称.DataPropertyName = "房间名称";
            this.房间名称.HeaderText = "房间名称";
            this.房间名称.Name = "房间名称";
            this.房间名称.ReadOnly = true;
            this.房间名称.Width = 150;
            // 
            // 交租日期
            // 
            this.交租日期.DataPropertyName = "交租日期";
            dataGridViewCellStyle2.Format = "\\yyyy-MM-dd";
            this.交租日期.DefaultCellStyle = dataGridViewCellStyle2;
            this.交租日期.HeaderText = "交租日期";
            this.交租日期.Name = "交租日期";
            this.交租日期.ReadOnly = true;
            this.交租日期.Width = 120;
            // 
            // 应收
            // 
            this.应收.DataPropertyName = "应收";
            this.应收.HeaderText = "应收";
            this.应收.Name = "应收";
            this.应收.ReadOnly = true;
            // 
            // 已收
            // 
            this.已收.DataPropertyName = "已收";
            this.已收.HeaderText = "已收";
            this.已收.Name = "已收";
            this.已收.ReadOnly = true;
            // 
            // BillManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 517);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BillManagement";
            this.Text = "账单管理";
            this.InitControl += new System.EventHandler(this.BillManagement_InitControl);
            this.Shown += new System.EventHandler(this.BillManagement_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.GroupBox groupBox2;
        private SOAFramework.Client.Controls.DataGridView dgvBill;
        private SOAFramework.Client.Controls.Button btnQuery;
        private SOAFramework.Client.Controls.Button btnGenerate;
        private SOAFramework.Client.Controls.Button btnEdit;
        private SOAFramework.Client.Controls.DateTimeComboPicker dateTimeComboPicker1;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.ComboBox cmbBuilding;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.Label label5;
        private SOAFramework.Client.Controls.ComboBox cmbHouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 账单名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼栋名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 交租日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 应收;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已收;
        private SOAFramework.Client.Controls.TextBox txbRentDay;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.Button btnDelete;
    }
}