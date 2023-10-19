namespace Tutorial_FORM
{
    partial class NotifyIconForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconForm));
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            开始闪烁ToolStripMenuItem = new ToolStripMenuItem();
            停止闪烁ToolStripMenuItem = new ToolStripMenuItem();
            显示窗体ToolStripMenuItem = new ToolStripMenuItem();
            让船体ToolStripMenuItem = new ToolStripMenuItem();
            让窗体恢复原有大小ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            右键ok吗ToolStripMenuItem = new ToolStripMenuItem();
            放在主页的ToolStripMenuItem = new ToolStripMenuItem();
            主页1ToolStripMenuItem = new ToolStripMenuItem();
            主页2ToolStripMenuItem = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "托盘气泡文本信息";
            notifyIcon1.BalloonTipTitle = "托盘气泡标题";
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.DoubleClick += notifyIcon1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, 显示窗体ToolStripMenuItem, toolStripSeparator1, 退出ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(127, 76);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { 开始闪烁ToolStripMenuItem, 停止闪烁ToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(126, 22);
            toolStripMenuItem1.Text = "闪烁图标";
            // 
            // 开始闪烁ToolStripMenuItem
            // 
            开始闪烁ToolStripMenuItem.Name = "开始闪烁ToolStripMenuItem";
            开始闪烁ToolStripMenuItem.Size = new Size(126, 22);
            开始闪烁ToolStripMenuItem.Text = "开始闪烁";
            开始闪烁ToolStripMenuItem.Click += 开始闪烁ToolStripMenuItem_Click;
            // 
            // 停止闪烁ToolStripMenuItem
            // 
            停止闪烁ToolStripMenuItem.Name = "停止闪烁ToolStripMenuItem";
            停止闪烁ToolStripMenuItem.Size = new Size(126, 22);
            停止闪烁ToolStripMenuItem.Text = "停止闪烁";
            停止闪烁ToolStripMenuItem.Click += 停止闪烁ToolStripMenuItem_Click;
            // 
            // 显示窗体ToolStripMenuItem
            // 
            显示窗体ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 让船体ToolStripMenuItem, 让窗体恢复原有大小ToolStripMenuItem });
            显示窗体ToolStripMenuItem.Name = "显示窗体ToolStripMenuItem";
            显示窗体ToolStripMenuItem.Size = new Size(126, 22);
            显示窗体ToolStripMenuItem.Text = "显示窗体";
            // 
            // 让船体ToolStripMenuItem
            // 
            让船体ToolStripMenuItem.Name = "让船体ToolStripMenuItem";
            让船体ToolStripMenuItem.Size = new Size(191, 22);
            让船体ToolStripMenuItem.Text = "让窗体最大化";
            让船体ToolStripMenuItem.Click += 让船体ToolStripMenuItem_Click;
            // 
            // 让窗体恢复原有大小ToolStripMenuItem
            // 
            让窗体恢复原有大小ToolStripMenuItem.Name = "让窗体恢复原有大小ToolStripMenuItem";
            让窗体恢复原有大小ToolStripMenuItem.Size = new Size(191, 22);
            让窗体恢复原有大小ToolStripMenuItem.Text = "让窗体恢复原有大小";
            让窗体恢复原有大小ToolStripMenuItem.Click += 让窗体恢复原有大小ToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(123, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(126, 22);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { 右键ok吗ToolStripMenuItem, 放在主页的ToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(140, 48);
            // 
            // 右键ok吗ToolStripMenuItem
            // 
            右键ok吗ToolStripMenuItem.Name = "右键ok吗ToolStripMenuItem";
            右键ok吗ToolStripMenuItem.Size = new Size(139, 22);
            右键ok吗ToolStripMenuItem.Text = "右键ok吗？";
            // 
            // 放在主页的ToolStripMenuItem
            // 
            放在主页的ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 主页1ToolStripMenuItem, 主页2ToolStripMenuItem });
            放在主页的ToolStripMenuItem.Name = "放在主页的ToolStripMenuItem";
            放在主页的ToolStripMenuItem.Size = new Size(139, 22);
            放在主页的ToolStripMenuItem.Text = "放在主页的";
            // 
            // 主页1ToolStripMenuItem
            // 
            主页1ToolStripMenuItem.Name = "主页1ToolStripMenuItem";
            主页1ToolStripMenuItem.Size = new Size(106, 22);
            主页1ToolStripMenuItem.Text = "主页1";
            // 
            // 主页2ToolStripMenuItem
            // 
            主页2ToolStripMenuItem.Name = "主页2ToolStripMenuItem";
            主页2ToolStripMenuItem.Size = new Size(106, 22);
            主页2ToolStripMenuItem.Text = "主页2";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // NotifyIconForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ContextMenuStrip = contextMenuStrip2;
            Name = "NotifyIconForm";
            Text = "NotifyIconForm";
            Deactivate += NotifyIconForm_Deactivate;
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 显示窗体ToolStripMenuItem;
        private ToolStripMenuItem 让船体ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private ToolStripMenuItem 让窗体恢复原有大小ToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem 右键ok吗ToolStripMenuItem;
        private ToolStripMenuItem 放在主页的ToolStripMenuItem;
        private ToolStripMenuItem 主页1ToolStripMenuItem;
        private ToolStripMenuItem 主页2ToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem 开始闪烁ToolStripMenuItem;
        private ToolStripMenuItem 停止闪烁ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}