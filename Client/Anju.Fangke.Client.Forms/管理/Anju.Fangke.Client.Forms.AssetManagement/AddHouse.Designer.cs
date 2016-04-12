namespace Anju.Fangke.Client.Forms
{
    partial class AddHouse
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
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).BeginInit();
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
            this.txbFloor.Enabled = false;
            this.txbFloor.Lines = new string[0];
            // 
            // txbBuildingName
            // 
            this.txbBuildingName.Enabled = false;
            this.txbBuildingName.Lines = new string[0];
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(362, 268);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(1, 469);
            this.groupBox2.Size = new System.Drawing.Size(776, 56);
            this.groupBox2.Controls.SetChildIndex(this.btnSave, 0);
            // 
            // txbDeposit
            // 
            this.txbDeposit.Lines = new string[] {
        "0"};
            // 
            // txbRentFee
            // 
            this.txbRentFee.Lines = new string[] {
        "0"};
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(362, 0);
            this.groupBox3.Size = new System.Drawing.Size(414, 268);
            // 
            // txbRentRemark
            // 
            this.txbRentRemark.Lines = new string[0];
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(776, 268);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(1, 298);
            this.groupBox4.Size = new System.Drawing.Size(776, 171);
            // 
            // txbArea
            // 
            this.txbArea.Lines = new string[0];
            // 
            // dtExpiredTime
            // 
            this.dtExpiredTime.MinimumSize = new System.Drawing.Size(0, 25);
            // 
            // groupBox5
            // 
            this.groupBox5.Size = new System.Drawing.Size(770, 43);
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(232, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // AddHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 526);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AddHouse";
            this.Text = "新增房";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRentDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SOAFramework.Client.Controls.Button btnSave;
    }
}