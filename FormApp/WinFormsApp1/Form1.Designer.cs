namespace Tutorial_FORM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(30, 506);
            button1.Name = "button1";
            button1.Size = new Size(143, 70);
            button1.TabIndex = 0;
            button1.Text = "按钮";
            button1.UseVisualStyleBackColor = false;
            button1.Leave += button1_Leave;
            button1.MouseClick += button1_MouseClick;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // button2
            // 
            button2.Location = new Point(277, 506);
            button2.Name = "button2";
            button2.Size = new Size(144, 70);
            button2.TabIndex = 1;
            button2.Text = "正常按钮";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(539, 506);
            button3.Name = "button3";
            button3.Size = new Size(161, 68);
            button3.TabIndex = 2;
            button3.Text = "不允许点击的按钮";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(41, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(226, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "text1";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 26);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(226, 132);
            textBox2.TabIndex = 4;
            textBox2.Text = "dbjashvdjasvdjkhsvabdvbnzmvcnvcyeuwiqfffffffffiysuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuusssssssssssssss\r\n\r\n\r\n\\\\\\\\\\\\r\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\r\n\r\n";
            // 
            // button4
            // 
            button4.Location = new Point(583, 26);
            button4.Name = "button4";
            button4.Size = new Size(137, 23);
            button4.TabIndex = 5;
            button4.Text = "复制文本1的内容";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(583, 80);
            button5.Name = "button5";
            button5.Size = new Size(137, 23);
            button5.TabIndex = 6;
            button5.Text = "获取选择的文本";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(41, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 604);
            Controls.Add(comboBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = resources.GetString("$this.Text");
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button4;
        private Button button5;
        private ComboBox comboBox1;
    }
}