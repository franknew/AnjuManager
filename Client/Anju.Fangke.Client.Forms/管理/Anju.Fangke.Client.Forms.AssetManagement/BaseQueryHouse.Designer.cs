﻿namespace Anju.Fangke.Client.Forms
{
    partial class BaseQueryHouse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.btnQuery = new SOAFramework.Client.Controls.Button();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.cmbDecorationType = new SOAFramework.Client.Controls.ComboBox();
            this.cmbStatus = new SOAFramework.Client.Controls.ComboBox();
            this.txbFloor_End = new SOAFramework.Client.Controls.TextBox();
            this.label7 = new SOAFramework.Client.Controls.Label();
            this.txbFloor_Start = new SOAFramework.Client.Controls.TextBox();
            this.txbKeyCode = new SOAFramework.Client.Controls.TextBox();
            this.txbHouseName = new SOAFramework.Client.Controls.TextBox();
            this.txbBuildingName = new SOAFramework.Client.Controls.TextBox();
            this.label6 = new SOAFramework.Client.Controls.Label();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.dgvList = new SOAFramework.Client.Controls.DataGridView();
            this.楼盘名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房间类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.面积 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.售价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.钥匙编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.装修类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业务员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1259, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(87, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // btnQuery
            // 
            this.btnQuery.ClickedMessage = null;
            this.btnQuery.EnableSyncClick = true;
            this.btnQuery.IngoreCallbackOnce = false;
            this.btnQuery.Location = new System.Drawing.Point(6, 12);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.RequestName = "";
            this.btnQuery.Response = null;
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbDecorationType);
            this.groupBox2.Controls.Add(this.cmbStatus);
            this.groupBox2.Controls.Add(this.txbFloor_End);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbFloor_Start);
            this.groupBox2.Controls.Add(this.txbKeyCode);
            this.groupBox2.Controls.Add(this.txbHouseName);
            this.groupBox2.Controls.Add(this.txbBuildingName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1259, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询条件";
            // 
            // cmbDecorationType
            // 
            this.cmbDecorationType.BindingRequestPropertyName = "form.DecorationType";
            this.cmbDecorationType.BindingResponsePropertyName = null;
            this.cmbDecorationType.BindingSourcePropertyName = null;
            this.cmbDecorationType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbDecorationType.FormattingEnabled = true;
            this.cmbDecorationType.HasAll = true;
            this.cmbDecorationType.InitableBindingGroupName = "装修类型";
            this.cmbDecorationType.ItemHeight = 19;
            this.cmbDecorationType.Location = new System.Drawing.Point(93, 53);
            this.cmbDecorationType.Name = "cmbDecorationType";
            this.cmbDecorationType.Size = new System.Drawing.Size(188, 25);
            this.cmbDecorationType.TabIndex = 13;
            this.cmbDecorationType.UseSelectable = true;
            this.cmbDecorationType.Value = null;
            // 
            // cmbStatus
            // 
            this.cmbStatus.BindingRequestPropertyName = "form.Status";
            this.cmbStatus.BindingResponsePropertyName = null;
            this.cmbStatus.BindingSourcePropertyName = null;
            this.cmbStatus.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.HasAll = true;
            this.cmbStatus.InitableBindingGroupName = "房间状态";
            this.cmbStatus.ItemHeight = 19;
            this.cmbStatus.Location = new System.Drawing.Point(607, 17);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(188, 25);
            this.cmbStatus.TabIndex = 12;
            this.cmbStatus.UseSelectable = true;
            this.cmbStatus.Value = null;
            // 
            // txbFloor_End
            // 
            this.txbFloor_End.BindingRequestPropertyName = "form.Floor_End";
            this.txbFloor_End.BindingResponsePropertyName = null;
            this.txbFloor_End.BindingSourcePropertyName = null;
            this.txbFloor_End.EmptyToNull = true;
            this.txbFloor_End.EmptyWarning = null;
            this.txbFloor_End.Lines = new string[0];
            this.txbFloor_End.Location = new System.Drawing.Point(716, 52);
            this.txbFloor_End.MaxLength = 32767;
            this.txbFloor_End.Name = "txbFloor_End";
            this.txbFloor_End.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFloor_End.SelectedText = "";
            this.txbFloor_End.SelectionLength = 0;
            this.txbFloor_End.SelectionStart = 0;
            this.txbFloor_End.Size = new System.Drawing.Size(79, 23);
            this.txbFloor_End.TabIndex = 11;
            this.txbFloor_End.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "-";
            // 
            // txbFloor_Start
            // 
            this.txbFloor_Start.BindingRequestPropertyName = "form.Floor_Start";
            this.txbFloor_Start.BindingResponsePropertyName = null;
            this.txbFloor_Start.BindingSourcePropertyName = null;
            this.txbFloor_Start.EmptyToNull = true;
            this.txbFloor_Start.EmptyWarning = null;
            this.txbFloor_Start.Lines = new string[0];
            this.txbFloor_Start.Location = new System.Drawing.Point(607, 52);
            this.txbFloor_Start.MaxLength = 32767;
            this.txbFloor_Start.Name = "txbFloor_Start";
            this.txbFloor_Start.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFloor_Start.SelectedText = "";
            this.txbFloor_Start.SelectionLength = 0;
            this.txbFloor_Start.SelectionStart = 0;
            this.txbFloor_Start.Size = new System.Drawing.Size(79, 23);
            this.txbFloor_Start.TabIndex = 9;
            this.txbFloor_Start.UseSelectable = true;
            // 
            // txbKeyCode
            // 
            this.txbKeyCode.BindingRequestPropertyName = "form.KeyCode";
            this.txbKeyCode.BindingResponsePropertyName = null;
            this.txbKeyCode.BindingSourcePropertyName = null;
            this.txbKeyCode.EmptyToNull = true;
            this.txbKeyCode.EmptyWarning = null;
            this.txbKeyCode.Lines = new string[0];
            this.txbKeyCode.Location = new System.Drawing.Point(370, 53);
            this.txbKeyCode.MaxLength = 32767;
            this.txbKeyCode.Name = "txbKeyCode";
            this.txbKeyCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbKeyCode.SelectedText = "";
            this.txbKeyCode.SelectionLength = 0;
            this.txbKeyCode.SelectionStart = 0;
            this.txbKeyCode.Size = new System.Drawing.Size(188, 23);
            this.txbKeyCode.TabIndex = 8;
            this.txbKeyCode.UseSelectable = true;
            // 
            // txbHouseName
            // 
            this.txbHouseName.BindingRequestPropertyName = "form.Name";
            this.txbHouseName.BindingResponsePropertyName = null;
            this.txbHouseName.BindingSourcePropertyName = null;
            this.txbHouseName.EmptyToNull = true;
            this.txbHouseName.EmptyWarning = null;
            this.txbHouseName.Lines = new string[0];
            this.txbHouseName.Location = new System.Drawing.Point(370, 19);
            this.txbHouseName.MaxLength = 32767;
            this.txbHouseName.Name = "txbHouseName";
            this.txbHouseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHouseName.SelectedText = "";
            this.txbHouseName.SelectionLength = 0;
            this.txbHouseName.SelectionStart = 0;
            this.txbHouseName.Size = new System.Drawing.Size(188, 23);
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
            this.txbBuildingName.Location = new System.Drawing.Point(93, 19);
            this.txbBuildingName.MaxLength = 32767;
            this.txbBuildingName.Name = "txbBuildingName";
            this.txbBuildingName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBuildingName.SelectedText = "";
            this.txbBuildingName.SelectionLength = 0;
            this.txbBuildingName.SelectionStart = 0;
            this.txbBuildingName.Size = new System.Drawing.Size(188, 23);
            this.txbBuildingName.TabIndex = 6;
            this.txbBuildingName.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "楼层";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "钥匙编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "装修类型";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "状态";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "房号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.楼盘名称,
            this.房号,
            this.房间类型,
            this.面积,
            this.售价,
            this.钥匙编号,
            this.状态,
            this.装修类型,
            this.业务员,
            this.备注});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(5, 166);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1259, 469);
            this.dgvList.TabIndex = 2;
            // 
            // 楼盘名称
            // 
            this.楼盘名称.DataPropertyName = "Building.Name";
            this.楼盘名称.HeaderText = "楼盘名称";
            this.楼盘名称.Name = "楼盘名称";
            this.楼盘名称.ReadOnly = true;
            this.楼盘名称.Width = 150;
            // 
            // 房号
            // 
            this.房号.DataPropertyName = "House.Name";
            this.房号.HeaderText = "房号";
            this.房号.Name = "房号";
            this.房号.ReadOnly = true;
            // 
            // 房间类型
            // 
            this.房间类型.DataPropertyName = "House.HouseType";
            this.房间类型.HeaderText = "房间类型";
            this.房间类型.Name = "房间类型";
            this.房间类型.ReadOnly = true;
            // 
            // 面积
            // 
            this.面积.DataPropertyName = "House.Area";
            this.面积.HeaderText = "面积";
            this.面积.Name = "面积";
            this.面积.ReadOnly = true;
            this.面积.Width = 80;
            // 
            // 售价
            // 
            this.售价.DataPropertyName = "House.SalePrice";
            this.售价.HeaderText = "售价";
            this.售价.Name = "售价";
            this.售价.ReadOnly = true;
            this.售价.Width = 80;
            // 
            // 钥匙编号
            // 
            this.钥匙编号.DataPropertyName = "House.KeyCode";
            this.钥匙编号.HeaderText = "钥匙编号";
            this.钥匙编号.Name = "钥匙编号";
            this.钥匙编号.ReadOnly = true;
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "House.Status";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            this.状态.Width = 80;
            // 
            // 装修类型
            // 
            this.装修类型.DataPropertyName = "House.DecorationType";
            this.装修类型.HeaderText = "装修类型";
            this.装修类型.Name = "装修类型";
            this.装修类型.ReadOnly = true;
            this.装修类型.Width = 80;
            // 
            // 业务员
            // 
            this.业务员.DataPropertyName = "Owner.Name";
            this.业务员.HeaderText = "业务员";
            this.业务员.Name = "业务员";
            this.业务员.ReadOnly = true;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "House.Remark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 300;
            // 
            // BaseQueryHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 640);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DisplayHeader = false;
            this.Name = "BaseQueryHouse";
            this.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            this.Text = "BaseQueryHouse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected SOAFramework.Client.Controls.Label label1;
        protected SOAFramework.Client.Controls.GroupBox groupBox1;
        protected SOAFramework.Client.Controls.Button btnClose;
        protected SOAFramework.Client.Controls.Button btnQuery;
        protected SOAFramework.Client.Controls.GroupBox groupBox2;
        protected SOAFramework.Client.Controls.DataGridView dgvList;
        protected SOAFramework.Client.Controls.Label label3;
        protected SOAFramework.Client.Controls.Label label2;
        protected SOAFramework.Client.Controls.Label label5;
        protected SOAFramework.Client.Controls.Label label4;
        protected SOAFramework.Client.Controls.Label label6;
        protected SOAFramework.Client.Controls.ComboBox cmbDecorationType;
        protected SOAFramework.Client.Controls.ComboBox cmbStatus;
        protected SOAFramework.Client.Controls.TextBox txbFloor_End;
        protected SOAFramework.Client.Controls.Label label7;
        protected SOAFramework.Client.Controls.TextBox txbFloor_Start;
        protected SOAFramework.Client.Controls.TextBox txbKeyCode;
        protected SOAFramework.Client.Controls.TextBox txbHouseName;
        protected SOAFramework.Client.Controls.TextBox txbBuildingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn 楼盘名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房间类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 面积;
        private System.Windows.Forms.DataGridViewTextBoxColumn 售价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 钥匙编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 装修类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业务员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
    }
}