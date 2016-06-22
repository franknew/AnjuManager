namespace SOAFramework.Client.Controls.Pager
{
    partial class Pager
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txbPageSize = new SOAFramework.Client.Controls.TextBox();
            this.txbRecordCount = new SOAFramework.Client.Controls.TextBox();
            this.txbCurrentPageIndex = new SOAFramework.Client.Controls.TextBox();
            this.lblFrist = new SOAFramework.Client.Controls.Label();
            this.pnlPages = new SOAFramework.Client.Controls.Panel();
            this.lblPageCount = new SOAFramework.Client.Controls.Label();
            this.label2 = new SOAFramework.Client.Controls.Label();
            this.lblRecordCount = new SOAFramework.Client.Controls.Label();
            this.label1 = new SOAFramework.Client.Controls.Label();
            this.lblLast = new SOAFramework.Client.Controls.Label();
            this.txbPage = new SOAFramework.Client.Controls.TextBox();
            this.txbGo = new SOAFramework.Client.Controls.Button();
            this.SuspendLayout();
            // 
            // txbPageSize
            // 
            this.txbPageSize.BindingRequestPropertyName = "form.PageSize";
            this.txbPageSize.BindingResponsePropertyName = null;
            this.txbPageSize.BindingSourcePropertyName = "RecordCount";
            this.txbPageSize.EmptyWarning = null;
            this.txbPageSize.Lines = new string[] {
        "20"};
            this.txbPageSize.Location = new System.Drawing.Point(279, -4);
            this.txbPageSize.MaxLength = 32767;
            this.txbPageSize.Name = "txbPageSize";
            this.txbPageSize.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPageSize.SelectedText = "";
            this.txbPageSize.SelectionLength = 0;
            this.txbPageSize.SelectionStart = 0;
            this.txbPageSize.Size = new System.Drawing.Size(37, 23);
            this.txbPageSize.TabIndex = 12;
            this.txbPageSize.Text = "20";
            this.txbPageSize.UseSelectable = true;
            this.txbPageSize.Visible = false;
            // 
            // txbRecordCount
            // 
            this.txbRecordCount.BindingRequestPropertyName = null;
            this.txbRecordCount.BindingResponsePropertyName = "RecordCount";
            this.txbRecordCount.BindingSourcePropertyName = "RecordCount";
            this.txbRecordCount.EmptyWarning = null;
            this.txbRecordCount.Lines = new string[] {
        "0"};
            this.txbRecordCount.Location = new System.Drawing.Point(236, 0);
            this.txbRecordCount.MaxLength = 32767;
            this.txbRecordCount.Name = "txbRecordCount";
            this.txbRecordCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbRecordCount.SelectedText = "";
            this.txbRecordCount.SelectionLength = 0;
            this.txbRecordCount.SelectionStart = 0;
            this.txbRecordCount.Size = new System.Drawing.Size(37, 23);
            this.txbRecordCount.TabIndex = 11;
            this.txbRecordCount.Text = "0";
            this.txbRecordCount.UseSelectable = true;
            this.txbRecordCount.Visible = false;
            // 
            // txbCurrentPageIndex
            // 
            this.txbCurrentPageIndex.BindingRequestPropertyName = "form.CurrentIndex";
            this.txbCurrentPageIndex.BindingResponsePropertyName = null;
            this.txbCurrentPageIndex.BindingSourcePropertyName = null;
            this.txbCurrentPageIndex.EmptyWarning = null;
            this.txbCurrentPageIndex.Lines = new string[] {
        "1"};
            this.txbCurrentPageIndex.Location = new System.Drawing.Point(199, -4);
            this.txbCurrentPageIndex.MaxLength = 32767;
            this.txbCurrentPageIndex.Name = "txbCurrentPageIndex";
            this.txbCurrentPageIndex.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbCurrentPageIndex.SelectedText = "";
            this.txbCurrentPageIndex.SelectionLength = 0;
            this.txbCurrentPageIndex.SelectionStart = 0;
            this.txbCurrentPageIndex.Size = new System.Drawing.Size(31, 23);
            this.txbCurrentPageIndex.TabIndex = 10;
            this.txbCurrentPageIndex.Text = "1";
            this.txbCurrentPageIndex.UseSelectable = true;
            this.txbCurrentPageIndex.Visible = false;
            // 
            // lblFrist
            // 
            this.lblFrist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFrist.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblFrist.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFrist.Location = new System.Drawing.Point(352, 0);
            this.lblFrist.Name = "lblFrist";
            this.lblFrist.Size = new System.Drawing.Size(38, 19);
            this.lblFrist.TabIndex = 0;
            this.lblFrist.Text = "首页";
            this.lblFrist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFrist.UseCustomBackColor = true;
            this.lblFrist.UseCustomForeColor = true;
            this.lblFrist.UseStyleColors = true;
            this.lblFrist.Visible = false;
            this.lblFrist.Click += new System.EventHandler(this.lblFrist_Click);
            // 
            // pnlPages
            // 
            this.pnlPages.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPages.Location = new System.Drawing.Point(390, 0);
            this.pnlPages.Name = "pnlPages";
            this.pnlPages.Size = new System.Drawing.Size(294, 19);
            this.pnlPages.TabIndex = 9;
            // 
            // lblPageCount
            // 
            this.lblPageCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPageCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPageCount.Location = new System.Drawing.Point(164, 0);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(53, 19);
            this.lblPageCount.TabIndex = 8;
            this.lblPageCount.Text = "0";
            this.lblPageCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPageCount.UseCustomBackColor = true;
            this.lblPageCount.UseCustomForeColor = true;
            this.lblPageCount.UseStyleColors = true;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(111, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "页数：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.UseCustomBackColor = true;
            this.label2.UseCustomForeColor = true;
            this.label2.UseStyleColors = true;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRecordCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRecordCount.Location = new System.Drawing.Point(53, 0);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(58, 19);
            this.lblRecordCount.TabIndex = 6;
            this.lblRecordCount.Text = "0";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRecordCount.UseCustomBackColor = true;
            this.lblRecordCount.UseCustomForeColor = true;
            this.lblRecordCount.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "总计：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.UseCustomBackColor = true;
            this.label1.UseCustomForeColor = true;
            this.label1.UseStyleColors = true;
            // 
            // lblLast
            // 
            this.lblLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLast.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLast.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblLast.Location = new System.Drawing.Point(684, 0);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(38, 19);
            this.lblLast.TabIndex = 2;
            this.lblLast.Text = "尾页";
            this.lblLast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLast.UseCustomBackColor = true;
            this.lblLast.UseCustomForeColor = true;
            this.lblLast.UseStyleColors = true;
            this.lblLast.Visible = false;
            this.lblLast.Click += new System.EventHandler(this.lblLast_Click);
            // 
            // txbPage
            // 
            this.txbPage.BindingRequestPropertyName = null;
            this.txbPage.BindingResponsePropertyName = null;
            this.txbPage.BindingSourcePropertyName = null;
            this.txbPage.Dock = System.Windows.Forms.DockStyle.Right;
            this.txbPage.EmptyWarning = null;
            this.txbPage.InputType = SOAFramework.Client.Controls.InputType.整数;
            this.txbPage.Lines = new string[0];
            this.txbPage.Location = new System.Drawing.Point(722, 0);
            this.txbPage.MaxLength = 32767;
            this.txbPage.Name = "txbPage";
            this.txbPage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbPage.SelectedText = "";
            this.txbPage.SelectionLength = 0;
            this.txbPage.SelectionStart = 0;
            this.txbPage.Size = new System.Drawing.Size(57, 19);
            this.txbPage.TabIndex = 4;
            this.txbPage.UseSelectable = true;
            // 
            // txbGo
            // 
            this.txbGo.ClickedMessage = null;
            this.txbGo.Dock = System.Windows.Forms.DockStyle.Right;
            this.txbGo.IngoreCallbackOnce = false;
            this.txbGo.Location = new System.Drawing.Point(779, 0);
            this.txbGo.Name = "txbGo";
            this.txbGo.Response = null;
            this.txbGo.Size = new System.Drawing.Size(32, 19);
            this.txbGo.TabIndex = 3;
            this.txbGo.Text = "跳转";
            this.txbGo.UseSelectable = true;
            this.txbGo.Click += new System.EventHandler(this.txbGo_Click);
            // 
            // Pager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txbPageSize);
            this.Controls.Add(this.txbRecordCount);
            this.Controls.Add(this.txbCurrentPageIndex);
            this.Controls.Add(this.lblFrist);
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txbPage);
            this.Controls.Add(this.txbGo);
            this.Name = "Pager";
            this.Size = new System.Drawing.Size(811, 19);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblFrist;
        private Label lblLast;
        private Button txbGo;
        private TextBox txbPage;
        private Label label1;
        private Label lblRecordCount;
        private Label label2;
        private Label lblPageCount;
        private Panel pnlPages;
        private TextBox txbCurrentPageIndex;
        private TextBox txbRecordCount;
        private TextBox txbPageSize;
    }
}
