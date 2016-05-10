namespace Anju.Fangke.Client.Forms
{
    partial class ViewHouse
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
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // numCost
            // 
            this.numCost.ReadOnly = true;
            // 
            // txbArea
            // 
            this.txbArea.Lines = new string[] {
        "0"};
            this.txbArea.ReadOnly = true;
            // 
            // txbFloor
            // 
            this.txbFloor.Lines = new string[] {
        "1"};
            this.txbFloor.ReadOnly = true;
            // 
            // txbRemark
            // 
            this.txbRemark.Lines = new string[0];
            this.txbRemark.ReadOnly = true;
            // 
            // txbHouseName
            // 
            this.txbHouseName.Lines = new string[0];
            this.txbHouseName.ReadOnly = true;
            // 
            // cmbToilet
            // 
            this.cmbToilet.Enabled = false;
            // 
            // cmbHall
            // 
            this.cmbHall.Enabled = false;
            // 
            // cmbRoom
            // 
            this.cmbRoom.Enabled = false;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Enabled = false;
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.Enabled = false;
            // 
            // cmbDecorationType
            // 
            this.cmbDecorationType.Enabled = false;
            // 
            // txbMobile
            // 
            this.txbMobile.Lines = new string[0];
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Visible = false;
            // 
            // cmbBuilding
            // 
            this.cmbBuilding.Enabled = false;
            // 
            // panel2
            // 
            this.panel2.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(327, 20);
            // 
            // ViewHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 488);
            this.Name = "ViewHouse";
            this.Text = "查看房间信息";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}