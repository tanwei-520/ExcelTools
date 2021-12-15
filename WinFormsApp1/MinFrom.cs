using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class del1 : Form
    {
        public del1()
        {
            InitializeComponent();
        }

        private void 选择文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ThuanFrom f = new ThuanFrom
            {
                MdiParent = this
            };
            f.Show();
        }

        private void 选择文件夹ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            DuiBiFrom f = new DuiBiFrom
            {
                MdiParent = this
            };
            f.Show();
        }

        private void 数据对比ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            更多工具 f = new 更多工具
            {
                MdiParent = this
            };
            f.Show();
        }

        private void del1_Load(object sender, EventArgs e)
        {

        }
    }
}
