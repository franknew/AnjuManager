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
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(1, 431);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(367, 305);
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
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(0, 305);
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
            // chkIsOurs
            // 
            this.chkIsOurs.Enabled = false;
            // 
            // ViewHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 488);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ViewHouse";
            this.Text = "查看房间信息";
            this.InitControl += new System.EventHandler(this.ViewHouse_InitControl);
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