namespace Tutorial_FORM
{
    partial class TreeViewForm
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
            TreeNode treeNode29 = new TreeNode("Node15");
            TreeNode treeNode30 = new TreeNode("Node16");
            TreeNode treeNode31 = new TreeNode("Node5", new TreeNode[] { treeNode29, treeNode30 });
            TreeNode treeNode32 = new TreeNode("Node6");
            TreeNode treeNode33 = new TreeNode("Node0", new TreeNode[] { treeNode31, treeNode32 });
            TreeNode treeNode34 = new TreeNode("Node17");
            TreeNode treeNode35 = new TreeNode("Node18");
            TreeNode treeNode36 = new TreeNode("Node19");
            TreeNode treeNode37 = new TreeNode("Node20");
            TreeNode treeNode38 = new TreeNode("Node7", new TreeNode[] { treeNode34, treeNode35, treeNode36, treeNode37 });
            TreeNode treeNode39 = new TreeNode("Node8");
            TreeNode treeNode40 = new TreeNode("Node1", new TreeNode[] { treeNode38, treeNode39 });
            TreeNode treeNode41 = new TreeNode("Node2");
            TreeNode treeNode42 = new TreeNode("Node9");
            TreeNode treeNode43 = new TreeNode("Node21");
            TreeNode treeNode44 = new TreeNode("Node25");
            TreeNode treeNode45 = new TreeNode("Node26");
            TreeNode treeNode46 = new TreeNode("Node27");
            TreeNode treeNode47 = new TreeNode("Node22", new TreeNode[] { treeNode44, treeNode45, treeNode46 });
            TreeNode treeNode48 = new TreeNode("Node23");
            TreeNode treeNode49 = new TreeNode("Node24");
            TreeNode treeNode50 = new TreeNode("Node10", new TreeNode[] { treeNode43, treeNode47, treeNode48, treeNode49 });
            TreeNode treeNode51 = new TreeNode("Node11");
            TreeNode treeNode52 = new TreeNode("Node12");
            TreeNode treeNode53 = new TreeNode("Node3", new TreeNode[] { treeNode42, treeNode50, treeNode51, treeNode52 });
            TreeNode treeNode54 = new TreeNode("Node13");
            TreeNode treeNode55 = new TreeNode("Node14");
            TreeNode treeNode56 = new TreeNode("Node4", new TreeNode[] { treeNode54, treeNode55 });
            treeList = new TreeView();
            txtBody = new TextBox();
            btnAdd = new Button();
            btnRem = new Button();
            SuspendLayout();
            // 
            // treeList
            // 
            treeList.CheckBoxes = true;
            treeList.Dock = DockStyle.Left;
            treeList.HotTracking = true;
            treeList.Location = new Point(0, 0);
            treeList.Name = "treeList";
            treeNode29.Name = "Node15";
            treeNode29.Text = "Node15";
            treeNode30.Name = "Node16";
            treeNode30.Text = "Node16";
            treeNode31.Name = "Node5";
            treeNode31.Text = "Node5";
            treeNode32.Name = "Node6";
            treeNode32.Text = "Node6";
            treeNode33.Name = "Node0";
            treeNode33.Text = "Node0";
            treeNode34.Name = "Node17";
            treeNode34.Text = "Node17";
            treeNode35.Name = "Node18";
            treeNode35.Text = "Node18";
            treeNode36.Name = "Node19";
            treeNode36.Text = "Node19";
            treeNode37.Name = "Node20";
            treeNode37.Text = "Node20";
            treeNode38.Name = "Node7";
            treeNode38.Text = "Node7";
            treeNode39.Name = "Node8";
            treeNode39.Text = "Node8";
            treeNode40.Name = "Node1";
            treeNode40.Text = "Node1";
            treeNode41.Name = "Node2";
            treeNode41.Text = "Node2";
            treeNode42.Name = "Node9";
            treeNode42.Text = "Node9";
            treeNode43.Name = "Node21";
            treeNode43.Text = "Node21";
            treeNode44.Name = "Node25";
            treeNode44.Text = "Node25";
            treeNode45.Name = "Node26";
            treeNode45.Text = "Node26";
            treeNode46.Name = "Node27";
            treeNode46.Text = "Node27";
            treeNode47.Name = "Node22";
            treeNode47.Text = "Node22";
            treeNode48.Name = "Node23";
            treeNode48.Text = "Node23";
            treeNode49.Name = "Node24";
            treeNode49.Text = "Node24";
            treeNode50.Name = "Node10";
            treeNode50.Text = "Node10";
            treeNode51.Name = "Node11";
            treeNode51.Text = "Node11";
            treeNode52.Name = "Node12";
            treeNode52.Text = "Node12";
            treeNode53.Name = "Node3";
            treeNode53.Text = "Node3";
            treeNode54.Name = "Node13";
            treeNode54.Text = "Node13";
            treeNode55.Name = "Node14";
            treeNode55.Text = "Node14";
            treeNode56.Name = "Node4";
            treeNode56.Text = "Node4";
            treeList.Nodes.AddRange(new TreeNode[] { treeNode33, treeNode40, treeNode41, treeNode53, treeNode56 });
            treeList.Size = new Size(208, 450);
            treeList.TabIndex = 0;
            // 
            // txtBody
            // 
            txtBody.BackColor = SystemColors.InactiveCaption;
            txtBody.Location = new Point(235, 150);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.Size = new Size(536, 300);
            txtBody.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(259, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(96, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "添加一个节点";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRem
            // 
            btnRem.Location = new Point(379, 26);
            btnRem.Name = "btnRem";
            btnRem.Size = new Size(102, 23);
            btnRem.TabIndex = 3;
            btnRem.Text = "移除一个节点";
            btnRem.UseVisualStyleBackColor = true;
            btnRem.Click += btnRem_Click;
            // 
            // TreeViewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRem);
            Controls.Add(btnAdd);
            Controls.Add(txtBody);
            Controls.Add(treeList);
            Name = "TreeViewForm";
            Text = "TreeViewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeList;
        private TextBox txtBody;
        private Button btnAdd;
        private Button btnRem;
    }
}