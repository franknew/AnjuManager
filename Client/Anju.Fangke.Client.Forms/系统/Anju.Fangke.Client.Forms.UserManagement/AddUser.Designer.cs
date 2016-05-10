namespace Anju.Fangke.Client.Forms
{
    partial class AddUser
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
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Location = new System.Drawing.Point(1, 472);
            this.groupBox1.Size = new System.Drawing.Size(566, 46);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(566, 281);
            // 
            // groupBox3
            // 
            this.groupBox3.Size = new System.Drawing.Size(566, 61);
            // 
            // txbUserName
            // 
            this.txbUserName.Lines = new string[0];
            this.txbUserName.UseStyleColors = true;
            // 
            // txbRemark
            // 
            this.txbRemark.Lines = new string[0];
            // 
            // txbAddress
            // 
            this.txbAddress.Lines = new string[0];
            // 
            // txbIdentity
            // 
            this.txbIdentity.Lines = new string[0];
            // 
            // txbWX
            // 
            this.txbWX.Lines = new string[0];
            // 
            // txbQQ
            // 
            this.txbQQ.Lines = new string[0];
            // 
            // txbMobile
            // 
            this.txbMobile.Lines = new string[0];
            // 
            // txbCnName
            // 
            this.txbCnName.Lines = new string[0];
            // 
            // txbID
            // 
            this.txbID.Lines = new string[0];
            // 
            // groupBox4
            // 
            this.groupBox4.Size = new System.Drawing.Size(566, 100);
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(304, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.CheckFormEmpty = true;
            this.btnSave.EnableClickOnceOnAction = true;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(176, 17);
            this.btnSave.Name = "btnSave";
            this.btnSave.RequestName = "AddUserRequest";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            this.btnSave.ClickCallback += new System.EventHandler(this.btnSave_ClickCallback);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 519);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "AddUser";
            this.Text = "新增用户";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.Button btnSave;
        private SOAFramework.Client.Controls.Button btnClose;
    }
}