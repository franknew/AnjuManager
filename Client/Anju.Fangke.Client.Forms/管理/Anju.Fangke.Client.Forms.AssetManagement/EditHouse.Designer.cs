﻿namespace Anju.Fangke.Client.Forms
{
    partial class EditHouse
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
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbRemark
            // 
            this.txbRemark.Lines = new string[0];
            // 
            // txbHouseName
            // 
            this.txbHouseName.Lines = new string[0];
            this.txbHouseName.UseStyleColors = true;
            // 
            // txbFloor
            // 
            this.txbFloor.Lines = new string[0];
            // 
            // txbBuildingName
            // 
            this.txbBuildingName.Lines = new string[0];
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.SetChildIndex(this.btnSave, 0);
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(43, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 454);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "EditHouse";
            this.Text = "编辑房间";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.Button btnSave;
    }
}