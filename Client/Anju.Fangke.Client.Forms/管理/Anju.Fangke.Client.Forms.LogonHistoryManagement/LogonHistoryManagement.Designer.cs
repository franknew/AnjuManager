namespace Anju.Fangke.Client.Forms
{
    partial class LogonHistoryManagement
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
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.btnQuery = new SOAFramework.Client.Controls.Button();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.chkActiveTime = new SOAFramework.Client.Controls.CheckBox();
            this.chkLogonTime = new SOAFramework.Client.Controls.CheckBox();
            this.dtActiveTime_End = new SOAFramework.Client.Controls.DateTimeComboPicker();
            this.dtActiveTime_Start = new SOAFramework.Client.Controls.DateTimeComboPicker();
            this.dtLogonTime_End = new SOAFramework.Client.Controls.DateTimeComboPicker();
            this.dtLogonTime_Start = new SOAFramework.Client.Controls.DateTimeComboPicker();
            this.txbUserName = new SOAFramework.Client.Controls.TextBox();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.pager = new SOAFramework.Client.Controls.Pager.Pager();
            this.dgvList = new SOAFramework.Client.Controls.DataGridView();
            this.用户名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.登录时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.活动时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Size = new System.Drawing.Size(1290, 45);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(84, 14);
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
            this.btnQuery.Location = new System.Drawing.Point(3, 14);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.RequestName = "";
            this.btnQuery.Response = null;
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseSelectable = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkActiveTime);
            this.groupBox2.Controls.Add(this.chkLogonTime);
            this.groupBox2.Controls.Add(this.dtActiveTime_End);
            this.groupBox2.Controls.Add(this.dtActiveTime_Start);
            this.groupBox2.Controls.Add(this.dtLogonTime_End);
            this.groupBox2.Controls.Add(this.dtLogonTime_Start);
            this.groupBox2.Controls.Add(this.txbUserName);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1290, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // chkActiveTime
            // 
            this.chkActiveTime.AutoSize = true;
            this.chkActiveTime.BindingChecked = 0;
            this.chkActiveTime.BindingRequestPropertyName = null;
            this.chkActiveTime.BindingResponsePropertyName = null;
            this.chkActiveTime.BindingSourcePropertyName = null;
            this.chkActiveTime.Group = null;
            this.chkActiveTime.Location = new System.Drawing.Point(249, 59);
            this.chkActiveTime.Name = "chkActiveTime";
            this.chkActiveTime.Size = new System.Drawing.Size(71, 15);
            this.chkActiveTime.TabIndex = 11;
            this.chkActiveTime.Text = "启用时间";
            this.chkActiveTime.UseSelectable = true;
            this.chkActiveTime.CheckedChanged += new System.EventHandler(this.chkActiveTime_CheckedChanged);
            // 
            // chkLogonTime
            // 
            this.chkLogonTime.AutoSize = true;
            this.chkLogonTime.BindingChecked = 0;
            this.chkLogonTime.BindingRequestPropertyName = null;
            this.chkLogonTime.BindingResponsePropertyName = null;
            this.chkLogonTime.BindingSourcePropertyName = null;
            this.chkLogonTime.Group = null;
            this.chkLogonTime.Location = new System.Drawing.Point(249, 26);
            this.chkLogonTime.Name = "chkLogonTime";
            this.chkLogonTime.Size = new System.Drawing.Size(71, 15);
            this.chkLogonTime.TabIndex = 10;
            this.chkLogonTime.Text = "启用时间";
            this.chkLogonTime.UseSelectable = true;
            this.chkLogonTime.CheckedChanged += new System.EventHandler(this.chkLogonTime_CheckedChanged);
            // 
            // dtActiveTime_End
            // 
            this.dtActiveTime_End.BindingRequestPropertyName = null;
            this.dtActiveTime_End.BindingResponsePropertyName = null;
            this.dtActiveTime_End.BindingSourcePropertyName = null;
            this.dtActiveTime_End.CollectFormat = "yyyy-MM-dd 23:59:59";
            this.dtActiveTime_End.Enabled = false;
            this.dtActiveTime_End.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtActiveTime_End.Location = new System.Drawing.Point(575, 49);
            this.dtActiveTime_End.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtActiveTime_End.Name = "dtActiveTime_End";
            this.dtActiveTime_End.Size = new System.Drawing.Size(151, 25);
            this.dtActiveTime_End.TabIndex = 9;
            // 
            // dtActiveTime_Start
            // 
            this.dtActiveTime_Start.BindingRequestPropertyName = null;
            this.dtActiveTime_Start.BindingResponsePropertyName = null;
            this.dtActiveTime_Start.BindingSourcePropertyName = null;
            this.dtActiveTime_Start.CollectFormat = "yyyy-MM-dd 00:00:00";
            this.dtActiveTime_Start.Enabled = false;
            this.dtActiveTime_Start.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtActiveTime_Start.Location = new System.Drawing.Point(397, 49);
            this.dtActiveTime_Start.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtActiveTime_Start.Name = "dtActiveTime_Start";
            this.dtActiveTime_Start.Size = new System.Drawing.Size(151, 25);
            this.dtActiveTime_Start.TabIndex = 8;
            // 
            // dtLogonTime_End
            // 
            this.dtLogonTime_End.BindingRequestPropertyName = null;
            this.dtLogonTime_End.BindingResponsePropertyName = null;
            this.dtLogonTime_End.BindingSourcePropertyName = null;
            this.dtLogonTime_End.CollectFormat = "yyyy-MM-dd 23:59:59";
            this.dtLogonTime_End.Enabled = false;
            this.dtLogonTime_End.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtLogonTime_End.Location = new System.Drawing.Point(575, 18);
            this.dtLogonTime_End.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtLogonTime_End.Name = "dtLogonTime_End";
            this.dtLogonTime_End.Size = new System.Drawing.Size(151, 25);
            this.dtLogonTime_End.TabIndex = 7;
            // 
            // dtLogonTime_Start
            // 
            this.dtLogonTime_Start.BindingRequestPropertyName = null;
            this.dtLogonTime_Start.BindingResponsePropertyName = null;
            this.dtLogonTime_Start.BindingSourcePropertyName = null;
            this.dtLogonTime_Start.CollectFormat = "yyyy-MM-dd 00:00:00";
            this.dtLogonTime_Start.Enabled = false;
            this.dtLogonTime_Start.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtLogonTime_Start.Location = new System.Drawing.Point(397, 18);
            this.dtLogonTime_Start.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtLogonTime_Start.Name = "dtLogonTime_Start";
            this.dtLogonTime_Start.Size = new System.Drawing.Size(151, 25);
            this.dtLogonTime_Start.TabIndex = 6;
            // 
            // txbUserName
            // 
            this.txbUserName.BindingRequestPropertyName = null;
            this.txbUserName.BindingResponsePropertyName = null;
            this.txbUserName.BindingSourcePropertyName = null;
            this.txbUserName.EmptyToNull = true;
            this.txbUserName.EmptyWarning = null;
            this.txbUserName.Lines = new string[0];
            this.txbUserName.Location = new System.Drawing.Point(79, 18);
            this.txbUserName.MaxLength = 32767;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUserName.SelectedText = "";
            this.txbUserName.SelectionLength = 0;
            this.txbUserName.SelectionStart = 0;
            this.txbUserName.Size = new System.Drawing.Size(151, 23);
            this.txbUserName.TabIndex = 5;
            this.txbUserName.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(554, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "活动时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(554, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "登录时间";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // pager
            // 
            this.pager.BindingRequestPropertyName = null;
            this.pager.BindingResponsePropertyName = "Data.RecordCount";
            this.pager.CurrentPageIndex = 1;
            this.pager.CurrentPageIndexBindingRequestPropertyName = "form.CurrentIndex";
            this.pager.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pager.Location = new System.Drawing.Point(5, 493);
            this.pager.Name = "pager";
            this.pager.PageSizeBindingRequestPropertyName = "form.PageSize";
            this.pager.RecordCount = 0;
            this.pager.Size = new System.Drawing.Size(1290, 19);
            this.pager.TabIndex = 2;
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
            this.用户名称,
            this.登录时间,
            this.活动时间});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(5, 146);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(1290, 347);
            this.dgvList.TabIndex = 3;
            // 
            // 用户名称
            // 
            this.用户名称.DataPropertyName = "UserName";
            this.用户名称.HeaderText = "用户名称";
            this.用户名称.Name = "用户名称";
            this.用户名称.ReadOnly = true;
            this.用户名称.Width = 120;
            // 
            // 登录时间
            // 
            this.登录时间.DataPropertyName = "LogonTime";
            dataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss";
            this.登录时间.DefaultCellStyle = dataGridViewCellStyle2;
            this.登录时间.HeaderText = "登录时间";
            this.登录时间.Name = "登录时间";
            this.登录时间.ReadOnly = true;
            this.登录时间.Width = 150;
            // 
            // 活动时间
            // 
            this.活动时间.DataPropertyName = "ActiveTime";
            dataGridViewCellStyle3.Format = "yyyy-MM-dd HH:mm:ss";
            this.活动时间.DefaultCellStyle = dataGridViewCellStyle3;
            this.活动时间.HeaderText = "活动时间";
            this.活动时间.Name = "活动时间";
            this.活动时间.ReadOnly = true;
            this.活动时间.Width = 150;
            // 
            // LogonHistoryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 517);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.pager);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogonHistoryManagement";
            this.Text = "考勤管理";
            this.Shown += new System.EventHandler(this.LogonHistoryManagement_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.GroupBox groupBox2;
        private SOAFramework.Client.Controls.Pager.Pager pager;
        private SOAFramework.Client.Controls.DataGridView dgvList;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.Button btnQuery;
        private SOAFramework.Client.Controls.TextBox txbUserName;
        private SOAFramework.Client.Controls.Label label5;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.DateTimeComboPicker dtActiveTime_End;
        private SOAFramework.Client.Controls.DateTimeComboPicker dtActiveTime_Start;
        private SOAFramework.Client.Controls.DateTimeComboPicker dtLogonTime_End;
        private SOAFramework.Client.Controls.DateTimeComboPicker dtLogonTime_Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn 用户名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 登录时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 活动时间;
        private SOAFramework.Client.Controls.CheckBox chkActiveTime;
        private SOAFramework.Client.Controls.CheckBox chkLogonTime;
    }
}