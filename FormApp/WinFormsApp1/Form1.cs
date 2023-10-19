namespace Tutorial_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //初始化窗体基本信息，不要在这里修改信息
            InitializeComponent();

            //也可以写，但是弊端就是如果控件需要其他初始化信息，那么在这里可能会引发顺序错乱

            //代码进行+=事件绑定
            this.Load += Form1_Load1; //这里对load事件重新手动进行了绑定，覆盖掉了窗口绑定
        }

        private void Form1_Load1(object? sender, EventArgs e)
        {
            this.Text = "code_Binding";
        }

        //双击窗口事件绑定
        private void Form1_Load(object sender, EventArgs e)
        {
            //窗体第一次被初始化（窗体标题/大小/是否允许最大化和最小化）
            this.Text = "click_Binding";
            button3.Enabled = false;
        }


        //在使用进程管理器等软件关闭窗体时，是不会出发该事件的。因为这里的事件只能处理内部消息，无法处理来自外部的消息
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //前
            //当我点击x时，事件立即被执行

            //如果需要执行清理/销毁对象，那么放在这里很合适


        }


        //在使用进程管理器等软件关闭窗体时，是不会出发该事件的。因为这里的事件只能处理内部消息，无法处理来自外部的消息
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //后
            //执行完closing后，才会执行这个方法


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            this.Text = string.Format("当前窗体宽度：{0}，高度{1}", w, h);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("zhengchang");
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("不正常");

        }

        //
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = "使用mouseclick点击";
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gold;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Pink;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str1 = textBox1.Text;
            textBox2.Text = str1;
            string str3 = string.Format("文本框1内容：{0} \r\n 用format拼接字符串的形式", str1);
            MessageBox.Show(str3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.AppendText("追加内容：" + str + "  长度：" + textBox1.TextLength.ToString() + "\r\n");
            //textBox2.Text = "同步展示文本框1中的内容：" + str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.SelectedText);
        }
    }
}