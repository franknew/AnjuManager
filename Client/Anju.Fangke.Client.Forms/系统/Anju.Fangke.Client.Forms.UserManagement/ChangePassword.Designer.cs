namespace Anju.Fangke.Client.Forms
{
    partial class ChangePassword
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
            this.btnChangePassword = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.btnPassword = new SOAFramework.Client.Controls.TextBox();
            this.txbUserName = new SOAFramework.Client.Controls.TextBox();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.CheckFormEmpty = true;
            this.btnChangePassword.ClickedMessage = null;
            this.btnChangePassword.CloseFormAfterInvoke = true;
            this.btnChangePassword.EnableSyncClick = true;
            this.btnChangePassword.IngoreCallbackOnce = false;
            this.btnChangePassword.Location = new System.Drawing.Point(79, 135);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.RequestName = "ChangePasswordRequest";
            this.btnChangePassword.Response = null;
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 1;
            this.btnChangePassword.Text = "保存";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(212, 135);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "新密码：";
            // 
            // btnPassword
            // 
            this.btnPassword.BindingRequestPropertyName = "Password";
            this.btnPassword.BindingResponsePropertyName = null;
            this.btnPassword.BindingSourcePropertyName = null;
            this.btnPassword.CanbeEmpty = false;
            this.btnPassword.EmptyWarning = "请输入新密码";
            this.btnPassword.Lines = new string[0];
            this.btnPassword.Location = new System.Drawing.Point(99, 88);
            this.btnPassword.MaxLength = 32767;
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btnPassword.SelectedText = "";
            this.btnPassword.Size = new System.Drawing.Size(218, 23);
            this.btnPassword.TabIndex = 0;
            this.btnPassword.UseSelectable = true;
            // 
            // txbUserName
            // 
            this.txbUserName.BindingRequestPropertyName = "UserName";
            this.txbUserName.BindingResponsePropertyName = null;
            this.txbUserName.BindingSourcePropertyName = "Name";
            this.txbUserName.EmptyWarning = null;
            this.txbUserName.Enabled = false;
            this.txbUserName.Lines = new string[0];
            this.txbUserName.Location = new System.Drawing.Point(99, 50);
            this.txbUserName.MaxLength = 32767;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUserName.SelectedText = "";
            this.txbUserName.Size = new System.Drawing.Size(218, 23);
            this.txbUserName.TabIndex = 3;
            this.txbUserName.TabStop = false;
            this.txbUserName.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "用户名：";
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 171);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.btnPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnChangePassword);
            this.Name = "ChangePassword";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SOAFramework.Client.Controls.Button btnChangePassword;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.TextBox btnPassword;
        private SOAFramework.Client.Controls.TextBox txbUserName;
        private SOAFramework.Client.Controls.Label label2;
    }
}