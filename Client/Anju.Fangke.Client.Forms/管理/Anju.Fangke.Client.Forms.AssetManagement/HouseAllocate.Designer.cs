﻿namespace Anju.Fangke.Client.Forms
{
    partial class HouseAllocate
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
            this.btnAllocate = new SOAFramework.Client.Controls.Button();
            this.labelCreator = new SOAFramework.Client.Controls.Label();
            this.cmbOwner = new SOAFramework.Client.Controls.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAllocate);
            this.groupBox1.Controls.SetChildIndex(this.btnQuery, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnClose, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnAllocate, 0);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(168, 12);
            this.btnClose.Text = "退出";
            // 
            // btnQuery
            // 
            this.btnQuery.RequestName = "QueryAllocateHouseRequest";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbOwner);
            this.groupBox2.Controls.Add(this.labelCreator);
            this.groupBox2.Size = new System.Drawing.Size(1290, 130);
            this.groupBox2.Controls.SetChildIndex(this.label9, 0);
            this.groupBox2.Controls.SetChildIndex(this.txbAreaStart, 0);
            this.groupBox2.Controls.SetChildIndex(this.txbAreaEnd, 0);
            this.groupBox2.Controls.SetChildIndex(this.label10, 0);
            this.groupBox2.Controls.SetChildIndex(this.label8, 0);
            this.groupBox2.Controls.SetChildIndex(this.txbContractCode, 0);
            this.groupBox2.Controls.SetChildIndex(this.label1, 0);
            this.groupBox2.Controls.SetChildIndex(this.label2, 0);
            this.groupBox2.Controls.SetChildIndex(this.label3, 0);
            this.groupBox2.Controls.SetChildIndex(this.label4, 0);
            this.groupBox2.Controls.SetChildIndex(this.label5, 0);
            this.groupBox2.Controls.SetChildIndex(this.label6, 0);
            this.groupBox2.Controls.SetChildIndex(this.txbBuildingName, 0);
            this.groupBox2.Controls.SetChildIndex(this.txbHouseName, 0);
            this.groupBox2.Controls.SetChildIndex(this.txbKeyCode, 0);
            this.groupBox2.Controls.SetChildIndex(this.txbFloor_Start, 0);
            this.groupBox2.Controls.SetChildIndex(this.label7, 0);
            this.groupBox2.Controls.SetChildIndex(this.txbFloor_End, 0);
            this.groupBox2.Controls.SetChildIndex(this.cmbStatus, 0);
            this.groupBox2.Controls.SetChildIndex(this.cmbDecorationType, 0);
            this.groupBox2.Controls.SetChildIndex(this.labelCreator, 0);
            this.groupBox2.Controls.SetChildIndex(this.cmbOwner, 0);
            // 
            // cmbDecorationType
            // 
            this.cmbDecorationType.DisplayMember = "Name";
            this.cmbDecorationType.ValueMember = "Value";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "Name";
            this.cmbStatus.ValueMember = "Value";
            // 
            // txbFloor_End
            // 
            this.txbFloor_End.Lines = new string[0];
            this.txbFloor_End.Location = new System.Drawing.Point(965, 19);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(944, 21);
            // 
            // txbFloor_Start
            // 
            this.txbFloor_Start.Lines = new string[0];
            this.txbFloor_Start.Location = new System.Drawing.Point(859, 19);
            // 
            // txbKeyCode
            // 
            this.txbKeyCode.Lines = new string[0];
            // 
            // txbHouseName
            // 
            this.txbHouseName.Lines = new string[0];
            // 
            // txbBuildingName
            // 
            this.txbBuildingName.Lines = new string[0];
            // 
            // txbContractCode
            // 
            this.txbContractCode.Lines = new string[0];
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(944, 56);
            // 
            // txbAreaEnd
            // 
            this.txbAreaEnd.Lines = new string[0];
            this.txbAreaEnd.Location = new System.Drawing.Point(965, 52);
            // 
            // txbAreaStart
            // 
            this.txbAreaStart.Lines = new string[0];
            this.txbAreaStart.Location = new System.Drawing.Point(859, 52);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(817, 54);
            // 
            // btnAllocate
            // 
            this.btnAllocate.ClickedMessage = null;
            this.btnAllocate.IngoreCallbackOnce = false;
            this.btnAllocate.Location = new System.Drawing.Point(87, 12);
            this.btnAllocate.Name = "btnAllocate";
            this.btnAllocate.Response = null;
            this.btnAllocate.Size = new System.Drawing.Size(75, 23);
            this.btnAllocate.TabIndex = 2;
            this.btnAllocate.Text = "分配房源";
            this.btnAllocate.UseSelectable = true;
            this.btnAllocate.Click += new System.EventHandler(this.btnAllocate_Click);
            // 
            // labelCreator
            // 
            this.labelCreator.AutoSize = true;
            this.labelCreator.Location = new System.Drawing.Point(30, 87);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(51, 19);
            this.labelCreator.TabIndex = 14;
            this.labelCreator.Text = "业务员";
            // 
            // cmbOwner
            // 
            this.cmbOwner.BindingRequestPropertyName = "form.OwnerID";
            this.cmbOwner.BindingResponsePropertyName = null;
            this.cmbOwner.BindingSourcePropertyName = null;
            this.cmbOwner.DisplayMember = "CnName";
            this.cmbOwner.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cmbOwner.FormattingEnabled = true;
            this.cmbOwner.InitableBindingGroupName = null;
            this.cmbOwner.ItemHeight = 19;
            this.cmbOwner.Location = new System.Drawing.Point(93, 84);
            this.cmbOwner.Name = "cmbOwner";
            this.cmbOwner.Size = new System.Drawing.Size(188, 25);
            this.cmbOwner.TabIndex = 15;
            this.cmbOwner.UseSelectable = true;
            this.cmbOwner.Value = null;
            this.cmbOwner.ValueMember = "ID";
            // 
            // HouseAllocate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 517);
            this.Name = "HouseAllocate";
            this.Text = "房源分配";
            this.Shown += new System.EventHandler(this.HouseAllocate_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.Button btnAllocate;
        private SOAFramework.Client.Controls.Label labelCreator;
        private SOAFramework.Client.Controls.ComboBox cmbOwner;
    }
}