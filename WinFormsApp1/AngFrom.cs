using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class 更多工具 : Form
    {
        public 更多工具()
        {
            InitializeComponent();
        }

        private void flie2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择Excel保存的文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                filej.Text = dialog.SelectedPath; //获取文件夹路径 
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string localFilePath = "";
            //string localFilePath, fileNameExt, newFileName, FilePath; 
            SaveFileDialog sfd = new SaveFileDialog
            {
                //设置文件类型 
                Filter = "Excel表格（*.xlsx）|*.xlsx",
                FileName = "测试.xlsx",
                //设置默认文件类型显示顺序 
                FilterIndex = 1,
                InitialDirectory= @"C:\Users\Administrator\Desktop",
                //保存对话框是否记忆上次打开的目录 
                RestoreDirectory = true
            };

            //点了保存按钮进入 
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                localFilePath = sfd.FileName.ToString(); //获得文件路径 
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径
                savefilename.Text = fileNameExt;
                savefilelu.Text = localFilePath;

                //获取文件路径，不带文件名 
                //FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\")); 

                //给文件名前加上时间 
                //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt; 

                //在文件名里加字符 
                //saveFileDialog1.FileName.Insert(1,"dameng"); 

                //System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();//输出文件 

                ////fs输出带文字或图片的文件，就看需求了 
            }
        }
    }
}
