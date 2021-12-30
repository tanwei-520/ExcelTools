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
    public partial class ThuanFrom : Form
    {
        private static DataTable a1;
        private static DataTable a2;
        private static DataTable a3;
        private static string []a1name;
        private static string[] a2name;
        public ThuanFrom()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // string[] name = { };
            Readexcecl(filename.Text,filenameonly.Text,"a1");
        }
        private void Creal()
        {
            filename.Text = "";
            filelog.Text = "";
            filenameonly.Text = "";
            button2.Enabled = false;
            label4.Visible = false;
        }
        private void Readexcecl(string filename,string filenameonly,string a)
        {
            try
            {
                if (filename != "" && (filenameonly.LastIndexOf(".xlsx") > 0 || filenameonly.LastIndexOf(".xls") > 0))
                {
                    FileStream fileStream = new FileStream(@"" + filename + "", FileMode.Open);
                    IWorkbook workbook;
                    string tablename;
                    if (filenameonly.LastIndexOf(".xlsx") > 0)
                    {
                        workbook = new XSSFWorkbook(fileStream);
                        tablename = filenameonly.Replace(".xlsx", "");
                    }
                    else
                    {
                        workbook = new HSSFWorkbook(fileStream);
                        tablename = filenameonly.Replace(".xls", "");
                    }
                    ISheet sheet = workbook.GetSheetAt(0);
                    IRow row;
                    DataTable dataTable = new DataTable();
                    dataTable.TableName = tablename;
                    int i;
                    if (Isname.Checked && qishih.Text != "")
                    {
                        i = int.Parse(qishih.Text) - 2;
                        label3.Text = "当前共：" + (int.Parse(sheet.LastRowNum.ToString()) - i).ToString() + "条数据";
                    }
                    else if (!Isname.Checked && qishih.Text != "")
                    {
                        i = int.Parse(qishih.Text) - 1; ;
                        label3.Text = "当前共：" + (int.Parse(sheet.LastRowNum.ToString()) - i).ToString() + "条数据";
                    }
                    else
                    {
                        i = 0;
                        label3.Text = "当前共：" + (int.Parse(sheet.LastRowNum.ToString()) + 1).ToString() + "条数据";
                    }
                    row = sheet.GetRow(i);
                    string[] name = new string[row.LastCellNum];
                    for (int t = row.FirstCellNum; t < row.LastCellNum; t++)
                    {
                        if (row.GetCell(t) != null)
                        {
                            if (Isname.Checked)//如果包含列名则取出列名
                            {
                                if (row.GetCell(t) != null)
                                    name[t] = row.GetCell(t).ToString();
                                else
                                    name[t] = t.ToString();
                            }
                            dataTable.Columns.Add("column" + t);//建列
                        }
                        else
                        {
                            name[t] = "";
                        }
                    }
                    for (i = i + 1; i < sheet.LastRowNum+1; i++)
                    {
                        row = sheet.GetRow(i);//NPOI行
                        if (row != null)
                        {
                            DataRow dr = dataTable.NewRow();//新建行
                            for (int j = row.FirstCellNum; j < row.LastCellNum; j++)
                            {
                                if (row.GetCell(j) != null)
                                    dr[j] = row.GetCell(j).ToString();
                                else
                                    dr[j] = "";
                            }
                            dataTable.Rows.Add(dr); //行填值
                        }
                    }
                    if (Isname.Checked) //如果包含列名则修改为包含的列名
                    {
                        for (int t = 0; t < name.Length; t++)
                        {
                            if (name[t] != "")
                                dataTable.Columns[t].ColumnName = name[t];
                        }
                    }
                    dataGridView1.DataSource = dataTable;
                    if (a == "a1")
                    {
                        a1name = null;
                        a1itm.Items.Clear();
                        comboBox1.Items.Clear();
                        for (int y = 0; y < name.Length; y++)
                            a1itm.Items.Add(name[y]);
                        for (int y = 0; y < name.Length; y++)
                            comboBox1.Items.Add(name[y]);
                        a1 = dataTable;
                        a1name = name;
                    }
                    else
                    {
                        a2name = null;
                        biiteml.Items.Clear();
                        comboBox2.Items.Clear();
                        for (int y = 0; y < name.Length; y++)
                            biiteml.Items.Add(name[y]);
                        for (int y = 0; y < name.Length; y++)
                            comboBox2.Items.Add(name[y]);
                        a2 = dataTable;
                        a2name = name;
                    }
                    fileStream.Close();
                    Creal();
                    label4.Visible = false;
                }
                else
                {
                    MessageBox.Show("请选择Excel文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Creal();
                }
            }
            catch
            {
                MessageBox.Show("该文件已被其他程序占用或打开！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                Title = "请选择文件", //选择器提示文字
                Filter = "Excel文件|*.xls;*.xlsx"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filename.Text = fileDialog.FileName; //获取文件路径（带文件名）
                DirectoryInfo info = new DirectoryInfo(fileDialog.FileName);
                filelog.Text = info.Parent.FullName; //获取文件所在文件夹路径（不带文件名）
                filenameonly.Text = info.Name;  //获取文件名
                if (filenameonly.Text != "")
                    button2.Enabled = true;
            }
        }

        private void file_Load(object sender, EventArgs e)
        {
            // dataGridView1.RowHeadersVisible = false; //关闭dataGridView1左侧的空白区域
            filename.ReadOnly = true;
            //label4.Visible = true;
        }

        private void File_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width-40;
            //dataGridView1.Height = this.Height - 369;
/*            if(this.Width - 557>30&& this.Height - 249- dataGridView1.Height > 22)
                panel1.Location = new System.Drawing.Point(this.Width - 557 - 30, this.Height - 263 - dataGridView1.Height - 44-46);*/
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            label4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Readexcecl(filename.Text, filenameonly.Text, "a2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (a1itm.Text == "" || biiteml.Text == "")
            {
                MessageBox.Show("请设置正确条件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int index1 = Array.IndexOf(a1name, a1itm.Text);
            int index2 = Array.IndexOf(a2name, biiteml.Text);
            int index3 = Array.IndexOf(a2name, comboBox2.Text);
            DataTable dataTable = new DataTable();
            dataTable = a2.Clone();
            DataRow[] dr;
            if (comboBox1.Text != "" && comboBox2.Text != "")
            {
                for (int i = 0; i < a2.Rows.Count; i++)
                {
                    if (a2.Rows[i][index3].ToString() != "")
                    {
                        if (sel.Text == "like")
                            dr = a1.Select(comboBox1.Text + " " + sel.Text + " '%" + a2.Rows[i][index3].ToString() + "%' " + fujia.Text);
                        else
                            dr = a1.Select(comboBox1.Text + " " + sel.Text + " '" + a2.Rows[i][index3].ToString() + "' " + fujia.Text);
                        for (int t = 0; t < dr.Length; t++)
                        {
                            DataRow dc = a2.Rows[i];
                            dc[biiteml.Text] = dr[t][a1itm.Text].ToString();
                            dataTable.Rows.Add(dc.ItemArray);
                        }
                    }
                    else //如果所选条件为空则改行直接填充
                    {
                        DataRow dc = a2.Rows[i];
                        dataTable.Rows.Add(dc.ItemArray);
                    }
                }
            }
            else
            {
                for (int i = 0; i < a2.Rows.Count; i++)
                {
                    if (a2.Rows[i][index2].ToString() != "")
                    {
                        if (sel.Text == "like")
                            dr = a1.Select(a1itm.Text + " " + sel.Text + " '%" + a2.Rows[i][index2].ToString() + "%' " + fujia.Text);
                        else
                            dr = a1.Select(a1itm.Text + " " + sel.Text + " '" + a2.Rows[i][index2].ToString() + "' " + fujia.Text);
                        for (int t = 0; t < dr.Length; t++)
                        {
                            DataRow dc = a2.Rows[i];
                            dc[biiteml.Text] = dr[t][a1itm.Text].ToString();
                            dataTable.Rows.Add(dc.ItemArray);
                        }
                    }
                    else //如果所选条件为空则改行直接填充
                    {
                        DataRow dc = a2.Rows[i];
                        dataTable.Rows.Add(dc.ItemArray);
                    }
                }
            }
            label3.Text = "当前共：" + (int.Parse(dataTable.Rows.Count.ToString())).ToString() + "条数据";
            a3 = dataTable;
            dataGridView1.DataSource = dataTable;
            fujia.Text = "";
        }
         
        private void pictureBox1_Click(object sender, EventArgs e)//导出
        {
            try
            {
                if (a3 == null)
                {
                    MessageBox.Show("结果集为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if ( a3.Rows.Count > 0)
                {
                    XSSFWorkbook workbook = new XSSFWorkbook();
                    workbook.CreateSheet("sheet1");
                    XSSFSheet sheet = (XSSFSheet)workbook.GetSheet("sheet1");
                    for (int h = 0; h < a3.Rows.Count + 1; h++)
                        sheet.CreateRow(h);
                    XSSFRow sheetrow = (XSSFRow)sheet.GetRow(0);
                    XSSFCell[] sheetcell = new XSSFCell[a2name.Length];
                    for (int i = 0; i < a2name.Length; i++)
                    {
                        sheetcell[i] = (XSSFCell)sheetrow.CreateCell(i);
                        sheetcell[i].SetCellValue(a2name[i]);
                        sheet.SetColumnWidth(i, 18 * 256);
                    }
                    for (int i = 0; i < a3.Rows.Count; i++)
                    {
                        sheetrow = (XSSFRow)sheet.GetRow(i + 1);
                        for (int t = 0; t < a2name.Length; t++)
                        {
                            sheetcell[t] = (XSSFCell)sheetrow.CreateCell(t);
                            if (a3.Rows[i][t] != null || a3.Rows[i][t].ToString() == "")
                            {
                                sheetcell[t].SetCellValue(a3.Rows[i][t].ToString());
                            }
                            else
                            {
                                sheetcell[t].SetCellValue("");
                            }
                        }
                    }
                    SaveFileDialog dialog = new SaveFileDialog()
                    {
                        //设置文件类型 
                        Filter = "Excel表格（*.xlsx）|*.xlsx",
                        FileName = a2.TableName + "处理后.xlsx",
                        //设置默认文件类型显示顺序 
                        FilterIndex = 1,
                      //  InitialDirectory = @"C:\Users\Administrator\Desktop",//是否设置默认打开路径
                        //保存对话框是否记忆上次打开的目录 
                        RestoreDirectory = true
                    };
                    /*                    dialog.Filter = "Excel表格（*.xlsx）|*.xlsx";
                    dialog.FileName = a2.TableName + "处理后.xlsx";
                    dialog.FilterIndex = 1;
                    dialog.RestoreDirectory = true;*/
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        if (string.IsNullOrEmpty(dialog.FileName))
                        {
                            MessageBox.Show("文件名不能为空！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }//dialog.FileName获取文件名称（全路径）
                        FileStream fss = new FileStream(@"" + dialog.FileName, FileMode.Create);
                        workbook.Write(fss);
                        fss.Close();
                        workbook.Close();
                        a1 = null;
                        a1itm.Text = biiteml.Text = "";
                        a1itm.Items.Clear();
                        biiteml.Items.Clear();
                        MessageBox.Show("导出成功！请重新选择文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    dialog.Dispose();
                }
                else
                {
                    MessageBox.Show("无处理数据！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("结果集有误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
