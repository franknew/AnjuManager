namespace Anju.Fangke.Client.Forms
{
    partial class BaseEditFollowup
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
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.txbRemark = new SOAFramework.Client.Controls.TextBox();
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbRemark);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(1, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 191);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txbRemark
            // 
            this.txbRemark.BindingRequestPropertyName = null;
            this.txbRemark.BindingResponsePropertyName = null;
            this.txbRemark.BindingSourcePropertyName = null;
            this.txbRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbRemark.EmptyWarning = null;
            this.txbRemark.Lines = new string[0];
            this.txbRemark.Location = new System.Drawing.Point(3, 17);
            this.txbRemark.MaxLength = 32767;
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRemark.SelectedText = "";
            this.txbRemark.SelectionLength = 0;
            this.txbRemark.SelectionStart = 0;
            this.txbRemark.Size = new System.Drawing.Size(327, 171);
            this.txbRemark.TabIndex = 0;
            this.txbRemark.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(43, 224);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(186, 224);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // BaseEditFollowup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 253);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaseEditFollowup";
            this.Text = "增加跟进";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected SOAFramework.Client.Controls.GroupBox groupBox1;
        protected SOAFramework.Client.Controls.TextBox txbRemark;
        public SOAFramework.Client.Controls.Button btnSave;
        public SOAFramework.Client.Controls.Button btnClose;
    }
}