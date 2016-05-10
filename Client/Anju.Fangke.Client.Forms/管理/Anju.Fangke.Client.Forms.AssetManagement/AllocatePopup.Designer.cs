namespace Anju.Fangke.Client.Forms
{
    partial class AllocatePopup
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
            this.cmbEmployee = new SOAFramework.Client.Controls.ComboBox();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.txbHouseID = new SOAFramework.Client.Controls.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbEmployee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(1, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.BindingRequestPropertyName = "userID";
            this.cmbEmployee.BindingResponsePropertyName = null;
            this.cmbEmployee.BindingSourcePropertyName = null;
            this.cmbEmployee.DisplayMember = "CnName";
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.InitableBindingGroupName = null;
            this.cmbEmployee.ItemHeight = 23;
            this.cmbEmployee.Location = new System.Drawing.Point(92, 12);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(203, 29);
            this.cmbEmployee.TabIndex = 1;
            this.cmbEmployee.UseSelectable = true;
            this.cmbEmployee.Value = null;
            this.cmbEmployee.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "分配给员工";
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.EnableSyncClick = true;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(49, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.RequestName = "AllocateToUserRequest";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            this.btnSave.ClickCallback += new System.EventHandler(this.btnSave_ClickCallback);
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(167, 84);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // txbHouseID
            // 
            this.txbHouseID.BindingRequestPropertyName = "houseID";
            this.txbHouseID.BindingResponsePropertyName = null;
            this.txbHouseID.BindingSourcePropertyName = null;
            this.txbHouseID.EmptyWarning = null;
            this.txbHouseID.Lines = new string[0];
            this.txbHouseID.Location = new System.Drawing.Point(6, 4);
            this.txbHouseID.MaxLength = 32767;
            this.txbHouseID.Name = "txbHouseID";
            this.txbHouseID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbHouseID.SelectedText = "";
            this.txbHouseID.SelectionLength = 0;
            this.txbHouseID.SelectionStart = 0;
            this.txbHouseID.Size = new System.Drawing.Size(75, 23);
            this.txbHouseID.TabIndex = 3;
            this.txbHouseID.UseSelectable = true;
            this.txbHouseID.Visible = false;
            // 
            // AllocatePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 118);
            this.Controls.Add(this.txbHouseID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "AllocatePopup";
            this.Text = "分配房源";
            this.InitControl += new System.EventHandler(this.AllocatePopup_InitControl);
            this.Shown += new System.EventHandler(this.AllocatePopup_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.Button btnSave;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.ComboBox cmbEmployee;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.TextBox txbHouseID;
    }
}