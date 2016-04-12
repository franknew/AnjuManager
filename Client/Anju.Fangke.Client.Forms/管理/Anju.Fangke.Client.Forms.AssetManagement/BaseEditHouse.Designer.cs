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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.txbArea = new SOAFramework.Client.Controls.TextBox();
            this.label14 = new SOAFramework.Client.Controls.Label();
            this.rabHezu = new SOAFramework.Client.Controls.RadioButton();
            this.rabZhengZu = new SOAFramework.Client.Controls.RadioButton();
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
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.groupBox3 = new SOAFramework.Client.Controls.GroupBox();
            this.numRentDay = new SOAFramework.Client.Controls.NumbericUpDown();
            this.numCycle = new SOAFramework.Client.Controls.NumbericUpDown();
            this.dtExpiredTime = new SOAFramework.Client.Controls.DateTimeComboPicker();
            this.label16 = new SOAFramework.Client.Controls.Label();
            this.label15 = new SOAFramework.Client.Controls.Label();
            this.txbRentRemark = new SOAFramework.Client.Controls.TextBox();
            this.chkIsRented = new SOAFramework.Client.Controls.CheckBox();
            this.cmbCycleType = new SOAFramework.Client.Controls.ComboBox();
            this.txbDeposit = new SOAFramework.Client.Controls.TextBox();
            this.txbRentFee = new SOAFramework.Client.Controls.TextBox();
            this.label13 = new SOAFramework.Client.Controls.Label();
            this.label12 = new SOAFramework.Client.Controls.Label();
            this.label11 = new SOAFramework.Client.Controls.Label();
            this.label10 = new SOAFramework.Client.Controls.Label();
            this.label9 = new SOAFramework.Client.Controls.Label();
            this.panel1 = new SOAFramework.Client.Controls.Panel();
            this.groupBox4 = new SOAFramework.Client.Controls.GroupBox();
            this.dgvOtherFee = new SOAFramework.Client.Controls.DataGridView();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.费用类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.单价 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.启用 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new SOAFramework.Client.Controls.GroupBox();
            this.btnDelete = new SOAFramework.Client.Controls.Button();
            this.btnAddOtherFee = new SOAFramework.Client.Controls.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherFee)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbArea);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.rabHezu);
            this.groupBox1.Controls.Add(this.rabZhengZu);
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "房间信息";
            // 
            // txbArea
            // 
            this.txbArea.BindingRequestPropertyName = null;
            this.txbArea.BindingResponsePropertyName = null;
            this.txbArea.BindingSourcePropertyName = "House.Area";
            this.txbArea.EmptyWarning = null;
            this.txbArea.Lines = new string[0];
            this.txbArea.Location = new System.Drawing.Point(86, 145);
            this.txbArea.MaxLength = 32767;
            this.txbArea.Name = "txbArea";
            this.txbArea.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbArea.SelectedText = "";
            this.txbArea.SelectionLength = 0;
            this.txbArea.Size = new System.Drawing.Size(251, 23);
            this.txbArea.TabIndex = 16;
            this.txbArea.UseSelectable = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 19);
            this.label14.TabIndex = 15;
            this.label14.Text = "房间面积";
            // 
            // rabHezu
            // 
            this.rabHezu.AutoSize = true;
            this.rabHezu.BindingRequestPropertyName = null;
            this.rabHezu.BindingResponsePropertyName = null;
            this.rabHezu.BindingSourcePropertyName = null;
            this.rabHezu.Group = "House.RentType";
            this.rabHezu.Location = new System.Drawing.Point(145, 124);
            this.rabHezu.Name = "rabHezu";
            this.rabHezu.Size = new System.Drawing.Size(47, 15);
            this.rabHezu.TabIndex = 6;
            this.rabHezu.Text = "合租";
            this.rabHezu.UseSelectable = true;
            this.rabHezu.Value = "0";
            // 
            // rabZhengZu
            // 
            this.rabZhengZu.AutoSize = true;
            this.rabZhengZu.BindingRequestPropertyName = null;
            this.rabZhengZu.BindingResponsePropertyName = null;
            this.rabZhengZu.BindingSourcePropertyName = null;
            this.rabZhengZu.Checked = true;
            this.rabZhengZu.Group = "House.RentType";
            this.rabZhengZu.Location = new System.Drawing.Point(88, 124);
            this.rabZhengZu.Name = "rabZhengZu";
            this.rabZhengZu.Size = new System.Drawing.Size(47, 15);
            this.rabZhengZu.TabIndex = 5;
            this.rabZhengZu.TabStop = true;
            this.rabZhengZu.Text = "整租";
            this.rabZhengZu.UseSelectable = true;
            this.rabZhengZu.Value = "1";
            // 
            // txbFloor
            // 
            this.txbFloor.BindingRequestPropertyName = null;
            this.txbFloor.BindingResponsePropertyName = null;
            this.txbFloor.BindingSourcePropertyName = "House.Floor";
            this.txbFloor.EmptyWarning = null;
            this.txbFloor.Lines = new string[0];
            this.txbFloor.Location = new System.Drawing.Point(243, 30);
            this.txbFloor.MaxLength = 32767;
            this.txbFloor.Name = "txbFloor";
            this.txbFloor.ReadOnly = true;
            this.txbFloor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFloor.SelectedText = "";
            this.txbFloor.SelectionLength = 0;
            this.txbFloor.Size = new System.Drawing.Size(94, 23);
            this.txbFloor.TabIndex = 14;
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
            this.txbRemark.Location = new System.Drawing.Point(87, 174);
            this.txbRemark.MaxLength = 32767;
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRemark.SelectedText = "";
            this.txbRemark.SelectionLength = 0;
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
            this.label2.Location = new System.Drawing.Point(44, 174);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(1, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(439, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numRentDay);
            this.groupBox3.Controls.Add(this.numCycle);
            this.groupBox3.Controls.Add(this.dtExpiredTime);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txbRentRemark);
            this.groupBox3.Controls.Add(this.chkIsRented);
            this.groupBox3.Controls.Add(this.cmbCycleType);
            this.groupBox3.Controls.Add(this.txbDeposit);
            this.groupBox3.Controls.Add(this.txbRentFee);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(358, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(416, 270);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "租金信息";
            // 
            // numRentDay
            // 
            this.numRentDay.BindingControlPropertyName = "Value";
            this.numRentDay.BindingRequestPropertyName = null;
            this.numRentDay.BindingResponsePropertyName = null;
            this.numRentDay.BindingSourcePropertyName = "RentFee.RentDay";
            this.numRentDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numRentDay.EmptyWarning = null;
            this.numRentDay.Location = new System.Drawing.Point(77, 95);
            this.numRentDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numRentDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRentDay.Name = "numRentDay";
            this.numRentDay.Size = new System.Drawing.Size(125, 21);
            this.numRentDay.TabIndex = 19;
            this.numRentDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numCycle
            // 
            this.numCycle.BindingControlPropertyName = "Value";
            this.numCycle.BindingRequestPropertyName = null;
            this.numCycle.BindingResponsePropertyName = null;
            this.numCycle.BindingSourcePropertyName = "RentFee.Cycle";
            this.numCycle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCycle.EmptyWarning = null;
            this.numCycle.Location = new System.Drawing.Point(77, 61);
            this.numCycle.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCycle.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCycle.Name = "numCycle";
            this.numCycle.Size = new System.Drawing.Size(125, 21);
            this.numCycle.TabIndex = 18;
            this.numCycle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtExpiredTime
            // 
            this.dtExpiredTime.BindingRequestPropertyName = null;
            this.dtExpiredTime.BindingResponsePropertyName = null;
            this.dtExpiredTime.BindingSourcePropertyName = "RentFee.ExpiredTime";
            this.dtExpiredTime.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.dtExpiredTime.Location = new System.Drawing.Point(275, 90);
            this.dtExpiredTime.MinimumSize = new System.Drawing.Size(0, 25);
            this.dtExpiredTime.Name = "dtExpiredTime";
            this.dtExpiredTime.Size = new System.Drawing.Size(124, 25);
            this.dtExpiredTime.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(204, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 19);
            this.label16.TabIndex = 23;
            this.label16.Text = "到期时间";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 19);
            this.label15.TabIndex = 21;
            this.label15.Text = "交租日";
            // 
            // txbRentRemark
            // 
            this.txbRentRemark.BindingRequestPropertyName = null;
            this.txbRentRemark.BindingResponsePropertyName = null;
            this.txbRentRemark.BindingSourcePropertyName = "RentFee.Remark";
            this.txbRentRemark.EmptyWarning = null;
            this.txbRentRemark.Lines = new string[0];
            this.txbRentRemark.Location = new System.Drawing.Point(77, 145);
            this.txbRentRemark.MaxLength = 32767;
            this.txbRentRemark.Multiline = true;
            this.txbRentRemark.Name = "txbRentRemark";
            this.txbRentRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRentRemark.SelectedText = "";
            this.txbRentRemark.SelectionLength = 0;
            this.txbRentRemark.Size = new System.Drawing.Size(322, 112);
            this.txbRentRemark.TabIndex = 23;
            this.txbRentRemark.UseSelectable = true;
            // 
            // chkIsRented
            // 
            this.chkIsRented.AutoSize = true;
            this.chkIsRented.BindingChecked = 0;
            this.chkIsRented.BindingRequestPropertyName = null;
            this.chkIsRented.BindingResponsePropertyName = null;
            this.chkIsRented.BindingSourcePropertyName = "House.IsRented";
            this.chkIsRented.Group = null;
            this.chkIsRented.Location = new System.Drawing.Point(77, 124);
            this.chkIsRented.Name = "chkIsRented";
            this.chkIsRented.Size = new System.Drawing.Size(59, 15);
            this.chkIsRented.TabIndex = 22;
            this.chkIsRented.Text = "已出租";
            this.chkIsRented.UseSelectable = true;
            // 
            // cmbCycleType
            // 
            this.cmbCycleType.BindingRequestPropertyName = null;
            this.cmbCycleType.BindingResponsePropertyName = null;
            this.cmbCycleType.BindingSourcePropertyName = "RentFee.CycleType";
            this.cmbCycleType.DisplayMember = "Name";
            this.cmbCycleType.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbCycleType.FormattingEnabled = true;
            this.cmbCycleType.InitableBindingGroupName = "周期类型";
            this.cmbCycleType.ItemHeight = 19;
            this.cmbCycleType.Items.AddRange(new object[] {
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
            this.cmbCycleType.Location = new System.Drawing.Point(275, 59);
            this.cmbCycleType.Name = "cmbCycleType";
            this.cmbCycleType.Size = new System.Drawing.Size(124, 25);
            this.cmbCycleType.TabIndex = 19;
            this.cmbCycleType.UseSelectable = true;
            this.cmbCycleType.Value = null;
            this.cmbCycleType.ValueMember = "Value";
            // 
            // txbDeposit
            // 
            this.txbDeposit.BindingRequestPropertyName = null;
            this.txbDeposit.BindingResponsePropertyName = null;
            this.txbDeposit.BindingSourcePropertyName = "RentFee.Deposit";
            this.txbDeposit.EmptyWarning = null;
            this.txbDeposit.Lines = new string[] {
        "0"};
            this.txbDeposit.Location = new System.Drawing.Point(275, 30);
            this.txbDeposit.MaxLength = 32767;
            this.txbDeposit.Name = "txbDeposit";
            this.txbDeposit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDeposit.SelectedText = "";
            this.txbDeposit.SelectionLength = 0;
            this.txbDeposit.Size = new System.Drawing.Size(124, 23);
            this.txbDeposit.TabIndex = 17;
            this.txbDeposit.Text = "0";
            this.txbDeposit.UseSelectable = true;
            // 
            // txbRentFee
            // 
            this.txbRentFee.BindingRequestPropertyName = null;
            this.txbRentFee.BindingResponsePropertyName = null;
            this.txbRentFee.BindingSourcePropertyName = "RentFee.RentMoney";
            this.txbRentFee.EmptyWarning = null;
            this.txbRentFee.Lines = new string[] {
        "0"};
            this.txbRentFee.Location = new System.Drawing.Point(77, 30);
            this.txbRentFee.MaxLength = 32767;
            this.txbRentFee.Name = "txbRentFee";
            this.txbRentFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRentFee.SelectedText = "";
            this.txbRentFee.SelectionLength = 0;
            this.txbRentFee.Size = new System.Drawing.Size(125, 23);
            this.txbRentFee.TabIndex = 16;
            this.txbRentFee.Text = "0";
            this.txbRentFee.UseSelectable = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "备注";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(232, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 19);
            this.label12.TabIndex = 7;
            this.label12.Text = "押金";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(204, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "周期类型";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "收租周期";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "租金";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(1, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 270);
            this.panel1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvOtherFee);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(1, 300);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(774, 163);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "费用信息";
            // 
            // dgvOtherFee
            // 
            this.dgvOtherFee.AllowUserToAddRows = false;
            this.dgvOtherFee.AllowUserToDeleteRows = false;
            this.dgvOtherFee.AutoGenerateColumns = false;
            this.dgvOtherFee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvOtherFee.BindingRequestPropertyName = null;
            this.dgvOtherFee.BindingResponsePropertyName = null;
            this.dgvOtherFee.BindingSourcePropertyName = "OtherFees";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOtherFee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOtherFee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOtherFee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名称,
            this.费用类型,
            this.单价,
            this.启用,
            this.备注});
            this.dgvOtherFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOtherFee.Location = new System.Drawing.Point(3, 60);
            this.dgvOtherFee.Name = "dgvOtherFee";
            this.dgvOtherFee.ReadOnly = true;
            this.dgvOtherFee.RowTemplate.Height = 23;
            this.dgvOtherFee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOtherFee.Size = new System.Drawing.Size(768, 100);
            this.dgvOtherFee.TabIndex = 0;
            // 
            // 名称
            // 
            this.名称.DataPropertyName = "Name";
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.Width = 150;
            // 
            // 费用类型
            // 
            this.费用类型.DataPropertyName = "FeeTypeName";
            this.费用类型.HeaderText = "费用类型";
            this.费用类型.Name = "费用类型";
            this.费用类型.ReadOnly = true;
            // 
            // 单价
            // 
            this.单价.DataPropertyName = "UnitPrice";
            this.单价.HeaderText = "单价";
            this.单价.Name = "单价";
            this.单价.ReadOnly = true;
            // 
            // 启用
            // 
            this.启用.DataPropertyName = "Enabled";
            this.启用.FalseValue = "0";
            this.启用.HeaderText = "启用";
            this.启用.Name = "启用";
            this.启用.ReadOnly = true;
            this.启用.TrueValue = "1";
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "Remark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 200;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Controls.Add(this.btnAddOtherFee);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(768, 43);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.ClickedMessage = null;
            this.btnDelete.IngoreCallbackOnce = false;
            this.btnDelete.Location = new System.Drawing.Point(90, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Response = null;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "删除费用";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddOtherFee
            // 
            this.btnAddOtherFee.ClickedMessage = null;
            this.btnAddOtherFee.IngoreCallbackOnce = false;
            this.btnAddOtherFee.Location = new System.Drawing.Point(6, 14);
            this.btnAddOtherFee.Name = "btnAddOtherFee";
            this.btnAddOtherFee.Response = null;
            this.btnAddOtherFee.Size = new System.Drawing.Size(75, 23);
            this.btnAddOtherFee.TabIndex = 24;
            this.btnAddOtherFee.Text = "新增费用";
            this.btnAddOtherFee.UseSelectable = true;
            this.btnAddOtherFee.Click += new System.EventHandler(this.btnAddOtherFee_Click);
            // 
            // BaseEditHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 520);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BaseEditHouse";
            this.Text = "BaseEditHouse";
            this.Load += new System.EventHandler(this.BaseEditHouse_Load);
            this.Shown += new System.EventHandler(this.BaseEditHouse_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOtherFee)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.Label label6;
        private SOAFramework.Client.Controls.Label label5;
        private SOAFramework.Client.Controls.Label label4;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.Label label8;
        private SOAFramework.Client.Controls.Label label7;
        protected SOAFramework.Client.Controls.TextBox txbRemark;
        protected SOAFramework.Client.Controls.TextBox txbHouseName;
        protected SOAFramework.Client.Controls.ComboBox cmbToilet;
        protected SOAFramework.Client.Controls.ComboBox cmbHall;
        protected SOAFramework.Client.Controls.ComboBox cmbRoom;
        protected SOAFramework.Client.Controls.TextBox txbFloor;
        protected SOAFramework.Client.Controls.TextBox txbBuildingName;
        protected SOAFramework.Client.Controls.GroupBox groupBox1;
        protected SOAFramework.Client.Controls.GroupBox groupBox2;
        public SOAFramework.Client.Controls.RadioButton rabHezu;
        public SOAFramework.Client.Controls.RadioButton rabZhengZu;
        protected SOAFramework.Client.Controls.TextBox txbDeposit;
        protected SOAFramework.Client.Controls.TextBox txbRentFee;
        protected SOAFramework.Client.Controls.ComboBox cmbCycleType;
        protected SOAFramework.Client.Controls.GroupBox groupBox3;
        protected SOAFramework.Client.Controls.Label label11;
        protected SOAFramework.Client.Controls.Label label10;
        protected SOAFramework.Client.Controls.Label label9;
        protected SOAFramework.Client.Controls.Label label12;
        protected SOAFramework.Client.Controls.Label label13;
        protected SOAFramework.Client.Controls.CheckBox chkIsRented;
        protected SOAFramework.Client.Controls.TextBox txbRentRemark;
        public SOAFramework.Client.Controls.Panel panel1;
        protected SOAFramework.Client.Controls.GroupBox groupBox4;
        protected SOAFramework.Client.Controls.DataGridView dgvOtherFee;
        private SOAFramework.Client.Controls.Label label14;
        protected SOAFramework.Client.Controls.TextBox txbArea;
        protected SOAFramework.Client.Controls.Label label15;
        protected SOAFramework.Client.Controls.Label label16;
        protected SOAFramework.Client.Controls.DateTimeComboPicker dtExpiredTime;
        private SOAFramework.Client.Controls.Button btnDelete;
        private SOAFramework.Client.Controls.Button btnAddOtherFee;
        protected SOAFramework.Client.Controls.NumbericUpDown numRentDay;
        protected SOAFramework.Client.Controls.NumbericUpDown numCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 费用类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 单价;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 启用;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        protected SOAFramework.Client.Controls.GroupBox groupBox5;
    }
}