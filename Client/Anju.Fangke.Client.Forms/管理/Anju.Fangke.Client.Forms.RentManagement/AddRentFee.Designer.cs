namespace Anju.Fangke.Client.Forms
{
    partial class AddRentFee
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
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateTimeComboPicker2
            // 
            this.dateTimeComboPicker2.MinimumSize = new System.Drawing.Size(0, 25);
            // 
            // dateTimeComboPicker1
            // 
            this.dateTimeComboPicker1.MinimumSize = new System.Drawing.Size(0, 25);
            // 
            // textBox4
            // 
            this.textBox4.Lines = new string[0];
            // 
            // textBox3
            // 
            this.textBox3.Lines = new string[0];
            // 
            // textBox2
            // 
            this.textBox2.Lines = new string[0];
            // 
            // textBox1
            // 
            this.textBox1.Lines = new string[0];
            this.textBox1.UseStyleColors = true;
            // 
            // AddRentFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 537);
            this.Name = "AddRentFee";
            this.Text = "新增租赁信息";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}