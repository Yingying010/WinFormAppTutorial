namespace Tutorial_FORM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //��ʼ�����������Ϣ����Ҫ�������޸���Ϣ
            InitializeComponent();

            //Ҳ����д�����Ǳ׶˾�������ؼ���Ҫ������ʼ����Ϣ����ô��������ܻ�����˳�����

            //�������+=�¼���
            this.Load += Form1_Load1; //�����load�¼������ֶ������˰󶨣����ǵ��˴��ڰ�
        }

        private void Form1_Load1(object? sender, EventArgs e)
        {
            this.Text = "code_Binding";
        }

        //˫�������¼���
        private void Form1_Load(object sender, EventArgs e)
        {
            //�����һ�α���ʼ�����������/��С/�Ƿ�������󻯺���С����
            this.Text = "click_Binding";
            button3.Enabled = false;
        }


        //��ʹ�ý��̹�����������رմ���ʱ���ǲ���������¼��ġ���Ϊ������¼�ֻ�ܴ����ڲ���Ϣ���޷����������ⲿ����Ϣ
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ǰ
            //���ҵ��xʱ���¼�������ִ��

            //�����Ҫִ������/���ٶ�����ô��������ܺ���


        }


        //��ʹ�ý��̹�����������رմ���ʱ���ǲ���������¼��ġ���Ϊ������¼�ֻ�ܴ����ڲ���Ϣ���޷����������ⲿ����Ϣ
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //��
            //ִ����closing�󣬲Ż�ִ���������


        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            int w = this.Width;
            int h = this.Height;
            this.Text = string.Format("��ǰ�����ȣ�{0}���߶�{1}", w, h);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("zhengchang");
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("������");

        }

        //
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Text = "ʹ��mouseclick���";
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
            string str3 = string.Format("�ı���1���ݣ�{0} \r\n ��formatƴ���ַ�������ʽ", str1);
            MessageBox.Show(str3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox2.AppendText("׷�����ݣ�" + str + "  ���ȣ�" + textBox1.TextLength.ToString() + "\r\n");
            //textBox2.Text = "ͬ��չʾ�ı���1�е����ݣ�" + str;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox2.SelectedText);
        }
    }
}