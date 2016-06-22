namespace Anju.Fangke.Client.Forms
{
    partial class AssetManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("房客易租");
            this.groupBox3 = new SOAFramework.Client.Controls.GroupBox();
            this.dgvHouse = new SOAFramework.Client.Controls.DataGridView();
            this.房间名称 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.所在楼层 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.房型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.装修类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.业主信息 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new SOAFramework.Client.Controls.GroupBox();
            this.btnEditRoom = new SOAFramework.Client.Controls.Button();
            this.btnDelete = new SOAFramework.Client.Controls.Button();
            this.btnEdit = new SOAFramework.Client.Controls.Button();
            this.btnAdd = new SOAFramework.Client.Controls.Button();
            this.tabFloor = new MetroFramework.Controls.MetroTabControl();
            this.groupBox2 = new SOAFramework.Client.Controls.GroupBox();
            this.tvBuilding = new SOAFramework.Client.Controls.TreeView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHouse);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.tabFloor);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(233, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1062, 482);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dgvHouse
            // 
            this.dgvHouse.AllowUserToAddRows = false;
            this.dgvHouse.AllowUserToDeleteRows = false;
            this.dgvHouse.AllowUserToOrderColumns = true;
            this.dgvHouse.AutoGenerateColumns = false;
            this.dgvHouse.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvHouse.BindingRequestPropertyName = null;
            this.dgvHouse.BindingResponsePropertyName = null;
            this.dgvHouse.BindingSourcePropertyName = null;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.房间名称,
            this.所在楼层,
            this.房型,
            this.装修类型,
            this.状态,
            this.备注,
            this.业主信息});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHouse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHouse.Location = new System.Drawing.Point(3, 109);
            this.dgvHouse.Name = "dgvHouse";
            this.dgvHouse.ReadOnly = true;
            this.dgvHouse.RowTemplate.Height = 23;
            this.dgvHouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHouse.Size = new System.Drawing.Size(1056, 370);
            this.dgvHouse.TabIndex = 1;
            this.dgvHouse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHouse_CellContentClick);
            // 
            // 房间名称
            // 
            this.房间名称.DataPropertyName = "House.Name";
            this.房间名称.HeaderText = "房间名称";
            this.房间名称.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.房间名称.Name = "房间名称";
            this.房间名称.ReadOnly = true;
            this.房间名称.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.房间名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.房间名称.Width = 80;
            // 
            // 所在楼层
            // 
            this.所在楼层.DataPropertyName = "House.Floor";
            this.所在楼层.HeaderText = "所在楼层";
            this.所在楼层.Name = "所在楼层";
            this.所在楼层.ReadOnly = true;
            this.所在楼层.Width = 80;
            // 
            // 房型
            // 
            this.房型.DataPropertyName = "House.HouseTypeName";
            this.房型.HeaderText = "房型";
            this.房型.Name = "房型";
            this.房型.ReadOnly = true;
            this.房型.Width = 120;
            // 
            // 装修类型
            // 
            this.装修类型.DataPropertyName = "House.DecorationTypeName";
            this.装修类型.HeaderText = "装修类型";
            this.装修类型.Name = "装修类型";
            this.装修类型.ReadOnly = true;
            this.装修类型.Width = 80;
            // 
            // 状态
            // 
            this.状态.DataPropertyName = "House.StatusName";
            this.状态.HeaderText = "状态";
            this.状态.Name = "状态";
            this.状态.ReadOnly = true;
            this.状态.Width = 80;
            // 
            // 备注
            // 
            this.备注.DataPropertyName = "House.Remark";
            this.备注.HeaderText = "备注";
            this.备注.Name = "备注";
            this.备注.ReadOnly = true;
            this.备注.Width = 200;
            // 
            // 业主信息
            // 
            this.业主信息.DataPropertyName = "Customer.Name";
            this.业主信息.HeaderText = "业主信息";
            this.业主信息.Name = "业主信息";
            this.业主信息.ReadOnly = true;
            this.业主信息.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.业主信息.Text = "查看业主";
            this.业主信息.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditRoom);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1056, 53);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnEditRoom
            // 
            this.btnEditRoom.ClickedMessage = null;
            this.btnEditRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditRoom.IngoreCallbackOnce = false;
            this.btnEditRoom.Location = new System.Drawing.Point(249, 20);
            this.btnEditRoom.Name = "btnEditRoom";
            this.btnEditRoom.Response = null;
            this.btnEditRoom.Size = new System.Drawing.Size(75, 23);
            this.btnEditRoom.TabIndex = 3;
            this.btnEditRoom.Text = "配置房间";
            this.btnEditRoom.UseSelectable = true;
            this.btnEditRoom.Visible = false;
            this.btnEditRoom.Click += new System.EventHandler(this.btnEditRoom_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ClickedMessage = null;
            this.btnDelete.IngoreCallbackOnce = false;
            this.btnDelete.Location = new System.Drawing.Point(168, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Response = null;
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.ClickedMessage = null;
            this.btnEdit.IngoreCallbackOnce = false;
            this.btnEdit.Location = new System.Drawing.Point(87, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Response = null;
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "编辑";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ClickedMessage = null;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdd.IngoreCallbackOnce = false;
            this.btnAdd.Location = new System.Drawing.Point(6, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Response = null;
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabFloor
            // 
            this.tabFloor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabFloor.Location = new System.Drawing.Point(3, 17);
            this.tabFloor.Name = "tabFloor";
            this.tabFloor.Size = new System.Drawing.Size(1056, 39);
            this.tabFloor.TabIndex = 0;
            this.tabFloor.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tvBuilding);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(5, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 482);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // tvBuilding
            // 
            this.tvBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBuilding.Location = new System.Drawing.Point(3, 17);
            this.tvBuilding.Name = "tvBuilding";
            treeNode1.Name = "nodeRoot";
            treeNode1.Text = "房客易租";
            this.tvBuilding.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvBuilding.Size = new System.Drawing.Size(222, 462);
            this.tvBuilding.TabIndex = 0;
            this.tvBuilding.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvBuilding_NodeMouseClick);
            // 
            // AssetManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 517);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "AssetManagement";
            this.Padding = new System.Windows.Forms.Padding(5, 30, 5, 5);
            this.Text = "楼盘房源管理";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SOAFramework.Client.Controls.GroupBox groupBox3;
        private SOAFramework.Client.Controls.GroupBox groupBox2;
        private SOAFramework.Client.Controls.TreeView tvBuilding;
        private SOAFramework.Client.Controls.DataGridView dgvHouse;
        private SOAFramework.Client.Controls.GroupBox groupBox1;
        private SOAFramework.Client.Controls.Button btnDelete;
        private SOAFramework.Client.Controls.Button btnEdit;
        private SOAFramework.Client.Controls.Button btnAdd;
        private SOAFramework.Client.Controls.Button btnEditRoom;
        private MetroFramework.Controls.MetroTabControl tabFloor;
        private System.Windows.Forms.DataGridViewLinkColumn 房间名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 所在楼层;
        private System.Windows.Forms.DataGridViewTextBoxColumn 房型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 装修类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注;
        private System.Windows.Forms.DataGridViewLinkColumn 业主信息;
    }
}