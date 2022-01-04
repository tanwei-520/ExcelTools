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
    public partial class TianC : Form
    {
        private static DataTable a1;
        private static DataTable a2;
        private static DataTable a3;
        public TianC()
        {
            InitializeComponent();
        }

        private void TianC_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 0;
            Cplublic.A1 = Cplublic.B1 = Cplublic.TA1 = Cplublic.TB1 = null;
        }
        private void Clear()//重置
        {
            textBox1.Text = "2";
            comboBox2.Items.Clear();
            comboBox1.Items.Clear();
            dataGridView1.DataSource = null;
            Ctext.Text = "";
            Ftext.Text = "";
            Lable.Text = "------";
            Cplublic.B1 = Cplublic.A1 = null;
            Tiao1.Checked = Tiao2.Checked = Tiao3.Checked = Tiao4.Checked = false;
            checkBox1.Checked = false;
            a1 = a2 = null;
        }

        private void button1_Click(object sender, EventArgs e)//选择数据源
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
                 // filenameonly.Text = info.Name;  //获取文件名
            }
        }

        private void button2_Click(object sender, EventArgs e)//选择待处理文件
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
                // filenameonly.Text = info.Name;  //获取文件名
            }
        }
        private string[] ReadExcel(string filename, string filepath, int Top, string Table)//读取Excel文件
        {
            try
            {
                if (filename != "" && (filename.LastIndexOf(".xlsx") > 0 || filename.LastIndexOf(".xls") > 0))
                {
                    FileStream fileStream = new FileStream(@"" + filepath + "", FileMode.Open);
                    IWorkbook workbook;
                    string tablename;
                    if (filename.LastIndexOf(".xlsx") > 0)
                    {
                        workbook = new XSSFWorkbook(fileStream);
                        tablename = filename.Replace(".xlsx", "");
                    }
                    else
                    {
                        workbook = new HSSFWorkbook(fileStream);
                        tablename = filename.Replace(".xls", "");
                    }
                    ISheet sheet = workbook.GetSheetAt(0);
                    IRow row;
                    DataTable dataTable = new DataTable();
                    dataTable.TableName =tablename.Substring(tablename.LastIndexOf("\\")+1);
                    if (Top < 2)
                        Top = 2;
                    int i = Top - 2;
                    row = sheet.GetRow(i);
                    string[] name = new string[row.LastCellNum + 1];
                    name[row.LastCellNum] = sheet.LastRowNum.ToString();
                    for (int t = row.FirstCellNum; t < row.LastCellNum; t++)
                    {
                        if (row.GetCell(t) != null)
                        {
                            name[t] = row.GetCell(t).ToString();
                            dataTable.Columns.Add(row.GetCell(t).ToString());//建列
                        }
                        else
                        {
                            name[t] = "";
                        }
                    }
                    for (i = i + 1; i < sheet.LastRowNum + 1; i++)
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
                    dataGridView1.DataSource = dataTable;
                    if (Table == "F")
                        a1 = dataTable;
                    else if (Table == "C")
                        a2 = dataTable;
                    fileStream.Close();
                    workbook = null;
                    return name;
                }
                else
                {
                    MessageBox.Show("请选择Excel文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
            }
            catch
            {
                MessageBox.Show("该文件已被其他程序占用或打开！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void RdFu_Click(object sender, EventArgs e)//读取数据源
        {
            if (Ftext.Text == "" || Ftext.Text == null)
                MessageBox.Show("请选择Excel文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DirectoryInfo info = new DirectoryInfo(Ftext.Text);
                Cplublic.A1 = ReadExcel(info.Name, Ftext.Text, int.Parse(textBox1.Text), "F");
                if (Cplublic.A1 != null)
                {
                    Lable.Text = info.Name + "共：" + Cplublic.A1[^1] + "条数据";
                    comboBox1.Items.Clear();
                    for (int t = 0; t < Cplublic.A1.Length - 1; t++)
                        comboBox1.Items.Add(Cplublic.A1[t]);
                    //comboBox1.SelectedIndex = 0;//设置默认选项
                    Tiao1.Checked = true;
                    pictureBox5.Visible = false;
                }
                else
                    MessageBox.Show("Excel读取出错，请联系管理员！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Rdch_Click(object sender, EventArgs e)//读取待处理文件
        {
            if (Ctext.Text == "" || Ctext.Text == null)
                MessageBox.Show("请选择Excel文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                DirectoryInfo info = new DirectoryInfo(Ctext.Text);
                Cplublic.B1 = ReadExcel(info.Name, Ctext.Text, int.Parse(textBox1.Text), "C");
                if (Cplublic.B1 != null)
                {
                    Lable.Text = info.Name + "共：" + Cplublic.B1[^1] + "条数据";
                    comboBox2.Items.Clear();
                    for (int t = 0; t < Cplublic.B1.Length - 1; t++)
                        comboBox2.Items.Add(Cplublic.B1[t]);
                    //comboBox2.SelectedIndex = 0;//设置默认选项
                    Tiao2.Checked = true;
                    pictureBox5.Visible = false;
                }
                else
                    MessageBox.Show("Excel读取出错，请联系管理员！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Cplublic.A1 != null && Cplublic.B1 != null)
            {
                if (ActiveMdiChild != null)
                {
                    ActiveMdiChild.Close();
                }
                TianCTJ f = new TianCTJ();
                f.ShowDialog();
                if (Cplublic.Lable == "200")
                    Tiao4.Checked = true;
                else
                    Tiao4.Checked = false;
            }
            else
                MessageBox.Show("数据源未正确设置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                Tiao4.Checked = true;
            else
            {
                if (Cplublic.TA1 == null || Cplublic.TB1 == null)
                    Tiao4.Checked = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Tiao1.Checked == false || Tiao2.Checked == false || Tiao3.Checked == false || Tiao4.Checked == false)
            {
                MessageBox.Show("对比准备未完成，请检查设置！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox5.Visible = false;
                return;
            }
            else
            {
                //int index1 = Array.IndexOf(Cplublic.A1,comboBox1.Text);
                if (checkBox1.Checked == false)
                {
                    int index2 = Array.IndexOf(Cplublic.B1, comboBox2.Text);
                    DataTable dataTable;
                    dataTable = a2.Clone();
                    DataRow[] dr;
                    for (int i = 0; i < a2.Rows.Count; i++)
                    {
                        if (a2.Rows[i][index2].ToString() != "")//条件列值是否为空
                        {
                            if (comboBox3.Text != "like")
                                dr = a1.Select(comboBox1.Text + " " + comboBox3.Text + " '" + a2.Rows[i][index2].ToString() + "'");
                            else
                                dr = a1.Select(comboBox1.Text + " " + comboBox3.Text + " '%" + a2.Rows[i][index2].ToString() + "%' ");
                            if (dr.Length>0)//查询结果是否为空
                            {
                                for (int t = 0; t < dr.Length; t++)
                                {
                                    DataRow dc = a2.Rows[i];
                                    //dc[biiteml.Text] = dr[t][a1itm.Text].ToString();
                                    for (int y = 0; y < Cplublic.TA1.Length; y++)
                                    {
                                        dc[Cplublic.TB1[y]] = dr[t][Cplublic.TA1[y]].ToString();
                                    }
                                    dataTable.Rows.Add(dc.ItemArray);
                                }
                            }
                            else//为空填充当前行
                            {
                                DataRow dc = a2.Rows[i];
                                dataTable.Rows.Add(dc.ItemArray);
                            }
                        }
                        else //如果所选条件为空则改行直接填充
                        {
                            DataRow dc = a2.Rows[i];
                            dataTable.Rows.Add(dc.ItemArray);
                        }
                    }
                    a3 = dataTable;
                    dataGridView1.DataSource = a3;
                    Lable.Text = a3.TableName + "填充数据共：" + a3.Rows.Count;
                }
                else
                {
                    int index2 = Array.IndexOf(Cplublic.B1, comboBox2.Text);
                    DataTable dataTable;
                    dataTable = a2.Clone();
                    DataRow[] dr;
                    for (int i = 0; i < a2.Rows.Count; i++)
                    {
                        if (a2.Rows[i][index2].ToString() != "")
                        {
                            if (comboBox3.Text != "like")
                                dr = a1.Select(comboBox1.Text + " " + comboBox3.Text + " '" + a2.Rows[i][index2].ToString() + "'");
                            else
                                dr = a1.Select(comboBox1.Text + " " + comboBox3.Text + " '%" + a2.Rows[i][index2].ToString() + "%' ");
                            if (dr.Length > 0)
                            {
                                for (int t = 0; t < dr.Length; t++)
                                {
                                    DataRow dc = a2.Rows[i];
                                    //dc[biiteml.Text] = dr[t][a1itm.Text].ToString();
                                    for (int y = 0; y < Cplublic.B1.Length - 1; y++)
                                    {
                                        if (Array.IndexOf(Cplublic.A1, Cplublic.B1[y]) >= 0)
                                            dc[Cplublic.B1[y]] = dr[t][Array.IndexOf(Cplublic.A1, Cplublic.B1[y])].ToString();
                                    }
                                    dataTable.Rows.Add(dc.ItemArray);
                                }
                            }
                            else
                            {
                                DataRow dc = a2.Rows[i];
                                dataTable.Rows.Add(dc.ItemArray);
                            }
                        }
                        else //如果所选条件为空则改行直接填充
                        {
                            DataRow dc = a2.Rows[i];
                            dataTable.Rows.Add(dc.ItemArray);
                        }
                    }
                    a3 = dataTable;
                    dataGridView1.DataSource = a3;
                    Lable.Text = a3.TableName + "填充数据共：" + a3.Rows.Count;
                }
                pictureBox5.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
                Tiao3.Checked = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && comboBox2.Text != "")
                Tiao3.Checked = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)//导出
        {
            try
            {
                if (a3 == null)
                {
                    MessageBox.Show("结果集为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pictureBox5.Visible = false;
                    return;
                }
                if (a3.Rows.Count > 0)
                {
                    XSSFWorkbook workbook = new XSSFWorkbook();
                    workbook.CreateSheet("sheet1");
                    XSSFSheet sheet = (XSSFSheet)workbook.GetSheet("sheet1");
                    for (int h = 0; h < a3.Rows.Count + 1; h++)
                        sheet.CreateRow(h);
                    XSSFRow sheetrow = (XSSFRow)sheet.GetRow(0);
                    XSSFCell[] sheetcell = new XSSFCell[Cplublic.B1.Length - 1];
                    for (int i = 0; i < Cplublic.B1.Length - 1; i++)
                    {
                        sheetcell[i] = (XSSFCell)sheetrow.CreateCell(i);
                        sheetcell[i].SetCellValue(Cplublic.B1[i]);
                        sheet.SetColumnWidth(i, 18 * 256);
                    }
                    for (int i = 0; i < a3.Rows.Count; i++)
                    {
                        sheetrow = (XSSFRow)sheet.GetRow(i + 1);
                        for (int t = 0; t < Cplublic.B1.Length - 1; t++)
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
                        FileName = a2.TableName + "填充.xlsx",
                        //设置默认文件类型显示顺序 
                        FilterIndex = 1,
                        //  InitialDirectory = @"C:\Users\Administrator\Desktop",//是否设置默认打开路径
                        //保存对话框是否记忆上次打开的目录 
                        RestoreDirectory = true
                    };
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
                        MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        pictureBox5.Visible = false;
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
                MessageBox.Show("导出错误！请联系管理员！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void RdFu_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = true;
        }

        private void Rdch_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Visible = true;
        }
    }
}
