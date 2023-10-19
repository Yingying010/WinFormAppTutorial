using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tutorial_FORM.Properties;

namespace Tutorial_FORM
{
    public partial class NotifyIconForm : Form
    {
        public NotifyIconForm()
        {
            InitializeComponent();
            timer1.Enabled = false;
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            //恢复成默认大小
            WindowState = FormWindowState.Normal;
        }

        private void 让船体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //最大化
            WindowState = FormWindowState.Maximized;
        }

        private void 让窗体恢复原有大小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //恢复原有大小
            WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true; //恢复后，显示至任务栏
            this.notifyIcon1.Visible = false;//不在托盘区域显示
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon1.Visible = false;
            this.Close();
        }

        private void NotifyIconForm_Deactivate(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;//最小化后不显示在任务栏
                this.notifyIcon1.Visible = true;//仅显示托盘
                this.notifyIcon1.ShowBalloonTip(5000);
            }
        }

        private void 开始闪烁ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timer1.Start();

        }


        private void 停止闪烁ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconForm));

            //否则下一会就不是这个样式了
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            isFirst = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            flicking();
        }


        bool isFirst;

        private void flicking()
        {
            //获取到icon文件
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyIconForm));

            if (!isFirst)
            {
                //第一次设置透明
                notifyIcon1.Icon = (Icon)resources.GetObject("refresh.Icon");
                isFirst = true;
            }
            else
            {
                //第二次设置实心图标
                notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
                isFirst = false;

            }


        }


    }
}
