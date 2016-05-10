namespace Anju.Fangke.Client.Forms
{
    partial class AddRole
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(0, 402);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkList
            // 
            this.chkList.Size = new System.Drawing.Size(367, 196);
            // 
            // txbName
            // 
            this.txbName.Lines = new string[0];
            // 
            // txbRemark
            // 
            this.txbRemark.Lines = new string[0];
            // 
            // chkMenu
            // 
            this.chkMenu.Size = new System.Drawing.Size(215, 420);
            // 
            // AddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 484);
            this.Name = "AddRole";
            this.Text = "新增角色信息";
            this.InitControl += new System.EventHandler(this.AddRole_InitControl);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}