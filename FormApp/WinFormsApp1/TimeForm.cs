using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_FORM
{
    public partial class TimeForm : Form
    {
        public TimeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            string dtstr = dateTimePicker1.Text;
            DateTime dt1 = DateTime.Parse(dtstr);
            //dt==dt1
            //如果让用户输入时间，要让用户确定时间的有效性

            DateTime dt2 = DateTime.Parse("2017-06-08 00:00:00");
            DateTime dt3 = DateTime.Parse("2017-06-09 00:00:00");
            TimeSpan ts = dt2 - dt3;
            TimeSpan ts2 = dt3 - dt2;

            //比较时期用subtract
            TimeSpan ts3 = dt3.Subtract(dt2);

            int x = dt2.CompareTo(dt3);
            //早于  -1

            //等于  0

            //晚于  1

            //获取当前值
            dt = DateTime.Now;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
