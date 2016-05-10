namespace Anju.Fangke.Client.Forms
{
    partial class HouseManagement
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
            this.btnAdd = new SOAFramework.Client.Controls.Button();
            this.btnEdit = new SOAFramework.Client.Controls.Button();
            this.btnDelete = new SOAFramework.Client.Controls.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Controls.SetChildIndex(this.btnQuery, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnClose, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnAdd, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnEdit, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnDelete, 0);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(330, 12);
            // 
            // btnQuery
            // 
            this.btnQuery.RequestName = "QuerySelfAndUnallocateHouseRequest";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(5, 46);
            // 
            // cmbDecorationType
            // 
            this.cmbDecorationType.DisplayMember = "Name";
            this.cmbDecorationType.ValueMember = "Value";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DisplayMember = "Name";
            this.cmbStatus.ValueMember = "Value";
            // 
            // txbFloor_End
            // 
            this.txbFloor_End.Lines = new string[0];
            // 
            // txbFloor_Start
            // 
            this.txbFloor_Start.Lines = new string[0];
            // 
            // txbKeyCode
            // 
            this.txbKeyCode.Lines = new string[0];
            // 
            // txbHouseName
            // 
            this.txbHouseName.Lines = new string[0];
            // 
            // txbBuildingName
            // 
            this.txbBuildingName.Lines = new string[0];
            // 
            // txbContractCode
            // 
            this.txbContractCode.Lines = new string[0];
            // 
            // btnAdd
            // 
            this.btnAdd.ClickedMessage = null;
            this.btnAdd.IngoreCallbackOnce = false;
            this.btnAdd.Location = new System.Drawing.Point(87, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Response = null;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ClickedMessage = null;
            this.btnEdit.IngoreCallbackOnce = false;
            this.btnEdit.Location = new System.Drawing.Point(168, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Response = null;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ClickedMessage = null;
            this.btnDelete.IngoreCallbackOnce = false;
            this.btnDelete.Location = new System.Drawing.Point(249, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Response = null;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // HouseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 517);
            this.Name = "HouseManagement";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "房源管理";
            this.OnShown += new System.EventHandler(this.HouseManagement_OnShown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SOAFramework.Client.Controls.Button btnDelete;
        private SOAFramework.Client.Controls.Button btnEdit;
        private SOAFramework.Client.Controls.Button btnAdd;
    }
}