namespace Anju.Fangke.Client.Forms
{
    partial class ViewFollowup
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
            this.txbDetail = new SOAFramework.Client.Controls.TextBox();
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbDetail
            // 
            this.txbDetail.BindingRequestPropertyName = null;
            this.txbDetail.BindingResponsePropertyName = null;
            this.txbDetail.BindingSourcePropertyName = null;
            this.txbDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbDetail.EmptyWarning = null;
            this.txbDetail.Lines = new string[0];
            this.txbDetail.Location = new System.Drawing.Point(1, 30);
            this.txbDetail.MaxLength = 32767;
            this.txbDetail.Multiline = true;
            this.txbDetail.Name = "txbDetail";
            this.txbDetail.ReadOnly = true;
            this.txbDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDetail.SelectedText = "";
            this.txbDetail.SelectionLength = 0;
            this.txbDetail.SelectionStart = 0;
            this.txbDetail.Size = new System.Drawing.Size(333, 246);
            this.txbDetail.TabIndex = 0;
            this.txbDetail.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(1, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(117, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // ViewFollowup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 327);
            this.Controls.Add(this.txbDetail);
            this.Controls.Add(this.groupBox1);
            this.Name = "ViewFollowup";
            this.Text = "查看客户跟踪";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.TextBox txbDetail;
        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.Button btnClose;
    }
}