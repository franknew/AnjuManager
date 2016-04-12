namespace Anju.Fangke.Client.Forms
{
    partial class AddOtherFee
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
            this.cmbOtherFee = new SOAFramework.Client.Controls.ComboBox();
            this.btnAdd = new SOAFramework.Client.Controls.Button();
            this.btnClose = new SOAFramework.Client.Controls.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbOtherFee);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(1, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cmbOtherFee
            // 
            this.cmbOtherFee.BindingRequestPropertyName = null;
            this.cmbOtherFee.BindingResponsePropertyName = null;
            this.cmbOtherFee.BindingSourcePropertyName = null;
            this.cmbOtherFee.DisplayMember = "Name";
            this.cmbOtherFee.FormattingEnabled = true;
            this.cmbOtherFee.InitableBindingGroupName = null;
            this.cmbOtherFee.ItemHeight = 23;
            this.cmbOtherFee.Location = new System.Drawing.Point(6, 17);
            this.cmbOtherFee.Name = "cmbOtherFee";
            this.cmbOtherFee.Size = new System.Drawing.Size(276, 29);
            this.cmbOtherFee.TabIndex = 0;
            this.cmbOtherFee.UseSelectable = true;
            this.cmbOtherFee.Value = null;
            this.cmbOtherFee.ValueMember = "ID";
            // 
            // btnAdd
            // 
            this.btnAdd.ClickedMessage = null;
            this.btnAdd.IngoreCallbackOnce = false;
            this.btnAdd.Location = new System.Drawing.Point(27, 89);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Response = null;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.ClickedMessage = null;
            this.btnClose.CloseFormAfterInvoke = true;
            this.btnClose.IngoreCallbackOnce = false;
            this.btnClose.Location = new System.Drawing.Point(176, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Response = null;
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "关闭";
            this.btnClose.UseSelectable = true;
            // 
            // AddOtherFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 125);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOtherFee";
            this.Resizable = false;
            this.Text = "添加其他费用";
            this.Shown += new System.EventHandler(this.AddOtherFee_Shown);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.ComboBox cmbOtherFee;
        private SOAFramework.Client.Controls.Button btnAdd;
        private SOAFramework.Client.Controls.Button btnClose;
    }
}