namespace Anju.Fangke.Client.Forms
{
    partial class AddHouse
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "新增房";
            this.btnSave = new SOAFramework.Client.Controls.Button();
            this.groupBox2.Controls.Add(this.btnSave);
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
        }

        #endregion
        private SOAFramework.Client.Controls.Button btnSave;
    }
}