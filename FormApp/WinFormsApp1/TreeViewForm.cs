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
    public partial class TreeViewForm : Form
    {
        public TreeViewForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //获取整个树
            treeList.Nodes.Add("添加的第一个根节点"); //add（string） 方法

            //每一个节点都是treenode
            TreeNode tn = new TreeNode();
            tn.Name = "123";
            tn.Text = "TreeNode形式添加的节点";
            tn.ToolTipText = "TreeNode节点的气泡显示";

            treeList.Nodes.Add(tn);
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            TreeNode tn = new TreeNode();

            //怎么找到我们需要移除的tn
            tn = treeList.Nodes[treeList.Nodes.Count-1];

            treeList.Nodes.RemoveAt(treeList.Nodes.Count-1);
            treeList.Nodes.Remove(tn);

            TreeNode tn2 = treeList.Nodes["123"]; //使用key或者index时，只会检索当前tree，不会检索子项内容
        }
    }
}
