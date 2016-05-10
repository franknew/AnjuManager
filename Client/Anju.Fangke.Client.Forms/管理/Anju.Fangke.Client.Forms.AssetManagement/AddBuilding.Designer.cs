namespace Anju.Fangke.Client.Forms
{
    partial class AddBuilding
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
            ((System.ComponentModel.ISupportInitialize)(this.numFloorCount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(466, 293);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(1, 323);
            this.groupBox2.Size = new System.Drawing.Size(466, 54);
            this.groupBox2.Controls.SetChildIndex(this.btnSave, 0);
            this.groupBox2.Controls.SetChildIndex(this.btnClose, 0);
            // 
            // txbRemark
            // 
            this.txbRemark.Lines = new string[0];
            this.txbRemark.Location = new System.Drawing.Point(90, 197);
            // 
            // txbStreet
            // 
            this.txbStreet.Lines = new string[0];
            this.txbStreet.Location = new System.Drawing.Point(90, 117);
            // 
            // txbName
            // 
            this.txbName.Lines = new string[0];
            this.txbName.Location = new System.Drawing.Point(90, 20);
            this.txbName.UseStyleColors = true;
            // 
            // cmbArea
            // 
            this.cmbArea.Location = new System.Drawing.Point(295, 51);
            // 
            // cmbcity
            // 
            this.cmbcity.Location = new System.Drawing.Point(90, 51);
            // 
            // cmbProvince
            // 
            this.cmbProvince.Location = new System.Drawing.Point(295, 20);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(47, 197);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(47, 117);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(252, 54);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 54);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(252, 24);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 24);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(47, 85);
            // 
            // numFloorCount
            // 
            this.numFloorCount.Location = new System.Drawing.Point(90, 85);
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.CloseFormAfterInvoke = true;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(89, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            // 
            // AddBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 378);
            this.Name = "AddBuilding";
            this.Text = "新增楼盘";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFloorCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private SOAFramework.Client.Controls.Button btnSave;
    }
}