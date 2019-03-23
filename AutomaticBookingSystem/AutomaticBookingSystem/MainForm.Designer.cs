namespace AutomaticBookingSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增添个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未出行订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.已购订单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.线路选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.线路管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.订单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.问题咨询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.订单查询ToolStripMenuItem,
            this.线路选择ToolStripMenuItem,
            this.ToolStripMenuItem,
            this.问题咨询ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看个人信息ToolStripMenuItem,
            this.增添个人信息ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.用户管理ToolStripMenuItem.Text = "个人信息(&I)";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 查看个人信息ToolStripMenuItem
            // 
            this.查看个人信息ToolStripMenuItem.Name = "查看个人信息ToolStripMenuItem";
            this.查看个人信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查看个人信息ToolStripMenuItem.Text = "查看个人信息";
            this.查看个人信息ToolStripMenuItem.Click += new System.EventHandler(this.查看个人信息ToolStripMenuItem_Click);
            // 
            // 增添个人信息ToolStripMenuItem
            // 
            this.增添个人信息ToolStripMenuItem.Name = "增添个人信息ToolStripMenuItem";
            this.增添个人信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.增添个人信息ToolStripMenuItem.Text = "增添乘客信息";
            this.增添个人信息ToolStripMenuItem.Click += new System.EventHandler(this.增添个人信息ToolStripMenuItem_Click);
            // 
            // 订单查询ToolStripMenuItem
            // 
            this.订单查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.未出行订单ToolStripMenuItem,
            this.已购订单ToolStripMenuItem});
            this.订单查询ToolStripMenuItem.Name = "订单查询ToolStripMenuItem";
            this.订单查询ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.订单查询ToolStripMenuItem.Text = "订单查询(&C)";
            // 
            // 未出行订单ToolStripMenuItem
            // 
            this.未出行订单ToolStripMenuItem.Name = "未出行订单ToolStripMenuItem";
            this.未出行订单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.未出行订单ToolStripMenuItem.Text = "未出行订单";
            this.未出行订单ToolStripMenuItem.Click += new System.EventHandler(this.未出行订单ToolStripMenuItem_Click);
            // 
            // 已购订单ToolStripMenuItem
            // 
            this.已购订单ToolStripMenuItem.Name = "已购订单ToolStripMenuItem";
            this.已购订单ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.已购订单ToolStripMenuItem.Text = "已购订单";
            this.已购订单ToolStripMenuItem.Click += new System.EventHandler(this.已购订单ToolStripMenuItem_Click);
            // 
            // 线路选择ToolStripMenuItem
            // 
            this.线路选择ToolStripMenuItem.Name = "线路选择ToolStripMenuItem";
            this.线路选择ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.线路选择ToolStripMenuItem.Text = "车票预订(&B)";
            this.线路选择ToolStripMenuItem.Click += new System.EventHandler(this.线路选择ToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem1,
            this.线路管理ToolStripMenuItem,
            this.订单管理ToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(88, 21);
            this.ToolStripMenuItem.Text = "管理中心(&M)";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // 用户管理ToolStripMenuItem1
            // 
            this.用户管理ToolStripMenuItem1.Name = "用户管理ToolStripMenuItem1";
            this.用户管理ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.用户管理ToolStripMenuItem1.Text = "用户管理";
            this.用户管理ToolStripMenuItem1.Click += new System.EventHandler(this.用户管理ToolStripMenuItem1_Click);
            // 
            // 线路管理ToolStripMenuItem
            // 
            this.线路管理ToolStripMenuItem.Name = "线路管理ToolStripMenuItem";
            this.线路管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.线路管理ToolStripMenuItem.Text = "线路管理";
            this.线路管理ToolStripMenuItem.Click += new System.EventHandler(this.线路管理ToolStripMenuItem_Click);
            // 
            // 订单管理ToolStripMenuItem
            // 
            this.订单管理ToolStripMenuItem.Name = "订单管理ToolStripMenuItem";
            this.订单管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.订单管理ToolStripMenuItem.Text = "订单管理";
            this.订单管理ToolStripMenuItem.Click += new System.EventHandler(this.订单管理ToolStripMenuItem_Click);
            // 
            // 问题咨询ToolStripMenuItem
            // 
            this.问题咨询ToolStripMenuItem.Name = "问题咨询ToolStripMenuItem";
            this.问题咨询ToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.问题咨询ToolStripMenuItem.Text = "问题咨询(&Q)";
            this.问题咨询ToolStripMenuItem.Click += new System.EventHandler(this.问题咨询ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.退出系统ToolStripMenuItem.Text = "退出系统(&X)";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton10,
            this.toolStripButton9,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1020, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "用户中心";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "购物车";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "百度一下";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "添加用户";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "前一壁纸";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "返回主菜单";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton10_Click);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "后一壁纸";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "设置";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "问题咨询";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1020, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutomaticBookingSystem.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(1020, 492);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "在线自动购票系统";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增添个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 未出行订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 已购订单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线路选择ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 问题咨询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 线路管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 订单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.StatusStrip statusStrip1;

    }
}