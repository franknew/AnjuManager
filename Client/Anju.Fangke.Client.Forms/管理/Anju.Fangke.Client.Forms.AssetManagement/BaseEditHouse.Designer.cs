namespace Anju.Fangke.Client.Forms
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
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.cmbDecorationType = new SOAFramework.Client.Controls.ComboBox();
            this.label13 = new SOAFramework.Client.Controls.Label();
            this.cmbStatus = new SOAFramework.Client.Controls.ComboBox();
            this.label10 = new SOAFramework.Client.Controls.Label();
            this.textBox1 = new SOAFramework.Client.Controls.TextBox();
            this.label9 = new SOAFramework.Client.Controls.Label();
            this.numCost = new SOAFramework.Client.Controls.NumbericUpDown();
            this.label17 = new SOAFramework.Client.Controls.Label();
            this.txbArea = new SOAFramework.Client.Controls.TextBox();
            this.label14 = new SOAFramework.Client.Controls.Label();
            this.txbFloor = new SOAFramework.Client.Controls.TextBox();
            this.txbBuildingName = new SOAFramework.Client.Controls.TextBox();
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(1, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 56);
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
            this.groupBox1.Controls.Add(this.cmbDecorationType);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numCost);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txbArea);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txbFloor);
            this.groupBox1.Controls.Add(this.txbBuildingName);
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
            this.groupBox1.Location = new System.Drawing.Point(1, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 314);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房间信息";
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
            this.cmbDecorationType.Location = new System.Drawing.Point(86, 189);
            this.cmbDecorationType.Name = "cmbDecorationType";
            this.cmbDecorationType.Size = new System.Drawing.Size(251, 25);
            this.cmbDecorationType.TabIndex = 24;
            this.cmbDecorationType.UseSelectable = true;
            this.cmbDecorationType.Value = null;
            this.cmbDecorationType.ValueMember = "Value";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 191);
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
            this.cmbStatus.Location = new System.Drawing.Point(243, 158);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(94, 25);
            this.cmbStatus.TabIndex = 22;
            this.cmbStatus.UseSelectable = true;
            this.cmbStatus.Value = null;
            this.cmbStatus.ValueMember = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(200, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "状态";
            // 
            // textBox1
            // 
            this.textBox1.BindingRequestPropertyName = null;
            this.textBox1.BindingResponsePropertyName = null;
            this.textBox1.BindingSourcePropertyName = "House.Name";
            this.textBox1.EmptyWarning = null;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(86, 158);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(93, 23);
            this.textBox1.TabIndex = 20;
            this.textBox1.UseSelectable = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "钥匙编号";
            // 
            // numCost
            // 
            this.numCost.BindingRequestPropertyName = null;
            this.numCost.BindingResponsePropertyName = null;
            this.numCost.BindingSourcePropertyName = "House.Cost";
            this.numCost.DecimalPlaces = 2;
            this.numCost.EmptyWarning = null;
            this.numCost.Location = new System.Drawing.Point(244, 129);
            this.numCost.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numCost.Name = "numCost";
            this.numCost.Size = new System.Drawing.Size(94, 21);
            this.numCost.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(200, 129);
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
            this.txbArea.Location = new System.Drawing.Point(86, 129);
            this.txbArea.MaxLength = 32767;
            this.txbArea.Name = "txbArea";
            this.txbArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbArea.SelectedText = "";
            this.txbArea.SelectionLength = 0;
            this.txbArea.SelectionStart = 0;
            this.txbArea.Size = new System.Drawing.Size(93, 23);
            this.txbArea.TabIndex = 16;
            this.txbArea.Text = "0";
            this.txbArea.UseSelectable = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 129);
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
            this.txbFloor.Location = new System.Drawing.Point(243, 30);
            this.txbFloor.MaxLength = 32767;
            this.txbFloor.Name = "txbFloor";
            this.txbFloor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFloor.SelectedText = "";
            this.txbFloor.SelectionLength = 0;
            this.txbFloor.SelectionStart = 0;
            this.txbFloor.Size = new System.Drawing.Size(94, 23);
            this.txbFloor.TabIndex = 14;
            this.txbFloor.Text = "1";
            this.txbFloor.UseSelectable = true;
            // 
            // txbBuildingName
            // 
            this.txbBuildingName.BindingRequestPropertyName = null;
            this.txbBuildingName.BindingResponsePropertyName = null;
            this.txbBuildingName.BindingSourcePropertyName = null;
            this.txbBuildingName.EmptyWarning = null;
            this.txbBuildingName.Lines = new string[0];
            this.txbBuildingName.Location = new System.Drawing.Point(86, 30);
            this.txbBuildingName.MaxLength = 32767;
            this.txbBuildingName.Name = "txbBuildingName";
            this.txbBuildingName.ReadOnly = true;
            this.txbBuildingName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBuildingName.SelectedText = "";
            this.txbBuildingName.SelectionLength = 0;
            this.txbBuildingName.SelectionStart = 0;
            this.txbBuildingName.Size = new System.Drawing.Size(94, 23);
            this.txbBuildingName.TabIndex = 13;
            this.txbBuildingName.UseSelectable = true;
            // 
            // txbRemark
            // 
            this.txbRemark.BindingRequestPropertyName = null;
            this.txbRemark.BindingResponsePropertyName = null;
            this.txbRemark.BindingSourcePropertyName = "House.Remark";
            this.txbRemark.EmptyWarning = null;
            this.txbRemark.Lines = new string[0];
            this.txbRemark.Location = new System.Drawing.Point(88, 220);
            this.txbRemark.MaxLength = 32767;
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRemark.SelectedText = "";
            this.txbRemark.SelectionLength = 0;
            this.txbRemark.SelectionStart = 0;
            this.txbRemark.Size = new System.Drawing.Size(250, 83);
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
            this.txbHouseName.Location = new System.Drawing.Point(87, 61);
            this.txbHouseName.MaxLength = 32767;
            this.txbHouseName.Name = "txbHouseName";
            this.txbHouseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHouseName.SelectedText = "";
            this.txbHouseName.SelectionLength = 0;
            this.txbHouseName.SelectionStart = 0;
            this.txbHouseName.Size = new System.Drawing.Size(250, 23);
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
            this.cmbToilet.Location = new System.Drawing.Point(257, 93);
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
            this.cmbHall.Location = new System.Drawing.Point(174, 93);
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
            this.cmbRoom.Location = new System.Drawing.Point(86, 93);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(52, 25);
            this.cmbRoom.TabIndex = 2;
            this.cmbRoom.UseSelectable = true;
            this.cmbRoom.Value = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "卫";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "厅";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "室";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 99);
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
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "房间名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "备注";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 30);
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
            this.groupBox3.Location = new System.Drawing.Point(1, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 96);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "业主信息";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.ClickedMessage = null;
            this.btnAddCustomer.IngoreCallbackOnce = false;
            this.btnAddCustomer.Location = new System.Drawing.Point(303, 27);
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
            this.txbMobile.Size = new System.Drawing.Size(249, 23);
            this.txbMobile.TabIndex = 21;
            this.txbMobile.UseSelectable = true;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.BindingRequestPropertyName = null;
            this.cmbCustomer.BindingResponsePropertyName = null;
            this.cmbCustomer.BindingSourcePropertyName = "Customer.ID";
            this.cmbCustomer.DisplayMember = "Name";
            this.cmbCustomer.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.InitableBindingGroupName = null;
            this.cmbCustomer.ItemHeight = 19;
            this.cmbCustomer.Location = new System.Drawing.Point(88, 27);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(209, 25);
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
            // BaseEditHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 497);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "BaseEditHouse";
            this.Text = "BaseEditHouse";
            this.ShownOnSync += new System.EventHandler(this.BaseEditHouse_ShownOnSync);
            this.Load += new System.EventHandler(this.BaseEditHouse_Load);
            this.Shown += new System.EventHandler(this.BaseEditHouse_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SOAFramework.Client.Controls.Button btnClose;
        protected SOAFramework.Client.Controls.GroupBox groupBox2;
        protected SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.Label label9;
        protected SOAFramework.Client.Controls.NumbericUpDown numCost;
        private SOAFramework.Client.Controls.Label label17;
        protected SOAFramework.Client.Controls.TextBox txbArea;
        private SOAFramework.Client.Controls.Label label14;
        protected SOAFramework.Client.Controls.TextBox txbFloor;
        protected SOAFramework.Client.Controls.TextBox txbBuildingName;
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
        protected SOAFramework.Client.Controls.TextBox textBox1;
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
    }
}