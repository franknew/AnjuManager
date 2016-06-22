namespace Anju.Fangke.Client.Forms
{
    partial class FollowupManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.btnQuery = new SOAFramework.Client.Controls.Button();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.label6 = new SOAFramework.Client.Controls.Label();
            this.dtCreateTime_End = new SOAFramework.Client.Controls.DateTimeComboPicker();
            this.dtCreateTime_Start = new SOAFramework.Client.Controls.DateTimeComboPicker();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.txbCustomer = new SOAFramework.Client.Controls.TextBox();
            this.txbCreator = new SOAFramework.Client.Controls.TextBox();
            this.txbHouse = new SOAFramework.Client.Controls.TextBox();
            this.txbBuilding = new SOAFramework.Client.Controls.TextBox();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.dgvList = new SOAFramework.Client.Controls.DataGridView();
            this.楼盘名称 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.房间名称 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.跟进信息 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.业务员 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主信息 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.pager1 = new SOAFramework.Client.Controls.Pager.Pager();
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
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1290, 40);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(87, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "退出";
            this.btnClose.UseSelectable = true;
            // 
            // btnQuery
            // 
            this.btnQuery.ClickedMessage = null;
            this.btnQuery.IngoreCallbackOnce = false;
            this.btnQuery.Location = new System.Drawing.Point(6, 11);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.RequestName = "QueryFullFollowupRequest";
            this.btnQuery.Response = null;
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            this.btnQuery.InitClick += new System.EventHandler(this.btnQuery_InitClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtCreateTime_End);
            this.groupBox2.Controls.Add(this.dtCreateTime_Start);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbCustomer);
            this.groupBox2.Controls.Add(this.txbCreator);
            this.groupBox2.Controls.Add(this.txbHouse);
            this.groupBox2.Controls.Add(this.txbBuilding);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1290, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "-";
            // 
            // dtCreateTime_End
            // 
            this.dtCreateTime_End.BindingRequestPropertyName = "form.CreateTime_End";
            this.dtCreateTime_End.BindingResponsePropertyName = null;
            this.dtCreateTime_End.BindingSourcePropertyName = null;
            this.dtCreateTime_End.CollectFormat = "yyyy-MM-dd 23:59:59";
            this.dtCreateTime_End.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtCreateTime_End.Location = new System.Drawing.Point(540, 50);
            this.dtCreateTime_End.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtCreateTime_End.Name = "dtCreateTime_End";
            this.dtCreateTime_End.Size = new System.Drawing.Size(161, 25);
            this.dtCreateTime_End.TabIndex = 10;
            // 
            // dtCreateTime_Start
            // 
            this.dtCreateTime_Start.BindingRequestPropertyName = "form.CreateTime_Start";
            this.dtCreateTime_Start.BindingResponsePropertyName = null;
            this.dtCreateTime_Start.BindingSourcePropertyName = null;
            this.dtCreateTime_Start.CollectFormat = "yyyy-MM-dd 00:00:00";
            this.dtCreateTime_Start.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtCreateTime_Start.Location = new System.Drawing.Point(316, 50);
            this.dtCreateTime_Start.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtCreateTime_Start.Name = "dtCreateTime_Start";
            this.dtCreateTime_Start.Size = new System.Drawing.Size(161, 25);
            this.dtCreateTime_Start.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "操作时间";
            // 
            // txbCustomer
            // 
            this.txbCustomer.BindingRequestPropertyName = "form.OwnerName";
            this.txbCustomer.BindingResponsePropertyName = null;
            this.txbCustomer.BindingSourcePropertyName = null;
            this.txbCustomer.EmptyToNull = true;
            this.txbCustomer.EmptyWarning = null;
            this.txbCustomer.Lines = new string[0];
            this.txbCustomer.Location = new System.Drawing.Point(78, 54);
            this.txbCustomer.MaxLength = 32767;
            this.txbCustomer.Name = "txbCustomer";
            this.txbCustomer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCustomer.SelectedText = "";
            this.txbCustomer.SelectionLength = 0;
            this.txbCustomer.SelectionStart = 0;
            this.txbCustomer.Size = new System.Drawing.Size(161, 23);
            this.txbCustomer.TabIndex = 7;
            this.txbCustomer.UseSelectable = true;
            // 
            // txbCreator
            // 
            this.txbCreator.BindingRequestPropertyName = "form.CreatorName";
            this.txbCreator.BindingResponsePropertyName = null;
            this.txbCreator.BindingSourcePropertyName = null;
            this.txbCreator.EmptyToNull = true;
            this.txbCreator.EmptyWarning = null;
            this.txbCreator.Lines = new string[0];
            this.txbCreator.Location = new System.Drawing.Point(540, 21);
            this.txbCreator.MaxLength = 32767;
            this.txbCreator.Name = "txbCreator";
            this.txbCreator.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCreator.SelectedText = "";
            this.txbCreator.SelectionLength = 0;
            this.txbCreator.SelectionStart = 0;
            this.txbCreator.Size = new System.Drawing.Size(161, 23);
            this.txbCreator.TabIndex = 6;
            this.txbCreator.UseSelectable = true;
            // 
            // txbHouse
            // 
            this.txbHouse.BindingRequestPropertyName = "form.HouseName";
            this.txbHouse.BindingResponsePropertyName = null;
            this.txbHouse.BindingSourcePropertyName = null;
            this.txbHouse.EmptyToNull = true;
            this.txbHouse.EmptyWarning = null;
            this.txbHouse.Lines = new string[0];
            this.txbHouse.Location = new System.Drawing.Point(316, 21);
            this.txbHouse.MaxLength = 32767;
            this.txbHouse.Name = "txbHouse";
            this.txbHouse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHouse.SelectedText = "";
            this.txbHouse.SelectionLength = 0;
            this.txbHouse.SelectionStart = 0;
            this.txbHouse.Size = new System.Drawing.Size(161, 23);
            this.txbHouse.TabIndex = 5;
            this.txbHouse.UseSelectable = true;
            // 
            // txbBuilding
            // 
            this.txbBuilding.BindingRequestPropertyName = "form.BuildingName";
            this.txbBuilding.BindingResponsePropertyName = null;
            this.txbBuilding.BindingSourcePropertyName = null;
            this.txbBuilding.EmptyToNull = true;
            this.txbBuilding.EmptyWarning = null;
            this.txbBuilding.Lines = new string[0];
            this.txbBuilding.Location = new System.Drawing.Point(78, 21);
            this.txbBuilding.MaxLength = 32767;
            this.txbBuilding.Name = "txbBuilding";
            this.txbBuilding.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBuilding.SelectedText = "";
            this.txbBuilding.SelectionLength = 0;
            this.txbBuilding.SelectionStart = 0;
            this.txbBuilding.Size = new System.Drawing.Size(161, 23);
            this.txbBuilding.TabIndex = 4;
            this.txbBuilding.UseSelectable = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "业主名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(483, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "业务员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "房间名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "楼盘名称";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToOrderColumns = true;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvList.BindingRequestPropertyName = null;
            this.dgvList.BindingResponsePropertyName = "Data.Record";
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
            this.房间名称,
            this.跟进信息,
            this.业务员,
            this.操作日期,
            this.业主信息});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(5, 140);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1290, 348);
            this.dgvList.TabIndex = 2;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            // 
            // 楼盘名称
            // 
            this.楼盘名称.DataPropertyName = "Building.Name";
            this.楼盘名称.HeaderText = "楼盘名称";
            this.楼盘名称.Name = "楼盘名称";
            this.楼盘名称.ReadOnly = true;
            this.楼盘名称.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.楼盘名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.楼盘名称.Width = 150;
            // 
            // 房间名称
            // 
            this.房间名称.DataPropertyName = "House.Name";
            this.房间名称.HeaderText = "房间名称";
            this.房间名称.Name = "房间名称";
            this.房间名称.ReadOnly = true;
            this.房间名称.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.房间名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.房间名称.Width = 120;
            // 
            // 跟进信息
            // 
            this.跟进信息.DataPropertyName = "Followup.Remark";
            this.跟进信息.HeaderText = "跟进信息";
            this.跟进信息.Name = "跟进信息";
            this.跟进信息.ReadOnly = true;
            this.跟进信息.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.跟进信息.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.跟进信息.Width = 300;
            // 
            // 业务员
            // 
            this.业务员.DataPropertyName = "User.CnName";
            this.业务员.HeaderText = "业务员";
            this.业务员.Name = "业务员";
            this.业务员.ReadOnly = true;
            // 
            // 操作日期
            // 
            this.操作日期.DataPropertyName = "Followup.CreateTime";
            dataGridViewCellStyle4.Format = "yyyy-MM-dd";
            this.操作日期.DefaultCellStyle = dataGridViewCellStyle4;
            this.操作日期.HeaderText = "操作日期";
            this.操作日期.Name = "操作日期";
            this.操作日期.ReadOnly = true;
            this.操作日期.Width = 120;
            // 
            // 业主信息
            // 
            this.业主信息.DataPropertyName = "Owner.Name";
            this.业主信息.HeaderText = "业主信息";
            this.业主信息.Name = "业主信息";
            this.业主信息.ReadOnly = true;
            this.业主信息.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.业主信息.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // pager1
            // 
            this.pager1.BindingRequestPropertyName = null;
            this.pager1.BindingResponsePropertyName = "Data.RecordCount";
            this.pager1.CurrentPageIndex = 1;
            this.pager1.CurrentPageIndexBindingRequestPropertyName = "form.CurrentIndex";
            this.pager1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pager1.Location = new System.Drawing.Point(5, 488);
            this.pager1.Name = "pager1";
            this.pager1.PageSizeBindingRequestPropertyName = "form.PageSize";
            this.pager1.RecordCount = 0;
            this.pager1.Size = new System.Drawing.Size(1290, 24);
            this.pager1.TabIndex = 3;
            // 
            // FollowupManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 517);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pager1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FollowupManagement";
            this.Text = "客户跟进管理";
            this.ShownOnSync += new System.EventHandler(this.FollowupManagement_ShownOnSync);
            this.Shown += new System.EventHandler(this.FollowupManagement_Shown);
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
        private SOAFramework.Client.Controls.Button btnQuery;
        private SOAFramework.Client.Controls.TextBox txbCustomer;
        private SOAFramework.Client.Controls.TextBox txbCreator;
        private SOAFramework.Client.Controls.TextBox txbHouse;
        private SOAFramework.Client.Controls.TextBox txbBuilding;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.Pager.Pager pager1;
        private System.Windows.Forms.DataGridViewLinkColumn 楼盘名称;
        private System.Windows.Forms.DataGridViewLinkColumn 房间名称;
        private System.Windows.Forms.DataGridViewLinkColumn 跟进信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn 业务员;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作日期;
        private System.Windows.Forms.DataGridViewLinkColumn 业主信息;
        private SOAFramework.Client.Controls.Label label6;
        private SOAFramework.Client.Controls.DateTimeComboPicker dtCreateTime_End;
        private SOAFramework.Client.Controls.DateTimeComboPicker dtCreateTime_Start;
        private SOAFramework.Client.Controls.Label label5;
    }
}