namespace Tutorial_FORM
{
    partial class TimeForm
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
            monthCalendar1 = new MonthCalendar();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(70, 86);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(70, 39);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(389, 39);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 2;
            button1.Text = "获取选择的数值";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 86);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "当前时间：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 86);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = " 。。。";
            // 
            // button2
            // 
            button2.Location = new Point(579, 39);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 5;
            button2.Text = "显示当前时间";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TimeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(monthCalendar1);
            Name = "TimeForm";
            Text = "TimeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}