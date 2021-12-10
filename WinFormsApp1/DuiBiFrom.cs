using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace WinFormsApp1
{
    public partial class DuiBiFrom : Form
    {
        public DuiBiFrom()
        {
            InitializeComponent();
        }

        private void DuiBiFrom_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//选择父数据源
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Title = "请选择文件", //选择器提示文字
                Filter = "Excel(*.xlsx,*.xls)|*.xlsx;*.xls" //文件类型
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Ftext.Text = fileDialog.FileName; //获取文件路径（带文件名）
                DirectoryInfo info = new DirectoryInfo(fileDialog.FileName);
               // filenameonly.Text = info.Name;  //获取文件名
            }
        }

        private void button2_Click(object sender, EventArgs e)//选择子数据源
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Title = "请选择文件", //选择器提示文字
                Filter = "Excel(*.xlsx,*.xls)|*.xlsx;*.xls" //文件类型
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Ctext.Text = fileDialog.FileName; //获取文件路径（带文件名）
                DirectoryInfo info = new DirectoryInfo(fileDialog.FileName);
                // filenameonly.Text = info.Name;  //获取文件名
            }
        }
    }
}
