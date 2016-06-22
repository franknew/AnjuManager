namespace Anju.Fangke.Client.Forms
{
    partial class TakeHouse
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
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numbericUpDown1
            // 
            this.numbericUpDown1.BindingSourcePropertyName = "RentFee";
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
            // 
            // dateTimeComboPicker2
            // 
            this.dateTimeComboPicker2.BindingSourcePropertyName = "RentDateEnd";
            this.dateTimeComboPicker2.MinimumSize = new System.Drawing.Size(0, 25);
            // 
            // dateTimeComboPicker1
            // 
            this.dateTimeComboPicker1.BindingSourcePropertyName = "RentDateStart";
            this.dateTimeComboPicker1.MinimumSize = new System.Drawing.Size(0, 25);
            // 
            // btnSave
            // 
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TaskHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 305);
            this.Name = "TaskHouse";
            this.Text = "收房";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}