using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tutorial_FORM
{
    public partial class progressBar : Form
    {
        public progressBar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            label2.Text = progressBar1.Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = progressBar1.Value - progressBar1.Step;
            if (value >= progressBar1.Minimum)
            {
                progressBar1.Value = value;
                label2.Text = progressBar1.Value.ToString();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i=0;i<=progressBar1.Maximum;i++)
            {
                //progressBar1.PerformStep();
                progressBar1.Value = i;
                Thread.Sleep(200);
            }
        }
    }
}
