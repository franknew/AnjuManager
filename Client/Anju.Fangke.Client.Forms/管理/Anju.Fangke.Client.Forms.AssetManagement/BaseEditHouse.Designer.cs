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
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(1, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rabHezu
            // 
            this.rabHezu.AutoSize = true;
            this.rabHezu.BindingRequestPropertyName = null;
            this.rabHezu.BindingResponsePropertyName = null;
            this.rabHezu.BindingSourcePropertyName = null;
            this.rabHezu.Location = new System.Drawing.Point(144, 192);
            this.rabHezu.Name = "rabHezu";
            this.rabHezu.Size = new System.Drawing.Size(47, 15);
            this.rabHezu.TabIndex = 6;
            this.rabHezu.Text = "合租";
            this.rabHezu.UseSelectable = true;
            // 
            // rabZhengZu
            // 
            this.rabZhengZu.AutoSize = true;
            this.rabZhengZu.BindingRequestPropertyName = null;
            this.rabZhengZu.BindingResponsePropertyName = null;
            this.rabZhengZu.BindingSourcePropertyName = null;
            this.rabZhengZu.Checked = true;
            this.rabZhengZu.Location = new System.Drawing.Point(87, 192);
            this.rabZhengZu.Name = "rabZhengZu";
            this.rabZhengZu.Size = new System.Drawing.Size(47, 15);
            this.rabZhengZu.TabIndex = 5;
            this.rabZhengZu.TabStop = true;
            this.rabZhengZu.Text = "整租";
            this.rabZhengZu.UseSelectable = true;
            // 
            // txbFloor
            // 
            this.txbFloor.BindingRequestPropertyName = null;
            this.txbFloor.BindingResponsePropertyName = null;
            this.txbFloor.BindingSourcePropertyName = null;
            this.txbFloor.EmptyWarning = null;
            this.txbFloor.Lines = new string[0];
            this.txbFloor.Location = new System.Drawing.Point(243, 30);
            this.txbFloor.MaxLength = 32767;
            this.txbFloor.Name = "txbFloor";
            this.txbFloor.ReadOnly = true;
            this.txbFloor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbFloor.SelectedText = "";
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
            this.txbBuildingName.Size = new System.Drawing.Size(94, 23);
            this.txbBuildingName.TabIndex = 13;
            this.txbBuildingName.UseSelectable = true;
            // 
            // txbRemark
            // 
            this.txbRemark.BindingRequestPropertyName = null;
            this.txbRemark.BindingResponsePropertyName = null;
            this.txbRemark.BindingSourcePropertyName = null;
            this.txbRemark.EmptyWarning = null;
            this.txbRemark.Lines = new string[0];
            this.txbRemark.Location = new System.Drawing.Point(86, 213);
            this.txbRemark.MaxLength = 32767;
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRemark.SelectedText = "";
            this.txbRemark.Size = new System.Drawing.Size(250, 133);
            this.txbRemark.TabIndex = 7;
            this.txbRemark.UseSelectable = true;
            // 
            // txbHouseName
            // 
            this.txbHouseName.BindingRequestPropertyName = null;
            this.txbHouseName.BindingResponsePropertyName = null;
            this.txbHouseName.BindingSourcePropertyName = null;
            this.txbHouseName.EmptyWarning = null;
            this.txbHouseName.Lines = new string[0];
            this.txbHouseName.Location = new System.Drawing.Point(87, 86);
            this.txbHouseName.MaxLength = 32767;
            this.txbHouseName.Name = "txbHouseName";
            this.txbHouseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHouseName.SelectedText = "";
            this.txbHouseName.Size = new System.Drawing.Size(250, 23);
            this.txbHouseName.TabIndex = 1;
            this.txbHouseName.UseSelectable = true;
            // 
            // cmbToilet
            // 
            this.cmbToilet.BindingRequestPropertyName = null;
            this.cmbToilet.BindingResponsePropertyName = null;
            this.cmbToilet.BindingSourcePropertyName = null;
            this.cmbToilet.FormattingEnabled = true;
            this.cmbToilet.InitableBindingGroupName = null;
            this.cmbToilet.ItemHeight = 23;
            this.cmbToilet.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbToilet.Location = new System.Drawing.Point(256, 140);
            this.cmbToilet.Name = "cmbToilet";
            this.cmbToilet.Size = new System.Drawing.Size(52, 29);
            this.cmbToilet.TabIndex = 4;
            this.cmbToilet.UseSelectable = true;
            this.cmbToilet.Value = null;
            // 
            // cmbHall
            // 
            this.cmbHall.BindingRequestPropertyName = null;
            this.cmbHall.BindingResponsePropertyName = null;
            this.cmbHall.BindingSourcePropertyName = null;
            this.cmbHall.FormattingEnabled = true;
            this.cmbHall.InitableBindingGroupName = null;
            this.cmbHall.ItemHeight = 23;
            this.cmbHall.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbHall.Location = new System.Drawing.Point(173, 140);
            this.cmbHall.Name = "cmbHall";
            this.cmbHall.Size = new System.Drawing.Size(52, 29);
            this.cmbHall.TabIndex = 3;
            this.cmbHall.UseSelectable = true;
            this.cmbHall.Value = null;
            // 
            // cmbRoom
            // 
            this.cmbRoom.BindingRequestPropertyName = null;
            this.cmbRoom.BindingResponsePropertyName = null;
            this.cmbRoom.BindingSourcePropertyName = null;
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.InitableBindingGroupName = null;
            this.cmbRoom.ItemHeight = 23;
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
            this.cmbRoom.Location = new System.Drawing.Point(86, 140);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(52, 29);
            this.cmbRoom.TabIndex = 2;
            this.cmbRoom.UseSelectable = true;
            this.cmbRoom.Value = null;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(314, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "卫";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "厅";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "室";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 149);
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
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "房间名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 213);
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
            this.groupBox2.Location = new System.Drawing.Point(1, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(370, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(243, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // BaseEditHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "BaseEditHouse";
            this.Text = "BaseEditHouse";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
    }
}