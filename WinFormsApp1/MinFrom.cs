using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
            this.ShowInTaskbar = true;
            string startupPath = AppDomain.CurrentDomain.BaseDirectory;//获取当前程序启动路径
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);//声明对象Config
            string mySetting = config.AppSettings.Settings["path"].Value;//读取path值
            string id = config.AppSettings.Settings["id"].Value;
            if (id != "TW520" || startupPath != mySetting)
            {
                MessageBox.Show("注册码验证失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                config.AppSettings.Settings["path"].Value = startupPath;//修改path值
                config.AppSettings.Settings["id"].Value = "";
                config.Save(ConfigurationSaveMode.Modified);//保存配置
                Environment.Exit(0);
            }
        }
        private void 数据对比ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            TianC f = new TianC
            {
                MdiParent = this
            };
            f.Show();
        }
        private void del1_Load(object sender, EventArgs e)
        {
            Cplublic.AppPath=label1.Text = "程序启动路径:" + Application.StartupPath;
        }
        private void 更多工具ToolStripMenuItem2_Click(object sender, EventArgs e)
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

        private void 数据生成ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ShengCSJ f = new ShengCSJ
            {
                MdiParent = this
            };
            f.Show();
        }

        private void 替换列值ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ThuanFrom  f = new ThuanFrom
            {
                MdiParent = this
            };
            f.Show();
        }
        private void 数据对比ToolStripMenuItem1_Click(object sender, EventArgs e)
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
    }
}
