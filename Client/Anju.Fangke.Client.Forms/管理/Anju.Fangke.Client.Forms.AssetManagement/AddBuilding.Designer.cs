namespace Anju.Fangke.Client.Forms
{
    partial class AddBuilding
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
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(466, 380);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(1, 410);
            this.groupBox2.Size = new System.Drawing.Size(466, 54);
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.CloseFormAfterInvoke = true;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(89, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            // 
            // AddBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 465);
            this.Name = "AddBuilding";
            this.Text = "新增楼盘";
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false); 

        }

        #endregion
        
        private SOAFramework.Client.Controls.Button btnSave;
    }
}