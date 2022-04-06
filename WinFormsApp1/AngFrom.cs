using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using NPOI.XSSF.UserModel;

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
            dialog.Description = "请选择文件夹";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                checkBox2.Checked = true;
                filej.Text = dialog.SelectedPath; //获取文件夹路径 
                if (dialog.SelectedPath != null && dialog.SelectedPath != "")
                    ForFileName(dialog.SelectedPath);
            }
        }
        private void ForFileName(string Path)
        {
            int y = 11;
            int i = 0;
            this.panel1.Controls.Clear();
            DirectoryInfo Files = new DirectoryInfo(Path);
            FileInfo[] files = Files.GetFiles();
            var filtered = files.Where(f => !f.Attributes.HasFlag(FileAttributes.Hidden));//去除隐藏文件
            foreach (FileInfo Filename in filtered)
            {
                int t = panel1.VerticalScroll.Value;
                CheckBox checkBox = new CheckBox
                {
                    Location = new Point(13, y - t),
                    Size = new Size(567, 21),
                    Name = "F" + i,
                    Text = Filename.Name,
                    Checked=true
                };
                panel1.Controls.Add(checkBox);
                i++;
                y += 25;
            }
            label7.Text = "当前文件夹下共："+i+"个文件" ;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dataTable=new DataTable();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Name2");
            dataTable.Columns.Add("Name3");
            foreach (Control control in this.panel1.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox comboBox = (CheckBox)control;
                    if (comboBox.Checked)
                    {
                        DataRow dr = dataTable.NewRow();
                        dr["Name"] = comboBox.Text;
                        dr["Name2"] = comboBox.Text.Substring(0,comboBox.Text.LastIndexOf("."));
                        dr["Name3"] = comboBox.Text.Substring(comboBox.Text.LastIndexOf("."));
                        dataTable.Rows.Add(dr);
                    }
                }
            }
            try
            {
                if (dataTable == null)
                {
                    MessageBox.Show("结果集为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dataTable.Rows.Count > 0)
                {
                    XSSFWorkbook workbook = new XSSFWorkbook();
                    workbook.CreateSheet("sheet1");
                    XSSFSheet sheet = (XSSFSheet)workbook.GetSheet("sheet1");
                    for (int h = 0; h < dataTable.Rows.Count+1; h++)
                        sheet.CreateRow(h);
                    XSSFRow sheetrow = (XSSFRow)sheet.GetRow(0);
                    XSSFCell[] sheetcell = new XSSFCell[dataTable.Columns.Count];
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        sheetcell[i] = (XSSFCell)sheetrow.CreateCell(i);
                        sheet.SetColumnWidth(i, 18 * 286);
                    }
                    sheetcell[0].SetCellValue("文件名称含扩展名");
                    sheetcell[1].SetCellValue("文件名称无扩展名");
                    sheetcell[2].SetCellValue("文件名称扩展名");
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        sheetrow = (XSSFRow)sheet.GetRow(i + 1);
                        for (int t = 0; t < dataTable.Columns.Count; t++)
                        {
                            sheetcell[t] = (XSSFCell)sheetrow.CreateCell(t);
                            if (dataTable.Rows[i][t] != null || dataTable.Rows[i][t].ToString() == "")
                            {
                                sheetcell[t].SetCellValue(dataTable.Rows[i][t].ToString());
                            }
                            else
                            {
                                sheetcell[t].SetCellValue("");
                            }
                        }
                    }
                    string localFilePath;
                    //string localFilePath, fileNameExt, newFileName, FilePath; 
                    SaveFileDialog sfd = new SaveFileDialog
                    {
                        //设置文件类型 
                        Filter = "Excel表格（*.xlsx）|*.xlsx",
                        FileName = "文件名称.xlsx",
                        //设置默认文件类型显示顺序 
                        FilterIndex = 1,
                        InitialDirectory = @"C:\Users\Administrator\Desktop",
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
                        if (string.IsNullOrEmpty(sfd.FileName))
                        {
                            MessageBox.Show("文件名不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }//dialog.FileName获取文件名称（全路径）
                        FileStream fss = new FileStream(@"" + sfd.FileName, FileMode.Create);
                        workbook.Write(fss);
                        fss.Close();
                        workbook.Close();
                        MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        sfd.Dispose();

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
                else
                {
                    MessageBox.Show("无处理数据！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("数据导出失败！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control control in this.panel1.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox comboBox = (CheckBox)control;
                    comboBox.Checked = checkBox2.Checked;
                }
            }
        }
    }
}
