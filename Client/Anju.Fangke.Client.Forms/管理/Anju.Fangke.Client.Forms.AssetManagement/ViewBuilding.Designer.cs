namespace Anju.Fangke.Client.Forms
{
    partial class ViewBuilding
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFloorCount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(171, 20);
            // 
            // txbRemark
            // 
            this.txbRemark.Lines = new string[0];
            this.txbRemark.ReadOnly = true;
            // 
            // txbStreet
            // 
            this.txbStreet.Lines = new string[0];
            this.txbStreet.ReadOnly = true;
            // 
            // txbName
            // 
            this.txbName.Lines = new string[0];
            this.txbName.ReadOnly = true;
            this.txbName.UseStyleColors = true;
            // 
            // cmbArea
            // 
            this.cmbArea.Enabled = false;
            // 
            // cmbcity
            // 
            this.cmbcity.Enabled = false;
            // 
            // cmbProvince
            // 
            this.cmbProvince.Enabled = false;
            // 
            // numFloorCount
            // 
            this.numFloorCount.ReadOnly = true;
            // 
            // ViewBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 411);
            this.Name = "ViewBuilding";
            this.Text = "查看楼盘信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numFloorCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}