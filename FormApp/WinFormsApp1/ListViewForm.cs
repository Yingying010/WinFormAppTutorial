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
    public partial class ListViewForm : Form
    {
        public ListViewForm()
        {
            InitializeComponent();
        }

        int i = 1;
        private void 添加一项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem();
            lv1.Text = i.ToString(); //第一列
            lv1.SubItems.Add(i.ToString());//第二列
            lv1.SubItems.Add(i.ToString());//第三列
            lv1.SubItems.Add(i.ToString());
            listView1.Items.Add(lv1);
            i++;
        }

        private void 删除一项ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem lv1 = listView1.SelectedItems[0];
                listView1.Items.Remove(lv1);
            }


        }

        private void 清空数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            GC.Collect();
        }
    }
}
