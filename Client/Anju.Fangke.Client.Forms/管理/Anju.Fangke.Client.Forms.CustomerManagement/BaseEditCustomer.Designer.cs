namespace Anju.Fangke.Client.Forms
{
    partial class BaseEditCustomer
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
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.label3 = new SOAFramework.Client.Controls.Label();
            this.label4 = new SOAFramework.Client.Controls.Label();
            this.label5 = new SOAFramework.Client.Controls.Label();
            this.txbName = new SOAFramework.Client.Controls.TextBox();
            this.txbMobile = new SOAFramework.Client.Controls.TextBox();
            this.txbIdentityCode = new SOAFramework.Client.Controls.TextBox();
            this.txbWX = new SOAFramework.Client.Controls.TextBox();
            this.txbRemark = new SOAFramework.Client.Controls.TextBox();
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "手机";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "身份证";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "微信";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "备注";
            // 
            // txbName
            // 
            this.txbName.BindingRequestPropertyName = "form.Name";
            this.txbName.BindingResponsePropertyName = null;
            this.txbName.BindingSourcePropertyName = "Name";
            this.txbName.EmptyWarning = null;
            this.txbName.Lines = new string[0];
            this.txbName.Location = new System.Drawing.Point(71, 52);
            this.txbName.MaxLength = 32767;
            this.txbName.Name = "txbName";
            this.txbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbName.SelectedText = "";
            this.txbName.SelectionLength = 0;
            this.txbName.SelectionStart = 0;
            this.txbName.Size = new System.Drawing.Size(192, 23);
            this.txbName.TabIndex = 5;
            this.txbName.UseSelectable = true;
            // 
            // txbMobile
            // 
            this.txbMobile.BindingRequestPropertyName = "form.Name";
            this.txbMobile.BindingResponsePropertyName = null;
            this.txbMobile.BindingSourcePropertyName = "Mobile";
            this.txbMobile.EmptyWarning = null;
            this.txbMobile.Lines = new string[0];
            this.txbMobile.Location = new System.Drawing.Point(71, 91);
            this.txbMobile.MaxLength = 32767;
            this.txbMobile.Name = "txbMobile";
            this.txbMobile.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbMobile.SelectedText = "";
            this.txbMobile.SelectionLength = 0;
            this.txbMobile.SelectionStart = 0;
            this.txbMobile.Size = new System.Drawing.Size(192, 23);
            this.txbMobile.TabIndex = 6;
            this.txbMobile.UseSelectable = true;
            // 
            // txbIdentityCode
            // 
            this.txbIdentityCode.BindingRequestPropertyName = "form.Name";
            this.txbIdentityCode.BindingResponsePropertyName = null;
            this.txbIdentityCode.BindingSourcePropertyName = "IdentityCode";
            this.txbIdentityCode.EmptyWarning = null;
            this.txbIdentityCode.Lines = new string[0];
            this.txbIdentityCode.Location = new System.Drawing.Point(71, 130);
            this.txbIdentityCode.MaxLength = 32767;
            this.txbIdentityCode.Name = "txbIdentityCode";
            this.txbIdentityCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbIdentityCode.SelectedText = "";
            this.txbIdentityCode.SelectionLength = 0;
            this.txbIdentityCode.SelectionStart = 0;
            this.txbIdentityCode.Size = new System.Drawing.Size(192, 23);
            this.txbIdentityCode.TabIndex = 7;
            this.txbIdentityCode.UseSelectable = true;
            // 
            // txbWX
            // 
            this.txbWX.BindingRequestPropertyName = "form.Name";
            this.txbWX.BindingResponsePropertyName = null;
            this.txbWX.BindingSourcePropertyName = "WX";
            this.txbWX.EmptyWarning = null;
            this.txbWX.Lines = new string[0];
            this.txbWX.Location = new System.Drawing.Point(71, 170);
            this.txbWX.MaxLength = 32767;
            this.txbWX.Name = "txbWX";
            this.txbWX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbWX.SelectedText = "";
            this.txbWX.SelectionLength = 0;
            this.txbWX.SelectionStart = 0;
            this.txbWX.Size = new System.Drawing.Size(192, 23);
            this.txbWX.TabIndex = 8;
            this.txbWX.UseSelectable = true;
            // 
            // txbRemark
            // 
            this.txbRemark.BindingRequestPropertyName = "form.Name";
            this.txbRemark.BindingResponsePropertyName = null;
            this.txbRemark.BindingSourcePropertyName = "Remark";
            this.txbRemark.EmptyWarning = null;
            this.txbRemark.Lines = new string[0];
            this.txbRemark.Location = new System.Drawing.Point(71, 208);
            this.txbRemark.MaxLength = 32767;
            this.txbRemark.Multiline = true;
            this.txbRemark.Name = "txbRemark";
            this.txbRemark.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRemark.SelectedText = "";
            this.txbRemark.SelectionLength = 0;
            this.txbRemark.SelectionStart = 0;
            this.txbRemark.Size = new System.Drawing.Size(192, 87);
            this.txbRemark.TabIndex = 9;
            this.txbRemark.UseSelectable = true;
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(28, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(188, 318);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // BaseEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 360);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txbRemark);
            this.Controls.Add(this.txbWX);
            this.Controls.Add(this.txbIdentityCode);
            this.Controls.Add(this.txbMobile);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BaseEditCustomer";
            this.Text = "BaseEditCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected SOAFramework.Client.Controls.Label label1;
        protected SOAFramework.Client.Controls.Label label2;
        protected SOAFramework.Client.Controls.Label label3;
        protected SOAFramework.Client.Controls.Label label4;
        protected SOAFramework.Client.Controls.Label label5;
        protected SOAFramework.Client.Controls.TextBox txbName;
        protected SOAFramework.Client.Controls.TextBox txbMobile;
        protected SOAFramework.Client.Controls.TextBox txbIdentityCode;
        protected SOAFramework.Client.Controls.TextBox txbWX;
        protected SOAFramework.Client.Controls.TextBox txbRemark;
        protected SOAFramework.Client.Controls.Button btnSave;
        protected SOAFramework.Client.Controls.Button btnClose;
    }
}