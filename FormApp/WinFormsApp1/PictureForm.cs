using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_FORM
{
    public partial class PictureForm : Form
    {
        public PictureForm()
        {
            InitializeComponent();
        }

        private void PictureForm_Load(object sender, EventArgs e)
        {
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.ApplicationData;

            //如果需要访问与exe同文件目录时，我们可以使用相对路径的写法：
            string tPath = "01.jpeg"; //相对路径
            string Path = Application.StartupPath; //弊端：只能在窗体应用程序中使用，不推荐这个
            string cPath = AppDomain.CurrentDomain.BaseDirectory + tPath;

            //pictureBox1.Image = pictureBox1.ErrorImage;
            pictureBox1.Image = Image.FromFile(cPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //PictureBoxSizeMode ps = new PictureBoxSizeMode();
            //var s = Enum.GetNames(ps.GetType());

            //推荐使用typeof关键字来获取数据类型
            var s = Enum.GetNames(typeof(PictureBoxSizeMode));
            comboBox1.Items.AddRange(s);

        }

        private void btnShowImage_Click(object sender, EventArgs e)
        {
            //先读取设置的路径
            string cPath = picPath.Text;
            pictureBox1.Image = Image.FromFile(cPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex; //获取当前选择的index
            //将index转换为枚举对象(强制类型转换)
            PictureBoxSizeMode ps = (PictureBoxSizeMode)index;
            //将选中的name转换为枚举对象
            string name = comboBox1.SelectedItem.ToString();
            PictureBoxSizeMode pb = (PictureBoxSizeMode)Enum.Parse(typeof(PictureBoxSizeMode), name);
            pictureBox1.SizeMode = pb;
        }

        private void picPath_Click(object sender, EventArgs e)
        {


            //打开文件选择对话框
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                picPath.Text = openFileDialog1.FileName;
            }
        }

        private void txtFilePath_Click(object sender, EventArgs e)
        {
            //打开文件目录选择对话框
            folderBrowserDialog1.Description = "选择一个文件目录";
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFilePath.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
