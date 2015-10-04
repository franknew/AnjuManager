using SOAFramework.Client.Controls;

namespace Anju.Fangke.Client.Main
{
    partial class Startup
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menu = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenu = new SOAFramework.Client.Controls.ClientTabControl();
            this.clientTabPage2 = new SOAFramework.Client.Controls.ClientTabPage();
            this.clientTabPage3 = new SOAFramework.Client.Controls.ClientTabPage();
            this.clientTabPage1 = new SOAFramework.Client.Controls.ClientTabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(1, 30);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1349, 28);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // tabMenu
            // 
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMenu.HotTrack = true;
            this.tabMenu.ItemSize = new System.Drawing.Size(54, 24);
            this.tabMenu.Location = new System.Drawing.Point(1, 58);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(1349, 28);
            this.tabMenu.TabIndex = 4;
            this.tabMenu.UseSelectable = true;
            // 
            // clientTabPage2
            // 
            this.clientTabPage2.HorizontalScrollbarBarColor = true;
            this.clientTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.clientTabPage2.HorizontalScrollbarSize = 10;
            this.clientTabPage2.Location = new System.Drawing.Point(4, 28);
            this.clientTabPage2.Name = "clientTabPage2";
            this.clientTabPage2.Size = new System.Drawing.Size(1341, 0);
            this.clientTabPage2.TabIndex = 0;
            this.clientTabPage2.Text = "clientTabPage2    ";
            this.clientTabPage2.VerticalScrollbarBarColor = true;
            this.clientTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.clientTabPage2.VerticalScrollbarSize = 10;
            // 
            // clientTabPage3
            // 
            this.clientTabPage3.HorizontalScrollbarBarColor = true;
            this.clientTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.clientTabPage3.HorizontalScrollbarSize = 10;
            this.clientTabPage3.Location = new System.Drawing.Point(4, 28);
            this.clientTabPage3.Name = "clientTabPage3";
            this.clientTabPage3.Size = new System.Drawing.Size(1341, 0);
            this.clientTabPage3.TabIndex = 1;
            this.clientTabPage3.Text = "clientTabPage3    ";
            this.clientTabPage3.VerticalScrollbarBarColor = true;
            this.clientTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.clientTabPage3.VerticalScrollbarSize = 10;
            // 
            // clientTabPage1
            // 
            this.clientTabPage1.HorizontalScrollbarBarColor = true;
            this.clientTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.clientTabPage1.HorizontalScrollbarSize = 10;
            this.clientTabPage1.Location = new System.Drawing.Point(4, 28);
            this.clientTabPage1.Name = "clientTabPage1";
            this.clientTabPage1.Size = new System.Drawing.Size(1341, 0);
            this.clientTabPage1.TabIndex = 0;
            this.clientTabPage1.Text = "clientTabPage1        ";
            this.clientTabPage1.VerticalScrollbarBarColor = true;
            this.clientTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.clientTabPage1.VerticalScrollbarSize = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1341, 0);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "tabPage1";
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 787);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.menu);
            this.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip = this.menu;
            this.Name = "Startup";
            this.Text = "房客易租管理系统";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.tabMenu, 0);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        protected SOAFramework.Client.Controls.ClientTabControl tabMenu;
        private ClientTabPage clientTabPage1;
        private System.Windows.Forms.TabPage tabPage1;
        private ClientTabPage clientTabPage2;
        private ClientTabPage clientTabPage3;
    }
}

