﻿namespace Anju.Fangke.Client.Forms
{
    partial class BaseEditHouse
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
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.chkIsOurs = new SOAFramework.Client.Controls.CheckBox();
            this.cmbBuilding = new SOAFramework.Client.Controls.ComboBox();
            this.cmbDecorationType = new SOAFramework.Client.Controls.ComboBox();
            this.label13 = new SOAFramework.Client.Controls.Label();
            this.cmbStatus = new SOAFramework.Client.Controls.ComboBox();
            this.label10 = new SOAFramework.Client.Controls.Label();
            this.numCost = new SOAFramework.Client.Controls.NumbericUpDown();
            this.label17 = new SOAFramework.Client.Controls.Label();
            this.txbArea = new SOAFramework.Client.Controls.TextBox();
            this.label14 = new SOAFramework.Client.Controls.Label();
            this.txbFloor = new SOAFramework.Client.Controls.TextBox();
            this.txbRemark = new SOAFramework.Client.Controls.TextBox();
            this.txbHouseName = new SOAFramework.Client.Controls.TextBox();
            this.cmbToilet = new SOAFramework.Client.Controls.ComboBox();
            this.cmbHall = new SOAFramework.Client.Controls.ComboBox();
            this.cmbRoom = new SOAFramework.Client.Controls.ComboBox();
            this.label8 = new SOAFramework.Client.Controls.Label();
            this.label7 = new SOAFramework.Client.Controls.Label();
            this.label6 = new SOAFramework.Client.Controls.Label();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.groupBox3 = new SOAFramework.Client.Controls.GroupBox();
            this.btnAddCustomer = new SOAFramework.Client.Controls.Button();
            this.txbMobile = new SOAFramework.Client.Controls.TextBox();
            this.cmbCustomer = new SOAFramework.Client.Controls.ComboBox();
            this.label12 = new SOAFramework.Client.Controls.Label();
            this.label11 = new SOAFramework.Client.Controls.Label();
            this.panel1 = new SOAFramework.Client.Controls.Panel();
            this.groupBox4 = new SOAFramework.Client.Controls.GroupBox();
            this.dgvFollowup = new SOAFramework.Client.Controls.DataGridView();
            this.跟进信息 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.跟进人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new SOAFramework.Client.Controls.Panel();
            this.btnAddFollowup = new SOAFramework.Client.Controls.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowup)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(1, 433);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(918, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(232, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIsOurs);
            this.groupBox1.Controls.Add(this.cmbBuilding);
            this.groupBox1.Controls.Add(this.cmbDecorationType);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numCost);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txbArea);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txbFloor);
            this.groupBox1.Controls.Add(this.txbRemark);
            this.groupBox1.Controls.Add(this.txbHouseName);
            this.groupBox1.Controls.Add(this.cmbToilet);
            this.groupBox1.Controls.Add(this.cmbHall);
            this.groupBox1.Controls.Add(this.cmbRoom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 307);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房间信息";
            // 
            // chkIsOurs
            // 
            this.chkIsOurs.AutoSize = true;
            this.chkIsOurs.BindingChecked = 0;
            this.chkIsOurs.BindingRequestPropertyName = null;
            this.chkIsOurs.BindingResponsePropertyName = null;
            this.chkIsOurs.BindingSourcePropertyName = "House.IsOurs";
            this.chkIsOurs.Group = null;
            this.chkIsOurs.Location = new System.Drawing.Point(244, 191);
            this.chkIsOurs.Name = "chkIsOurs";
            this.chkIsOurs.Size = new System.Drawing.Size(59, 15);
            this.chkIsOurs.TabIndex = 26;
            this.chkIsOurs.Text = "已承包";
            this.chkIsOurs.UseSelectable = true;
            // 
            // cmbBuilding
            // 
            this.cmbBuilding.BindingRequestPropertyName = null;
            this.cmbBuilding.BindingResponsePropertyName = null;
            this.cmbBuilding.BindingSourcePropertyName = "House.BuildingID";
            this.cmbBuilding.DisplayMember = "Name";
            this.cmbBuilding.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbBuilding.FormattingEnabled = true;
            this.cmbBuilding.InitableBindingGroupName = null;
            this.cmbBuilding.ItemHeight = 19;
            this.cmbBuilding.Location = new System.Drawing.Point(87, 28);
            this.cmbBuilding.Name = "cmbBuilding";
            this.cmbBuilding.Size = new System.Drawing.Size(264, 25);
            this.cmbBuilding.TabIndex = 25;
            this.cmbBuilding.UseSelectable = true;
            this.cmbBuilding.Value = null;
            this.cmbBuilding.ValueMember = "ID";
            // 
            // cmbDecorationType
            // 
            this.cmbDecorationType.BindingRequestPropertyName = null;
            this.cmbDecorationType.BindingResponsePropertyName = null;
            this.cmbDecorationType.BindingSourcePropertyName = "House.DecorationType";
            this.cmbDecorationType.DisplayMember = "Name";
            this.cmbDecorationType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbDecorationType.FormattingEnabled = true;
            this.cmbDecorationType.InitableBindingGroupName = "装修类型";
            this.cmbDecorationType.ItemHeight = 19;
            this.cmbDecorationType.Location = new System.Drawing.Point(86, 185);
            this.cmbDecorationType.Name = "cmbDecorationType";
            this.cmbDecorationType.Size = new System.Drawing.Size(110, 25);
            this.cmbDecorationType.TabIndex = 24;
            this.cmbDecorationType.UseSelectable = true;
            this.cmbDecorationType.Value = null;
            this.cmbDecorationType.ValueMember = "Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 19);
            this.label13.TabIndex = 23;
            this.label13.Text = "装修类型";
            // 
            // cmbStatus
            // 
            this.cmbStatus.BindingRequestPropertyName = null;
            this.cmbStatus.BindingResponsePropertyName = null;
            this.cmbStatus.BindingSourcePropertyName = "House.Status";
            this.cmbStatus.DisplayMember = "Name";
            this.cmbStatus.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.InitableBindingGroupName = "房间状态";
            this.cmbStatus.ItemHeight = 19;
            this.cmbStatus.Location = new System.Drawing.Point(244, 57);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(107, 25);
            this.cmbStatus.TabIndex = 22;
            this.cmbStatus.UseSelectable = true;
            this.cmbStatus.Value = null;
            this.cmbStatus.ValueMember = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(202, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "状态";
            // 
            // numCost
            // 
            this.numCost.BindingRequestPropertyName = null;
            this.numCost.BindingResponsePropertyName = null;
            this.numCost.BindingSourcePropertyName = "House.SalePrice";
            this.numCost.DecimalPlaces = 2;
            this.numCost.EmptyWarning = null;
            this.numCost.Location = new System.Drawing.Point(244, 157);
            this.numCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(107, 21);
            this.numCost.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(202, 157);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 19);
            this.label17.TabIndex = 17;
            this.label17.Text = "售价";
            // 
            // txbArea
            // 
            this.txbArea.BindingRequestPropertyName = null;
            this.txbArea.BindingResponsePropertyName = null;
            this.txbArea.BindingSourcePropertyName = "House.Area";
            this.txbArea.EmptyWarning = null;
            this.txbArea.InputType = SOAFramework.Client.Controls.InputType.小数;
            this.txbArea.Lines = new string[] {
        "0"};
            this.txbArea.Location = new System.Drawing.Point(86, 157);
            this.txbArea.MaxLength = 32767;
            this.txbArea.Name = "txbArea";
            this.txbArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbArea.SelectedText = "";
            this.txbArea.SelectionLength = 0;
            this.txbArea.SelectionStart = 0;
            this.txbArea.Size = new System.Drawing.Size(110, 23);
            this.txbArea.TabIndex = 16;
            this.txbArea.Text = "0";
            this.txbArea.UseSelectable = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 157);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "房间面积";
            // 
            // txbFloor
            // 
            this.txbFloor.BindingRequestPropertyName = null;
            this.txbFloor.BindingResponsePropertyName = null;
            this.txbFloor.BindingSourcePropertyName = "House.Floor";
            this.txbFloor.EmptyWarning = null;
            this.txbFloor.InputType = SOAFramework.Client.Controls.InputType.整数;
            this.txbFloor.Lines = new string[] {
        "1"};
            this.txbFloor.Location = new System.Drawing.Point(88, 59);
            this.txbFloor.MaxLength = 32767;
            this.txbFloor.Name = "txbFloor";
            this.txbFloor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFloor.SelectedText = "";
            this.txbFloor.SelectionLength = 0;
            this.txbFloor.SelectionStart = 0;
            this.txbFloor.Size = new System.Drawing.Size(108, 23);
            this.txbFloor.TabIndex = 14;
            this.txbFloor.Text = "1";
            this.txbFloor.UseSelectable = true;
            // 
            // txbRemark
            // 
            this.txbRemark.BindingRequestPropertyName = null;
            this.txbRemark.BindingResponsePropertyName = null;
            this.txbRemark.BindingSourcePropertyName = "House.Remark";
            this.txbRemark.EmptyWarning = null;
            this.txbRemark.Lines = new string[0];
            this.txbRemark.Location = new System.Drawing.Point(87, 214);
            this.txbRemark.MaxLength = 32767;
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRemark.SelectedText = "";
            this.txbRemark.SelectionLength = 0;
            this.txbRemark.SelectionStart = 0;
            this.txbRemark.Size = new System.Drawing.Size(264, 83);
            this.txbRemark.TabIndex = 7;
            this.txbRemark.UseSelectable = true;
            // 
            // txbHouseName
            // 
            this.txbHouseName.BindingRequestPropertyName = null;
            this.txbHouseName.BindingResponsePropertyName = null;
            this.txbHouseName.BindingSourcePropertyName = "House.Name";
            this.txbHouseName.EmptyWarning = null;
            this.txbHouseName.Lines = new string[0];
            this.txbHouseName.Location = new System.Drawing.Point(87, 89);
            this.txbHouseName.MaxLength = 32767;
            this.txbHouseName.Name = "txbHouseName";
            this.txbHouseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHouseName.SelectedText = "";
            this.txbHouseName.SelectionLength = 0;
            this.txbHouseName.SelectionStart = 0;
            this.txbHouseName.Size = new System.Drawing.Size(264, 23);
            this.txbHouseName.TabIndex = 1;
            this.txbHouseName.UseSelectable = true;
            // 
            // cmbToilet
            // 
            this.cmbToilet.BindingRequestPropertyName = null;
            this.cmbToilet.BindingResponsePropertyName = null;
            this.cmbToilet.BindingSelfPropertyName = "SelectedItem";
            this.cmbToilet.BindingSourcePropertyName = "House.ToiletCount";
            this.cmbToilet.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbToilet.FormattingEnabled = true;
            this.cmbToilet.InitableBindingGroupName = null;
            this.cmbToilet.ItemHeight = 19;
            this.cmbToilet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbToilet.Location = new System.Drawing.Point(257, 121);
            this.cmbToilet.Name = "cmbToilet";
            this.cmbToilet.Size = new System.Drawing.Size(52, 25);
            this.cmbToilet.TabIndex = 4;
            this.cmbToilet.UseSelectable = true;
            this.cmbToilet.Value = null;
            // 
            // cmbHall
            // 
            this.cmbHall.BindingRequestPropertyName = null;
            this.cmbHall.BindingResponsePropertyName = null;
            this.cmbHall.BindingSelfPropertyName = "SelectedItem";
            this.cmbHall.BindingSourcePropertyName = "House.HallCount";
            this.cmbHall.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.InitableBindingGroupName = null;
            this.cmbHall.ItemHeight = 19;
            this.cmbHall.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbHall.Location = new System.Drawing.Point(174, 121);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(52, 25);
            this.cmbHall.TabIndex = 3;
            this.cmbHall.UseSelectable = true;
            this.cmbHall.Value = null;
            // 
            // cmbRoom
            // 
            this.cmbRoom.BindingRequestPropertyName = null;
            this.cmbRoom.BindingResponsePropertyName = null;
            this.cmbRoom.BindingSelfPropertyName = "SelectedItem";
            this.cmbRoom.BindingSourcePropertyName = "House.RoomCount";
            this.cmbRoom.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.InitableBindingGroupName = null;
            this.cmbRoom.ItemHeight = 19;
            this.cmbRoom.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbRoom.Location = new System.Drawing.Point(86, 121);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(52, 25);
            this.cmbRoom.TabIndex = 2;
            this.cmbRoom.UseSelectable = true;
            this.cmbRoom.Value = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "卫";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "厅";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "室";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "房间类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "楼盘名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "房间名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "备注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "所属层";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddCustomer);
            this.groupBox3.Controls.Add(this.txbMobile);
            this.groupBox3.Controls.Add(this.cmbCustomer);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 96);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "业主信息";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ClickedMessage = null;
            this.btnAddCustomer.IngoreCallbackOnce = false;
            this.btnAddCustomer.Location = new System.Drawing.Point(317, 27);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Response = null;
            this.btnAddCustomer.Size = new System.Drawing.Size(34, 25);
            this.btnAddCustomer.TabIndex = 22;
            this.btnAddCustomer.Text = "+";
            this.btnAddCustomer.UseSelectable = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // txbMobile
            // 
            this.txbMobile.BindingRequestPropertyName = null;
            this.txbMobile.BindingResponsePropertyName = null;
            this.txbMobile.BindingSourcePropertyName = "Customer.Mobile";
            this.txbMobile.EmptyWarning = null;
            this.txbMobile.Lines = new string[0];
            this.txbMobile.Location = new System.Drawing.Point(88, 62);
            this.txbMobile.MaxLength = 32767;
            this.txbMobile.Name = "txbMobile";
            this.txbMobile.ReadOnly = true;
            this.txbMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMobile.SelectedText = "";
            this.txbMobile.SelectionLength = 0;
            this.txbMobile.SelectionStart = 0;
            this.txbMobile.Size = new System.Drawing.Size(263, 23);
            this.txbMobile.TabIndex = 21;
            this.txbMobile.UseSelectable = true;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.BindingRequestPropertyName = "Customer.ID";
            this.cmbCustomer.BindingResponsePropertyName = null;
            this.cmbCustomer.BindingSourcePropertyName = "Customer.ID";
            this.cmbCustomer.DisplayMember = "Name";
            this.cmbCustomer.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.InitableBindingGroupName = null;
            this.cmbCustomer.ItemHeight = 19;
            this.cmbCustomer.Location = new System.Drawing.Point(88, 27);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(223, 25);
            this.cmbCustomer.TabIndex = 4;
            this.cmbCustomer.UseSelectable = true;
            this.cmbCustomer.Value = null;
            this.cmbCustomer.ValueMember = "ID";
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "手机";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "名称";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 403);
            this.panel1.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvFollowup);
            this.groupBox4.Controls.Add(this.panel2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(368, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(551, 403);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "跟进信息";
            // 
            // dgvFollowup
            // 
            this.dgvFollowup.AllowUserToAddRows = false;
            this.dgvFollowup.AllowUserToDeleteRows = false;
            this.dgvFollowup.AutoGenerateColumns = false;
            this.dgvFollowup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFollowup.BindingRequestPropertyName = null;
            this.dgvFollowup.BindingResponsePropertyName = null;
            this.dgvFollowup.BindingSourcePropertyName = "Followups";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFollowup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFollowup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFollowup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.跟进信息,
            this.跟进人});
            this.dgvFollowup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFollowup.Location = new System.Drawing.Point(3, 53);
            this.dgvFollowup.Name = "dgvFollowup";
            this.dgvFollowup.ReadOnly = true;
            this.dgvFollowup.RowTemplate.Height = 23;
            this.dgvFollowup.Size = new System.Drawing.Size(545, 347);
            this.dgvFollowup.TabIndex = 1;
            // 
            // 跟进信息
            // 
            this.跟进信息.DataPropertyName = "Remark";
            this.跟进信息.HeaderText = "跟进信息";
            this.跟进信息.Name = "跟进信息";
            this.跟进信息.ReadOnly = true;
            this.跟进信息.Width = 400;
            // 
            // 跟进人
            // 
            this.跟进人.DataPropertyName = "CreatorName";
            this.跟进人.HeaderText = "跟进人";
            this.跟进人.Name = "跟进人";
            this.跟进人.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddFollowup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 36);
            this.panel2.TabIndex = 0;
            // 
            // btnAddFollowup
            // 
            this.btnAddFollowup.ClickedMessage = null;
            this.btnAddFollowup.IngoreCallbackOnce = false;
            this.btnAddFollowup.Location = new System.Drawing.Point(3, 7);
            this.btnAddFollowup.Name = "btnAddFollowup";
            this.btnAddFollowup.Response = null;
            this.btnAddFollowup.Size = new System.Drawing.Size(75, 23);
            this.btnAddFollowup.TabIndex = 1;
            this.btnAddFollowup.Text = "增加跟进";
            this.btnAddFollowup.UseSelectable = true;
            this.btnAddFollowup.Click += new System.EventHandler(this.btnAddFollowup_Click);
            // 
            // BaseEditHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 490);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BaseEditHouse";
            this.Text = "BaseEditHouse";
            this.InitControl += new System.EventHandler(this.BaseEditHouse_InitControl);
            this.ShownOnSync += new System.EventHandler(this.BaseEditHouse_ShownOnSync);
            this.Load += new System.EventHandler(this.BaseEditHouse_Load);
            this.Shown += new System.EventHandler(this.BaseEditHouse_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFollowup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected SOAFramework.Client.Controls.GroupBox groupBox2;
        protected SOAFramework.Client.Controls.GroupBox groupBox1;
        protected SOAFramework.Client.Controls.NumbericUpDown numCost;
        private SOAFramework.Client.Controls.Label label17;
        protected SOAFramework.Client.Controls.TextBox txbArea;
        private SOAFramework.Client.Controls.Label label14;
        protected SOAFramework.Client.Controls.TextBox txbFloor;
        protected SOAFramework.Client.Controls.TextBox txbRemark;
        protected SOAFramework.Client.Controls.TextBox txbHouseName;
        protected SOAFramework.Client.Controls.ComboBox cmbToilet;
        protected SOAFramework.Client.Controls.ComboBox cmbHall;
        protected SOAFramework.Client.Controls.ComboBox cmbRoom;
        private SOAFramework.Client.Controls.Label label8;
        private SOAFramework.Client.Controls.Label label7;
        private SOAFramework.Client.Controls.Label label6;
        private SOAFramework.Client.Controls.Label label5;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        protected SOAFramework.Client.Controls.ComboBox cmbStatus;
        private SOAFramework.Client.Controls.Label label10;
        protected SOAFramework.Client.Controls.GroupBox groupBox3;
        private SOAFramework.Client.Controls.Label label11;
        private SOAFramework.Client.Controls.Label label12;
        protected SOAFramework.Client.Controls.ComboBox cmbCustomer;
        protected SOAFramework.Client.Controls.ComboBox cmbDecorationType;
        private SOAFramework.Client.Controls.Label label13;
        protected SOAFramework.Client.Controls.TextBox txbMobile;
        protected SOAFramework.Client.Controls.Button btnAddCustomer;
        protected SOAFramework.Client.Controls.ComboBox cmbBuilding;
        private SOAFramework.Client.Controls.Panel panel1;
        private SOAFramework.Client.Controls.GroupBox groupBox4;
        protected SOAFramework.Client.Controls.DataGridView dgvFollowup;
        protected SOAFramework.Client.Controls.Panel panel2;
        protected SOAFramework.Client.Controls.Button btnAddFollowup;
        protected SOAFramework.Client.Controls.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn 跟进信息;
        private System.Windows.Forms.DataGridViewTextBoxColumn 跟进人;
        protected SOAFramework.Client.Controls.CheckBox chkIsOurs;
    }
}