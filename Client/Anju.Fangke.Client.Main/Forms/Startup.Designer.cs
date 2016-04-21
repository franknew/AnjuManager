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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.角色管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据字典管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.楼盘管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.房间管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.租客管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房东管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.维护管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他费用管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.账单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMenu = new SOAFramework.Client.Controls.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.nIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.房源分配ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统ToolStripMenuItem,
            this.管理ToolStripMenuItem,
            this.报表ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(1, 30);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1249, 28);
            this.menu.TabIndex = 3;
            this.menu.Text = "menuStrip1";
            // 
            // 系统ToolStripMenuItem
            // 
            this.系统ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.角色管理ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.数据字典管理ToolStripMenuItem,
            this.退出ToolStripMenuItem1});
            this.系统ToolStripMenuItem.Name = "系统ToolStripMenuItem";
            this.系统ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.系统ToolStripMenuItem.Text = "系统";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.toolStripMenuItem1.Text = "员工管理";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 角色管理ToolStripMenuItem
            // 
            this.角色管理ToolStripMenuItem.Name = "角色管理ToolStripMenuItem";
            this.角色管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.角色管理ToolStripMenuItem.Text = "角色管理";
            this.角色管理ToolStripMenuItem.Click += new System.EventHandler(this.角色管理ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.退出ToolStripMenuItem.Text = "重新登录";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click_1);
            // 
            // 数据字典管理ToolStripMenuItem
            // 
            this.数据字典管理ToolStripMenuItem.Name = "数据字典管理ToolStripMenuItem";
            this.数据字典管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.数据字典管理ToolStripMenuItem.Text = "数据字典管理";
            this.数据字典管理ToolStripMenuItem.Visible = false;
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(162, 24);
            this.退出ToolStripMenuItem1.Text = "退出";
            this.退出ToolStripMenuItem1.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.楼盘管理ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.房间管理ToolStripMenuItem,
            this.租客管理ToolStripMenuItem,
            this.房东管理ToolStripMenuItem,
            this.维护管理ToolStripMenuItem,
            this.其他费用管理ToolStripMenuItem,
            this.账单管理ToolStripMenuItem,
            this.房源分配ToolStripMenuItem});
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.管理ToolStripMenuItem.Text = "管理";
            // 
            // 楼盘管理ToolStripMenuItem
            // 
            this.楼盘管理ToolStripMenuItem.Name = "楼盘管理ToolStripMenuItem";
            this.楼盘管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.楼盘管理ToolStripMenuItem.Text = "楼盘房源管理";
            this.楼盘管理ToolStripMenuItem.Click += new System.EventHandler(this.楼盘管理ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(162, 24);
            this.toolStripMenuItem2.Text = "房源管理";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // 房间管理ToolStripMenuItem
            // 
            this.房间管理ToolStripMenuItem.Name = "房间管理ToolStripMenuItem";
            this.房间管理ToolStripMenuItem.ShowShortcutKeys = false;
            this.房间管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.房间管理ToolStripMenuItem.Text = "房租管理";
            this.房间管理ToolStripMenuItem.Visible = false;
            // 
            // 租客管理ToolStripMenuItem
            // 
            this.租客管理ToolStripMenuItem.Name = "租客管理ToolStripMenuItem";
            this.租客管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.租客管理ToolStripMenuItem.Text = "租客管理";
            this.租客管理ToolStripMenuItem.Visible = false;
            // 
            // 房东管理ToolStripMenuItem
            // 
            this.房东管理ToolStripMenuItem.Name = "房东管理ToolStripMenuItem";
            this.房东管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.房东管理ToolStripMenuItem.Text = "业主管理";
            this.房东管理ToolStripMenuItem.Click += new System.EventHandler(this.房东管理ToolStripMenuItem_Click);
            // 
            // 维护管理ToolStripMenuItem
            // 
            this.维护管理ToolStripMenuItem.Name = "维护管理ToolStripMenuItem";
            this.维护管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.维护管理ToolStripMenuItem.Text = "维护管理";
            this.维护管理ToolStripMenuItem.Visible = false;
            // 
            // 其他费用管理ToolStripMenuItem
            // 
            this.其他费用管理ToolStripMenuItem.Name = "其他费用管理ToolStripMenuItem";
            this.其他费用管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.其他费用管理ToolStripMenuItem.Text = "其他费用管理";
            this.其他费用管理ToolStripMenuItem.Visible = false;
            // 
            // 账单管理ToolStripMenuItem
            // 
            this.账单管理ToolStripMenuItem.Name = "账单管理ToolStripMenuItem";
            this.账单管理ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.账单管理ToolStripMenuItem.Text = "账单管理";
            this.账单管理ToolStripMenuItem.Click += new System.EventHandler(this.账单管理ToolStripMenuItem_Click);
            // 
            // 报表ToolStripMenuItem
            // 
            this.报表ToolStripMenuItem.Name = "报表ToolStripMenuItem";
            this.报表ToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.报表ToolStripMenuItem.Text = "报表";
            // 
            // tabMenu
            // 
            this.tabMenu.CloseButtonClick = null;
            this.tabMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMenu.HotTrack = true;
            this.tabMenu.ItemSize = new System.Drawing.Size(54, 24);
            this.tabMenu.Location = new System.Drawing.Point(1, 58);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Size = new System.Drawing.Size(1249, 28);
            this.tabMenu.TabIndex = 4;
            this.tabMenu.TabStop = false;
            this.tabMenu.UseSelectable = true;
            this.tabMenu.SelectedIndexChanged += new System.EventHandler(this.tabMenu_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // ssStatus
            // 
            this.ssStatus.Location = new System.Drawing.Point(1, 381);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Size = new System.Drawing.Size(1249, 22);
            this.ssStatus.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = false;
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(120, 18);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 18);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // lblName
            // 
            this.lblName.AutoSize = false;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 18);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(11, 18);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // 房源分配ToolStripMenuItem
            // 
            this.房源分配ToolStripMenuItem.Name = "房源分配ToolStripMenuItem";
            this.房源分配ToolStripMenuItem.Size = new System.Drawing.Size(162, 24);
            this.房源分配ToolStripMenuItem.Text = "房源分配";
            this.房源分配ToolStripMenuItem.Click += new System.EventHandler(this.房源分配ToolStripMenuItem_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 404);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Startup";
            this.Text = "房客易租管理系统";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.Controls.SetChildIndex(this.menu, 0);
            this.Controls.SetChildIndex(this.tabMenu, 0);
            this.Controls.SetChildIndex(this.ssStatus, 0);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        protected SOAFramework.Client.Controls.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.ToolStripStatusLabel lblName;
        private System.Windows.Forms.Timer timerNow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon nIcon;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 楼盘管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房间管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 租客管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 房东管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 维护管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 角色管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据字典管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他费用管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 账单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 房源分配ToolStripMenuItem;
    }
}

