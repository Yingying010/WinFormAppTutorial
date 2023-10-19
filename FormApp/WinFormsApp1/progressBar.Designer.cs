namespace Tutorial_FORM
{
    partial class progressBar
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
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.Control;
            progressBar1.Location = new Point(59, 58);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(660, 23);
            progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(59, 106);
            button1.Name = "button1";
            button1.Size = new Size(161, 47);
            button1.TabIndex = 1;
            button1.Text = "<<<";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(558, 106);
            button2.Name = "button2";
            button2.Size = new Size(161, 47);
            button2.TabIndex = 2;
            button2.Text = ">>>";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "当前数值：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 23);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(296, 117);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "for循环";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // progressBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 182);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Name = "progressBar";
            Text = "progressBar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}