namespace Anju.Fangke.Client.Forms
{
    partial class ChangeSelfPassword
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
            this.txbOldPassword = new SOAFramework.Client.Controls.TextBox();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.txbNewPassword = new SOAFramework.Client.Controls.TextBox();
            this.txbConfirmPassword = new SOAFramework.Client.Controls.TextBox();
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.SuspendLayout();
            // 
            // txbOldPassword
            // 
            this.txbOldPassword.BindingRequestPropertyName = null;
            this.txbOldPassword.BindingResponsePropertyName = null;
            this.txbOldPassword.BindingSourcePropertyName = null;
            this.txbOldPassword.EmptyWarning = null;
            this.txbOldPassword.Lines = new string[0];
            this.txbOldPassword.Location = new System.Drawing.Point(88, 56);
            this.txbOldPassword.MaxLength = 32767;
            this.txbOldPassword.Name = "txbOldPassword";
            this.txbOldPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbOldPassword.SelectedText = "";
            this.txbOldPassword.SelectionLength = 0;
            this.txbOldPassword.SelectionStart = 0;
            this.txbOldPassword.Size = new System.Drawing.Size(219, 23);
            this.txbOldPassword.TabIndex = 0;
            this.txbOldPassword.UseSelectable = true;
            this.txbOldPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "旧密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "确认密码";
            // 
            // txbNewPassword
            // 
            this.txbNewPassword.BindingRequestPropertyName = null;
            this.txbNewPassword.BindingResponsePropertyName = null;
            this.txbNewPassword.BindingSourcePropertyName = null;
            this.txbNewPassword.EmptyWarning = null;
            this.txbNewPassword.Lines = new string[0];
            this.txbNewPassword.Location = new System.Drawing.Point(88, 92);
            this.txbNewPassword.MaxLength = 32767;
            this.txbNewPassword.Name = "txbNewPassword";
            this.txbNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbNewPassword.SelectedText = "";
            this.txbNewPassword.SelectionLength = 0;
            this.txbNewPassword.SelectionStart = 0;
            this.txbNewPassword.Size = new System.Drawing.Size(219, 23);
            this.txbNewPassword.TabIndex = 4;
            this.txbNewPassword.UseSelectable = true;
            this.txbNewPassword.UseSystemPasswordChar = true;
            // 
            // txbConfirmPassword
            // 
            this.txbConfirmPassword.BindingRequestPropertyName = null;
            this.txbConfirmPassword.BindingResponsePropertyName = null;
            this.txbConfirmPassword.BindingSourcePropertyName = null;
            this.txbConfirmPassword.EmptyWarning = null;
            this.txbConfirmPassword.Lines = new string[0];
            this.txbConfirmPassword.Location = new System.Drawing.Point(88, 128);
            this.txbConfirmPassword.MaxLength = 32767;
            this.txbConfirmPassword.Name = "txbConfirmPassword";
            this.txbConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbConfirmPassword.SelectedText = "";
            this.txbConfirmPassword.SelectionLength = 0;
            this.txbConfirmPassword.SelectionStart = 0;
            this.txbConfirmPassword.Size = new System.Drawing.Size(219, 23);
            this.txbConfirmPassword.TabIndex = 5;
            this.txbConfirmPassword.UseSelectable = true;
            this.txbConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(88, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(185, 176);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // ChangeSelfPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 229);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbConfirmPassword);
            this.Controls.Add(this.txbNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbOldPassword);
            this.Name = "ChangeSelfPassword";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SOAFramework.Client.Controls.TextBox txbOldPassword;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.Label label2;
        private SOAFramework.Client.Controls.Label label3;
        private SOAFramework.Client.Controls.TextBox txbNewPassword;
        private SOAFramework.Client.Controls.TextBox txbConfirmPassword;
        private SOAFramework.Client.Controls.Button btnSave;
        private SOAFramework.Client.Controls.Button btnClose;
    }
}