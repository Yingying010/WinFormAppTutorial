namespace Tutorial_FORM
{
    partial class ListViewForm
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
            ListViewGroup listViewGroup1 = new ListViewGroup("GroupHeader1", HorizontalAlignment.Left);
            ListViewGroup listViewGroup2 = new ListViewGroup("GroupHeader2", HorizontalAlignment.Left);
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "23123", "111", "222", "333", "444" }, -1);
            ListViewItem listViewItem2 = new ListViewItem("123");
            ListViewItem listViewItem3 = new ListViewItem("222");
            ListViewItem listViewItem4 = new ListViewItem("999");
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            menuStrip1 = new MenuStrip();
            控制itemToolStripMenuItem = new ToolStripMenuItem();
            添加一项ToolStripMenuItem = new ToolStripMenuItem();
            删除一项ToolStripMenuItem = new ToolStripMenuItem();
            清空数据ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listViewGroup1.Header = "GroupHeader1";
            listViewGroup1.Name = "group1";
            listViewGroup2.Header = "GroupHeader2";
            listViewGroup2.Name = "group2";
            listView1.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2 });
            listViewItem1.Group = listViewGroup1;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.ToolTipText = "哈哈哈";
            listViewItem2.Group = listViewGroup1;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.Group = listViewGroup2;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.Group = listViewGroup2;
            listViewItem4.StateImageIndex = 0;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4 });
            listView1.Location = new Point(54, 45);
            listView1.Name = "listView1";
            listView1.Size = new Size(635, 292);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 200;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 控制itemToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 控制itemToolStripMenuItem
            // 
            控制itemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 添加一项ToolStripMenuItem, 删除一项ToolStripMenuItem, 清空数据ToolStripMenuItem });
            控制itemToolStripMenuItem.Name = "控制itemToolStripMenuItem";
            控制itemToolStripMenuItem.Size = new Size(69, 20);
            控制itemToolStripMenuItem.Text = "控制item";
            // 
            // 添加一项ToolStripMenuItem
            // 
            添加一项ToolStripMenuItem.Name = "添加一项ToolStripMenuItem";
            添加一项ToolStripMenuItem.Size = new Size(180, 22);
            添加一项ToolStripMenuItem.Text = "添加一项";
            添加一项ToolStripMenuItem.Click += 添加一项ToolStripMenuItem_Click;
            // 
            // 删除一项ToolStripMenuItem
            // 
            删除一项ToolStripMenuItem.Name = "删除一项ToolStripMenuItem";
            删除一项ToolStripMenuItem.Size = new Size(180, 22);
            删除一项ToolStripMenuItem.Text = "删除一项";
            删除一项ToolStripMenuItem.Click += 删除一项ToolStripMenuItem_Click;
            // 
            // 清空数据ToolStripMenuItem
            // 
            清空数据ToolStripMenuItem.Name = "清空数据ToolStripMenuItem";
            清空数据ToolStripMenuItem.Size = new Size(180, 22);
            清空数据ToolStripMenuItem.Text = "清空数据";
            清空数据ToolStripMenuItem.Click += 清空数据ToolStripMenuItem_Click;
            // 
            // ListViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 406);
            Controls.Add(listView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ListViewForm";
            Text = "ListViewForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 控制itemToolStripMenuItem;
        private ToolStripMenuItem 添加一项ToolStripMenuItem;
        private ToolStripMenuItem 删除一项ToolStripMenuItem;
        private ToolStripMenuItem 清空数据ToolStripMenuItem;
    }
}