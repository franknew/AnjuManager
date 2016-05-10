namespace Anju.Fangke.Client.Forms
{
    partial class ViewCustomer
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
            this.SuspendLayout();
            // 
            // txbName
            // 
            this.txbName.Lines = new string[0];
            this.txbName.ReadOnly = true;
            this.txbName.UseStyleColors = true;
            // 
            // txbMobile
            // 
            this.txbMobile.Lines = new string[0];
            this.txbMobile.ReadOnly = true;
            // 
            // txbIdentityCode
            // 
            this.txbIdentityCode.Lines = new string[0];
            this.txbIdentityCode.ReadOnly = true;
            // 
            // txbWX
            // 
            this.txbWX.Lines = new string[0];
            this.txbWX.ReadOnly = true;
            // 
            // txbRemark
            // 
            this.txbRemark.Lines = new string[0];
            this.txbRemark.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Visible = false;
            // 
            // ViewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 360);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "ViewCustomer";
            this.Text = "查看业主信息";
            this.Shown += new System.EventHandler(this.ViewCustomer_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}