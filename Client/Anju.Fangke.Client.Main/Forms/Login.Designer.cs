﻿namespace Anju.Fangke.Client.Main
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txbUserName = new SOAFramework.Client.Controls.TextBox();
            this.txbPassword = new SOAFramework.Client.Controls.TextBox();
            this.btnLogin = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.chkRemberMe = new SOAFramework.Client.Controls.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码：";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(1, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 111);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txbUserName
            // 
            this.txbUserName.BindingRequestPropertyName = null;
            this.txbUserName.BindingResponsePropertyName = null;
            this.txbUserName.BindingSourcePropertyName = null;
            this.txbUserName.CanbeEmpty = false;
            this.txbUserName.EmptyWarning = "请输入用户名";
            this.txbUserName.Lines = new string[0];
            this.txbUserName.Location = new System.Drawing.Point(97, 150);
            this.txbUserName.MaxLength = 32767;
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbUserName.SelectedText = "";
            this.txbUserName.SelectionLength = 0;
            this.txbUserName.SelectionStart = 0;
            this.txbUserName.Size = new System.Drawing.Size(179, 23);
            this.txbUserName.TabIndex = 1;
            this.txbUserName.UseSelectable = true;
            // 
            // txbPassword
            // 
            this.txbPassword.BindingRequestPropertyName = null;
            this.txbPassword.BindingResponsePropertyName = null;
            this.txbPassword.BindingSourcePropertyName = null;
            this.txbPassword.CanbeEmpty = false;
            this.txbPassword.EmptyWarning = "请输入密码";
            this.txbPassword.Lines = new string[0];
            this.txbPassword.Location = new System.Drawing.Point(97, 181);
            this.txbPassword.MaxLength = 32767;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPassword.SelectedText = "";
            this.txbPassword.SelectionLength = 0;
            this.txbPassword.SelectionStart = 0;
            this.txbPassword.Size = new System.Drawing.Size(179, 23);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.UseSelectable = true;
            this.txbPassword.UseSystemPasswordChar = true;
            this.txbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPassword_KeyPress);
            // 
            // btnLogin
            // 
            this.btnLogin.CheckFormEmpty = true;
            this.btnLogin.ClickedMessage = null;
            this.btnLogin.IngoreCallbackOnce = false;
            this.btnLogin.Location = new System.Drawing.Point(30, 243);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Response = null;
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseSelectable = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(181, 243);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "退出";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkRemberMe
            // 
            this.chkRemberMe.AutoSize = true;
            this.chkRemberMe.BindingChecked = 0;
            this.chkRemberMe.BindingRequestPropertyName = null;
            this.chkRemberMe.BindingResponsePropertyName = null;
            this.chkRemberMe.BindingSourcePropertyName = null;
            this.chkRemberMe.Group = null;
            this.chkRemberMe.Location = new System.Drawing.Point(97, 215);
            this.chkRemberMe.Name = "chkRemberMe";
            this.chkRemberMe.Size = new System.Drawing.Size(59, 15);
            this.chkRemberMe.TabIndex = 3;
            this.chkRemberMe.Text = "记住我";
            this.chkRemberMe.UseSelectable = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.ControlBox = false;
            this.Controls.Add(this.chkRemberMe);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbUserName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.Text = "房客易租管理系统";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SOAFramework.Client.Controls.Label label1;
        private SOAFramework.Client.Controls.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private SOAFramework.Client.Controls.TextBox txbUserName;
        private SOAFramework.Client.Controls.TextBox txbPassword;
        private SOAFramework.Client.Controls.Button btnLogin;
        private SOAFramework.Client.Controls.Button btnClose;
        private SOAFramework.Client.Controls.CheckBox chkRemberMe;
    }
}