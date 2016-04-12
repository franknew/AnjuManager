namespace Anju.Fangke.Client.Forms
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
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.txbFloor.Lines = new string[0];
            this.txbFloor.ReadOnly = false;
            // 
            // txbBuildingName
            // 
            this.txbBuildingName.Enabled = false;
            this.txbBuildingName.Lines = new string[0];
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(362, 270);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(1, 455);
            this.groupBox2.Size = new System.Drawing.Size(778, 56);
            this.groupBox2.Controls.SetChildIndex(this.btnSave, 0);
            // 
            // txbDeposit
            // 
            this.txbDeposit.Lines = new string[0];
            this.txbDeposit.Text = "";
            // 
            // txbRentFee
            // 
            this.txbRentFee.Lines = new string[0];
            this.txbRentFee.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(362, 0);
            // 
            // txbRentRemark
            // 
            this.txbRentRemark.Lines = new string[0];
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(778, 270);
            // 
            // groupBox4
            // 
            this.groupBox4.Size = new System.Drawing.Size(778, 155);
            // 
            // txbArea
            // 
            this.txbArea.Lines = new string[0];
            // 
            // dtExpiredTime
            // 
            this.dtExpiredTime.MinimumSize = new System.Drawing.Size(0, 25);
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(232, 20);
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
            this.ClientSize = new System.Drawing.Size(780, 512);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "EditHouse";
            this.Text = "编辑房间";
            this.InitControl += new System.EventHandler(this.EditHouse_InitControl);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRentDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCycle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.Button btnSave;
    }
}