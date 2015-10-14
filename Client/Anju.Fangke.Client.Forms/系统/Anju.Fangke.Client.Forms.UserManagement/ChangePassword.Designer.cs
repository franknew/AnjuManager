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
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.ClickCallback = null;
            this.btnChangePassword.IngoreCallbackOnce = false;
            this.btnChangePassword.InitClick = null;
            this.btnChangePassword.Location = new System.Drawing.Point(80, 100);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Response = null;
            this.btnChangePassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassword.TabIndex = 0;
            this.btnChangePassword.Text = "保存";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.ClickCallback = null;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.InitClick = null;
            this.btnClose.Location = new System.Drawing.Point(213, 100);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "新密码：";
            // 
            // btnPassword
            // 
            this.btnPassword.BindingRequestPropertyName = null;
            this.btnPassword.BindingResponsePropertyName = null;
            this.btnPassword.Lines = new string[0];
            this.btnPassword.Location = new System.Drawing.Point(100, 52);
            this.btnPassword.MaxLength = 32767;
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.btnPassword.SelectedText = "";
            this.btnPassword.Size = new System.Drawing.Size(218, 23);
            this.btnPassword.TabIndex = 3;
            this.btnPassword.UseSelectable = true;
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 140);
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
    }
}