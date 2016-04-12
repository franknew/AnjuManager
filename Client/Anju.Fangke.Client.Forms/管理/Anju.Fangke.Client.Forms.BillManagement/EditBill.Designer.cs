namespace Anju.Fangke.Client.Forms
{
    partial class EditBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.txbRentFee = new SOAFramework.Client.Controls.TextBox();
            this.label7 = new SOAFramework.Client.Controls.Label();
            this.updPayed = new SOAFramework.Client.Controls.NumbericUpDown();
            this.updShouldPay = new SOAFramework.Client.Controls.NumbericUpDown();
            this.txbRentDay = new SOAFramework.Client.Controls.TextBox();
            this.txbBillName = new SOAFramework.Client.Controls.TextBox();
            this.txbHouseName = new SOAFramework.Client.Controls.TextBox();
            this.txbBuildingName = new SOAFramework.Client.Controls.TextBox();
            this.label6 = new SOAFramework.Client.Controls.Label();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.dgvList = new SOAFramework.Client.Controls.DataGridView();
            this.费用名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.费用类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上月计数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.本月计数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.费用 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.groupBox3 = new SOAFramework.Client.Controls.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updShouldPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbRentFee);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.updPayed);
            this.groupBox1.Controls.Add(this.updShouldPay);
            this.groupBox1.Controls.Add(this.txbRentDay);
            this.groupBox1.Controls.Add(this.txbBillName);
            this.groupBox1.Controls.Add(this.txbHouseName);
            this.groupBox1.Controls.Add(this.txbBuildingName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(1, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 192);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础信息";
            // 
            // txbRentFee
            // 
            this.txbRentFee.BindingRequestPropertyName = null;
            this.txbRentFee.BindingResponsePropertyName = null;
            this.txbRentFee.BindingSourcePropertyName = "Bill.RentFee";
            this.txbRentFee.EmptyWarning = null;
            this.txbRentFee.Enabled = false;
            this.txbRentFee.Lines = new string[0];
            this.txbRentFee.Location = new System.Drawing.Point(77, 108);
            this.txbRentFee.MaxLength = 32767;
            this.txbRentFee.Name = "txbRentFee";
            this.txbRentFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRentFee.SelectedText = "";
            this.txbRentFee.SelectionLength = 0;
            this.txbRentFee.Size = new System.Drawing.Size(261, 23);
            this.txbRentFee.TabIndex = 8;
            this.txbRentFee.UseSelectable = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "租金";
            // 
            // updPayed
            // 
            this.updPayed.BindingRequestPropertyName = null;
            this.updPayed.BindingResponsePropertyName = null;
            this.updPayed.BindingSourcePropertyName = "Bill.Payed";
            this.updPayed.DecimalPlaces = 2;
            this.updPayed.EmptyWarning = null;
            this.updPayed.Location = new System.Drawing.Point(415, 154);
            this.updPayed.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.updPayed.Name = "updPayed";
            this.updPayed.Size = new System.Drawing.Size(261, 21);
            this.updPayed.TabIndex = 6;
            // 
            // updShouldPay
            // 
            this.updShouldPay.BindingRequestPropertyName = null;
            this.updShouldPay.BindingResponsePropertyName = null;
            this.updShouldPay.BindingSourcePropertyName = "Bill.ShouldPay";
            this.updShouldPay.DecimalPlaces = 2;
            this.updShouldPay.EmptyWarning = null;
            this.updShouldPay.Location = new System.Drawing.Point(77, 154);
            this.updShouldPay.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.updShouldPay.Name = "updShouldPay";
            this.updShouldPay.Size = new System.Drawing.Size(261, 21);
            this.updShouldPay.TabIndex = 5;
            // 
            // txbRentDay
            // 
            this.txbRentDay.BindingRequestPropertyName = null;
            this.txbRentDay.BindingResponsePropertyName = null;
            this.txbRentDay.BindingSourcePropertyName = "Bill.RentDay";
            this.txbRentDay.EmptyWarning = null;
            this.txbRentDay.Enabled = false;
            this.txbRentDay.Lines = new string[0];
            this.txbRentDay.Location = new System.Drawing.Point(415, 63);
            this.txbRentDay.MaxLength = 32767;
            this.txbRentDay.Name = "txbRentDay";
            this.txbRentDay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRentDay.SelectedText = "";
            this.txbRentDay.SelectionLength = 0;
            this.txbRentDay.Size = new System.Drawing.Size(261, 23);
            this.txbRentDay.TabIndex = 4;
            this.txbRentDay.UseSelectable = true;
            // 
            // txbBillName
            // 
            this.txbBillName.BindingRequestPropertyName = null;
            this.txbBillName.BindingResponsePropertyName = null;
            this.txbBillName.BindingSourcePropertyName = "Bill.Name";
            this.txbBillName.EmptyWarning = null;
            this.txbBillName.Enabled = false;
            this.txbBillName.Lines = new string[0];
            this.txbBillName.Location = new System.Drawing.Point(77, 63);
            this.txbBillName.MaxLength = 32767;
            this.txbBillName.Name = "txbBillName";
            this.txbBillName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBillName.SelectedText = "";
            this.txbBillName.SelectionLength = 0;
            this.txbBillName.Size = new System.Drawing.Size(261, 23);
            this.txbBillName.TabIndex = 3;
            this.txbBillName.UseSelectable = true;
            // 
            // txbHouseName
            // 
            this.txbHouseName.BindingRequestPropertyName = null;
            this.txbHouseName.BindingResponsePropertyName = null;
            this.txbHouseName.BindingSourcePropertyName = "Bill.HouseName";
            this.txbHouseName.EmptyWarning = null;
            this.txbHouseName.Enabled = false;
            this.txbHouseName.Lines = new string[0];
            this.txbHouseName.Location = new System.Drawing.Point(415, 15);
            this.txbHouseName.MaxLength = 32767;
            this.txbHouseName.Name = "txbHouseName";
            this.txbHouseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHouseName.SelectedText = "";
            this.txbHouseName.SelectionLength = 0;
            this.txbHouseName.Size = new System.Drawing.Size(261, 23);
            this.txbHouseName.TabIndex = 2;
            this.txbHouseName.UseSelectable = true;
            // 
            // txbBuildingName
            // 
            this.txbBuildingName.BindingRequestPropertyName = null;
            this.txbBuildingName.BindingResponsePropertyName = null;
            this.txbBuildingName.BindingSourcePropertyName = "Bill.BuildingName";
            this.txbBuildingName.EmptyWarning = null;
            this.txbBuildingName.Enabled = false;
            this.txbBuildingName.Lines = new string[0];
            this.txbBuildingName.Location = new System.Drawing.Point(77, 15);
            this.txbBuildingName.MaxLength = 32767;
            this.txbBuildingName.Name = "txbBuildingName";
            this.txbBuildingName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBuildingName.SelectedText = "";
            this.txbBuildingName.SelectionLength = 0;
            this.txbBuildingName.Size = new System.Drawing.Size(261, 23);
            this.txbBuildingName.TabIndex = 1;
            this.txbBuildingName.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "本月已收";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "账单名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "本月应收";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "交租日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 17);
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
            this.label1.Text = "楼栋名称";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.BindingRequestPropertyName = null;
            this.dgvList.BindingResponsePropertyName = null;
            this.dgvList.BindingSourcePropertyName = "OtherFeeBill";
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
            this.费用名称,
            this.费用类型,
            this.上月计数,
            this.本月计数,
            this.单价,
            this.费用});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 17);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(694, 231);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellLeave);
            // 
            // 费用名称
            // 
            this.费用名称.DataPropertyName = "OtherFee.Name";
            this.费用名称.HeaderText = "费用名称";
            this.费用名称.Name = "费用名称";
            this.费用名称.ReadOnly = true;
            this.费用名称.Width = 200;
            // 
            // 费用类型
            // 
            this.费用类型.DataPropertyName = "OtherFee.FeeTypeName";
            this.费用类型.HeaderText = "费用类型";
            this.费用类型.Name = "费用类型";
            this.费用类型.ReadOnly = true;
            // 
            // 上月计数
            // 
            this.上月计数.DataPropertyName = "OtherFeeBill.StartValue";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            this.上月计数.DefaultCellStyle = dataGridViewCellStyle2;
            this.上月计数.HeaderText = "上月计数";
            this.上月计数.Name = "上月计数";
            this.上月计数.Width = 80;
            // 
            // 本月计数
            // 
            this.本月计数.DataPropertyName = "OtherFeeBill.EndValue";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.本月计数.DefaultCellStyle = dataGridViewCellStyle3;
            this.本月计数.HeaderText = "本月计数";
            this.本月计数.Name = "本月计数";
            this.本月计数.Width = 80;
            // 
            // 单价
            // 
            this.单价.DataPropertyName = "OtherFee.UnitPrice";
            this.单价.HeaderText = "单价";
            this.单价.Name = "单价";
            this.单价.ReadOnly = true;
            this.单价.Width = 80;
            // 
            // 费用
            // 
            this.费用.DataPropertyName = "OtherFeeBill.Fee";
            this.费用.HeaderText = "费用";
            this.费用.Name = "费用";
            this.费用.ReadOnly = true;
            this.费用.Width = 80;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(1, 473);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(415, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "退出";
            this.btnClose.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(252, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvList);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(1, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(700, 251);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "其他费用信息";
            // 
            // EditBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 522);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditBill";
            this.Text = "编辑账单";
            this.InitControl += new System.EventHandler(this.EditBill_InitControl);
            this.Shown += new System.EventHandler(this.EditBill_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPayed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updShouldPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.DataGridView dgvList;
        private SOAFramework.Client.Controls.GroupBox groupBox2;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.GroupBox groupBox3;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label5;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.NumbericUpDown updShouldPay;
        private SOAFramework.Client.Controls.TextBox txbRentDay;
        private SOAFramework.Client.Controls.TextBox txbBillName;
        private SOAFramework.Client.Controls.TextBox txbHouseName;
        private SOAFramework.Client.Controls.TextBox txbBuildingName;
        private SOAFramework.Client.Controls.Label label6;
        private SOAFramework.Client.Controls.NumbericUpDown updPayed;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.Button btnSave;
        private SOAFramework.Client.Controls.TextBox txbRentFee;
        private SOAFramework.Client.Controls.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 费用名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 费用类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上月计数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 本月计数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewTextBoxColumn 费用;
    }
}