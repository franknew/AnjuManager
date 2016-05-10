namespace Anju.Fangke.Client.Forms
{
    partial class TaskHouseManagement
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
            this.btnTaskHouse = new SOAFramework.Client.Controls.Button();
            this.btnQuery = new SOAFramework.Client.Controls.Button();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.txbDecorationType = new SOAFramework.Client.Controls.ComboBox();
            this.cmbStatus = new SOAFramework.Client.Controls.ComboBox();
            this.txbFloorEnd = new SOAFramework.Client.Controls.TextBox();
            this.label6 = new SOAFramework.Client.Controls.Label();
            this.txbFloorStart = new SOAFramework.Client.Controls.TextBox();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.txbHouseName = new SOAFramework.Client.Controls.TextBox();
            this.txbBuildingName = new SOAFramework.Client.Controls.TextBox();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.dgvList = new SOAFramework.Client.Controls.DataGridView();
            this.楼盘名称 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.房间名称 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.房间类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.装修类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主信息 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnTaskHouse);
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
            this.btnClose.Location = new System.Drawing.Point(168, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "退出";
            this.btnClose.UseSelectable = true;
            // 
            // btnTaskHouse
            // 
            this.btnTaskHouse.ClickedMessage = null;
            this.btnTaskHouse.IngoreCallbackOnce = false;
            this.btnTaskHouse.Location = new System.Drawing.Point(87, 14);
            this.btnTaskHouse.Name = "btnTaskHouse";
            this.btnTaskHouse.Response = null;
            this.btnTaskHouse.Size = new System.Drawing.Size(75, 23);
            this.btnTaskHouse.TabIndex = 1;
            this.btnTaskHouse.Text = "收房";
            this.btnTaskHouse.UseSelectable = true;
            this.btnTaskHouse.Click += new System.EventHandler(this.btnTaskHouse_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.ClickedMessage = null;
            this.btnQuery.EnableSyncClick = true;
            this.btnQuery.IngoreCallbackOnce = false;
            this.btnQuery.Location = new System.Drawing.Point(6, 14);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.RequestName = "QueryUnallocateHouseRequest";
            this.btnQuery.Response = null;
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbDecorationType);
            this.groupBox2.Controls.Add(this.cmbStatus);
            this.groupBox2.Controls.Add(this.txbFloorEnd);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbFloorStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbHouseName);
            this.groupBox2.Controls.Add(this.txbBuildingName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1290, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txbDecorationType
            // 
            this.txbDecorationType.BindingRequestPropertyName = "form.DecorationType";
            this.txbDecorationType.BindingResponsePropertyName = null;
            this.txbDecorationType.BindingSourcePropertyName = null;
            this.txbDecorationType.DisplayMember = "Name";
            this.txbDecorationType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.txbDecorationType.FormattingEnabled = true;
            this.txbDecorationType.HasAll = true;
            this.txbDecorationType.InitableBindingGroupName = "装修类型";
            this.txbDecorationType.ItemHeight = 19;
            this.txbDecorationType.Location = new System.Drawing.Point(77, 46);
            this.txbDecorationType.Name = "txbDecorationType";
            this.txbDecorationType.Size = new System.Drawing.Size(165, 25);
            this.txbDecorationType.TabIndex = 11;
            this.txbDecorationType.UseSelectable = true;
            this.txbDecorationType.Value = null;
            this.txbDecorationType.ValueMember = "Value";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BindingRequestPropertyName = "form.Status";
            this.cmbStatus.BindingResponsePropertyName = null;
            this.cmbStatus.BindingSourcePropertyName = null;
            this.cmbStatus.DisplayMember = "Name";
            this.cmbStatus.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.HasAll = true;
            this.cmbStatus.InitableBindingGroupName = "房间状态";
            this.cmbStatus.ItemHeight = 19;
            this.cmbStatus.Location = new System.Drawing.Point(534, 13);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(165, 25);
            this.cmbStatus.TabIndex = 8;
            this.cmbStatus.UseSelectable = true;
            this.cmbStatus.Value = null;
            this.cmbStatus.ValueMember = "Value";
            // 
            // txbFloorEnd
            // 
            this.txbFloorEnd.BindingRequestPropertyName = "form.Floor_End";
            this.txbFloorEnd.BindingResponsePropertyName = null;
            this.txbFloorEnd.BindingSourcePropertyName = null;
            this.txbFloorEnd.EmptyToNull = true;
            this.txbFloorEnd.EmptyWarning = null;
            this.txbFloorEnd.InputType = SOAFramework.Client.Controls.InputType.整数;
            this.txbFloorEnd.Lines = new string[0];
            this.txbFloorEnd.Location = new System.Drawing.Point(842, 13);
            this.txbFloorEnd.MaxLength = 32767;
            this.txbFloorEnd.Name = "txbFloorEnd";
            this.txbFloorEnd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFloorEnd.SelectedText = "";
            this.txbFloorEnd.SelectionLength = 0;
            this.txbFloorEnd.SelectionStart = 0;
            this.txbFloorEnd.Size = new System.Drawing.Size(67, 23);
            this.txbFloorEnd.TabIndex = 10;
            this.txbFloorEnd.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(821, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "-";
            // 
            // txbFloorStart
            // 
            this.txbFloorStart.BindingRequestPropertyName = "form.Floor_Start";
            this.txbFloorStart.BindingResponsePropertyName = null;
            this.txbFloorStart.BindingSourcePropertyName = null;
            this.txbFloorStart.EmptyToNull = true;
            this.txbFloorStart.EmptyWarning = null;
            this.txbFloorStart.InputType = SOAFramework.Client.Controls.InputType.整数;
            this.txbFloorStart.Lines = new string[0];
            this.txbFloorStart.Location = new System.Drawing.Point(748, 13);
            this.txbFloorStart.MaxLength = 32767;
            this.txbFloorStart.Name = "txbFloorStart";
            this.txbFloorStart.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFloorStart.SelectedText = "";
            this.txbFloorStart.SelectionLength = 0;
            this.txbFloorStart.SelectionStart = 0;
            this.txbFloorStart.Size = new System.Drawing.Size(67, 23);
            this.txbFloorStart.TabIndex = 9;
            this.txbFloorStart.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "楼层";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "装修类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "状态";
            // 
            // txbHouseName
            // 
            this.txbHouseName.BindingRequestPropertyName = "form.HouseName";
            this.txbHouseName.BindingResponsePropertyName = null;
            this.txbHouseName.BindingSourcePropertyName = null;
            this.txbHouseName.EmptyToNull = true;
            this.txbHouseName.EmptyWarning = null;
            this.txbHouseName.Lines = new string[0];
            this.txbHouseName.Location = new System.Drawing.Point(320, 15);
            this.txbHouseName.MaxLength = 32767;
            this.txbHouseName.Name = "txbHouseName";
            this.txbHouseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHouseName.SelectedText = "";
            this.txbHouseName.SelectionLength = 0;
            this.txbHouseName.SelectionStart = 0;
            this.txbHouseName.Size = new System.Drawing.Size(165, 23);
            this.txbHouseName.TabIndex = 7;
            this.txbHouseName.UseSelectable = true;
            // 
            // txbBuildingName
            // 
            this.txbBuildingName.BindingRequestPropertyName = "form.BuildingName";
            this.txbBuildingName.BindingResponsePropertyName = null;
            this.txbBuildingName.BindingSourcePropertyName = null;
            this.txbBuildingName.EmptyToNull = true;
            this.txbBuildingName.EmptyWarning = null;
            this.txbBuildingName.Lines = new string[0];
            this.txbBuildingName.Location = new System.Drawing.Point(78, 15);
            this.txbBuildingName.MaxLength = 32767;
            this.txbBuildingName.Name = "txbBuildingName";
            this.txbBuildingName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBuildingName.SelectedText = "";
            this.txbBuildingName.SelectionLength = 0;
            this.txbBuildingName.SelectionStart = 0;
            this.txbBuildingName.Size = new System.Drawing.Size(165, 23);
            this.txbBuildingName.TabIndex = 6;
            this.txbBuildingName.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "房间名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "楼盘名称";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.BindingRequestPropertyName = null;
            this.dgvList.BindingResponsePropertyName = "List";
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
            this.楼盘名称,
            this.房间名称,
            this.房间类型,
            this.状态,
            this.装修类型,
            this.备注,
            this.业主信息});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(5, 133);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1290, 379);
            this.dgvList.TabIndex = 2;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // 楼盘名称
            // 
            this.楼盘名称.DataPropertyName = "Building.Name";
            this.楼盘名称.HeaderText = "楼盘名称";
            this.楼盘名称.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.楼盘名称.Name = "楼盘名称";
            this.楼盘名称.ReadOnly = true;
            this.楼盘名称.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.楼盘名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.楼盘名称.Width = 200;
            // 
            // 房间名称
            // 
            this.房间名称.DataPropertyName = "House.Name";
            this.房间名称.HeaderText = "房间名称";
            this.房间名称.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.房间名称.Name = "房间名称";
            this.房间名称.ReadOnly = true;
            this.房间名称.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.房间名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // 房间类型
            // 
            this.房间类型.DataPropertyName = "House.HouseTypeName";
            this.房间类型.HeaderText = "房间类型";
            this.房间类型.Name = "房间类型";
            this.房间类型.ReadOnly = true;
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "House.StatusName";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            // 
            // 装修类型
            // 
            this.装修类型.DataPropertyName = "House.DecorationTypeName";
            this.装修类型.HeaderText = "装修类型";
            this.装修类型.Name = "装修类型";
            this.装修类型.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "House.Remark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            // 
            // 业主信息
            // 
            this.业主信息.DataPropertyName = "Customer.Name";
            this.业主信息.HeaderText = "业主信息";
            this.业主信息.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.业主信息.Name = "业主信息";
            this.业主信息.ReadOnly = true;
            this.业主信息.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.业主信息.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TaskHouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 517);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TaskHouseManagement";
            this.Text = "收房管理";
            this.ShownOnSync += new System.EventHandler(this.TaskHouseManagement_ShownOnSync);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.GroupBox groupBox2;
        private SOAFramework.Client.Controls.DataGridView dgvList;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.Button btnTaskHouse;
        private SOAFramework.Client.Controls.Button btnQuery;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.TextBox txbHouseName;
        private SOAFramework.Client.Controls.TextBox txbBuildingName;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.Label label5;
        private SOAFramework.Client.Controls.TextBox txbFloorEnd;
        private SOAFramework.Client.Controls.Label label6;
        private SOAFramework.Client.Controls.TextBox txbFloorStart;
        private SOAFramework.Client.Controls.ComboBox cmbStatus;
        private SOAFramework.Client.Controls.ComboBox txbDecorationType;
        private System.Windows.Forms.DataGridViewLinkColumn 楼盘名称;
        private System.Windows.Forms.DataGridViewLinkColumn 房间名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 装修类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewLinkColumn 业主信息;
    }
}