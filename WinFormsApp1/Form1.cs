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
            file f = new file
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
            flie2 f = new flie2
            {
                MdiParent = this
            };
            f.Show();
        }
    }
}
