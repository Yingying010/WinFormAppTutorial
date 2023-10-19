namespace Tutorial_FORM
{
    partial class PictureForm
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
            label1 = new Label();
            txtFilePath = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            picPath = new TextBox();
            label6 = new Label();
            btnShowImage = new Button();
            label7 = new Label();
            comboBox1 = new ComboBox();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 23);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "姓名：";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(91, 20);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(301, 23);
            txtFilePath.TabIndex = 1;
            txtFilePath.Click += txtFilePath_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(301, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 65);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "职务名称：";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 104);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(301, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 107);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "手机号码：";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(91, 148);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(301, 23);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 151);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "工位信息：";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(91, 195);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(301, 23);
            textBox5.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 198);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 9;
            label5.Text = "所属部门：";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(448, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 242);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "图片信息";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Image = Properties.Resources.sunset_1287550;
            pictureBox2.Location = new Point(23, 130);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(275, 106);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(23, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(275, 102);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // picPath
            // 
            picPath.Location = new Point(91, 236);
            picPath.Name = "picPath";
            picPath.Size = new Size(301, 23);
            picPath.TabIndex = 13;
            picPath.Click += picPath_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 239);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 12;
            label6.Text = "图片位置：";
            // 
            // btnShowImage
            // 
            btnShowImage.Location = new Point(448, 278);
            btnShowImage.Name = "btnShowImage";
            btnShowImage.Size = new Size(98, 23);
            btnShowImage.TabIndex = 14;
            btnShowImage.Text = "读取并显示";
            btnShowImage.UseVisualStyleBackColor = true;
            btnShowImage.Click += btnShowImage_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 278);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 15;
            label7.Text = "图片模式：";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(91, 275);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 17;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "图片文件|*.jpg|所有文件|*.*";
            // 
            // PictureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(btnShowImage);
            Controls.Add(picPath);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(txtFilePath);
            Controls.Add(label1);
            Name = "PictureForm";
            Text = "PictureForm";
            Load += PictureForm_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFilePath;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox picPath;
        private Label label6;
        private Button btnShowImage;
        private Label label7;
        private ComboBox comboBox1;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}