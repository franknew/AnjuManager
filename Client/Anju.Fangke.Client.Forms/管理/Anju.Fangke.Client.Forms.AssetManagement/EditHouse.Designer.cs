namespace Anju.Fangke.Client.Forms
{
    partial class EditHouse
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Location = new System.Drawing.Point(1, 437);
            this.groupBox2.Size = new System.Drawing.Size(367, 56);
            this.groupBox2.Controls.SetChildIndex(this.btnSave, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(367, 311);
            // 
            // txbArea
            // 
            this.txbArea.Lines = new string[0];
            this.txbArea.Text = "";
            // 
            // txbFloor
            // 
            this.txbFloor.Lines = new string[0];
            this.txbFloor.ReadOnly = false;
            // 
            // txbBuildingName
            // 
            this.txbBuildingName.Enabled = false;
            this.txbBuildingName.Lines = new string[0];
            // 
            // txbRemark
            // 
            this.txbRemark.Lines = new string[0];
            // 
            // txbHouseName
            // 
            this.txbHouseName.Lines = new string[0];
            this.txbHouseName.UseStyleColors = true;
            // 
            // textBox1
            // 
            this.textBox1.Lines = new string[0];
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(1, 341);
            this.groupBox3.Size = new System.Drawing.Size(367, 96);
            // 
            // txbMobile
            // 
            this.txbMobile.Lines = new string[0];
            // 
            // btnSave
            // 
            this.btnSave.ClickedMessage = null;
            this.btnSave.IngoreCallbackOnce = false;
            this.btnSave.Location = new System.Drawing.Point(86, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Response = null;
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // EditHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 494);
            this.Name = "EditHouse";
            this.Text = "编辑房间信息";
            this.InitControl += new System.EventHandler(this.EditHouse_InitControl);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.Button btnSave;
    }
}