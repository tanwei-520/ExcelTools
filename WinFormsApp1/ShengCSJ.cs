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
    public partial class ShengCSJ : Form
    {
       private static int y = 2;
       private static int y2 = 12;
       private static int y3 = 3;
       private static int i = 1;
       private static string[] TB;
       private static string[] GD;
       private static string[] LJ;
       private static DataTable a;
       private static DataTable a1;
        public ShengCSJ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
            try
            {
                if (Ftext.Text != "" && (Ftext.Text.LastIndexOf(".xlsx") > 0 || Ftext.Text.LastIndexOf(".xls") > 0))
                {
                    FileStream fileStream = new FileStream(@"" + Ftext.Text + "", FileMode.Open);
                    IWorkbook workbook;
                    string tablename;
                    if (Ftext.Text.LastIndexOf(".xlsx") > 0)
                    {
                        workbook = new XSSFWorkbook(fileStream);
                        tablename = Ftext.Text.Replace(".xlsx", "");
                    }
                    else
                    {
                        workbook = new HSSFWorkbook(fileStream);
                        tablename = Ftext.Text.Replace(".xls", "");
                    }
                    ISheet sheet = workbook.GetSheetAt(0);
                    IRow row;
                    DataTable dataTable = new DataTable();
                    dataTable.TableName = tablename.Substring(tablename.LastIndexOf("\\")+1); ;
                    int Top = int.Parse(textBox1.Text);
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
                    a = dataTable;
                    label7.Text = dataTable.TableName + "共：" + name[row.LastCellNum];
                    fileStream.Close();
                    workbook = null;
                    TB = name;
                    a.Columns.Add("Name1245");
                }
                else
                {
                    MessageBox.Show("请选择Excel文件！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("该文件已被其他程序占用或打开！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)//增加文本框
        {
            int t = panel1.VerticalScroll.Value;
            Label Biao = new Label();
            Biao.Text = i + ".";
            if (i < 10)
            {
                Biao.Size = new Size(18, 17);
                Biao.Location = new Point(16, y2 - t);
            }
            else
            {
                Biao.Size = new Size(28, 17);
                Biao.Location = new Point(10, y2 - t);
            }
            TextBox textBox = new TextBox
            {
                    Location = new Point(40, y - t),
                    Size = new Size(139, 25),
                    Name = "T" + i,
                    Font=new Font(Font.FontFamily,10,Font.Style)
            };
            TextBox textBox2 = new TextBox
            {
                Location = new Point(238, y3 - t),
                Size = new Size(66, 25),
                Name = "L" + i,
                Text = "-",
                TextAlign =System.Windows.Forms.HorizontalAlignment.Center,
                Font = new Font(Font.FontFamily, 10, Font.Style)
            };
            panel1.Controls.Add(textBox);
            panel1.Controls.Add(Biao);
            panel1.Controls.Add(textBox2);
            i++;
            y += 30;
            y2 += 30;
            y3 += 30;
        }

        private void ShengCSJ_Load(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
        }

        private void pictureBox5_Click(object sender, EventArgs e)//增加下拉框
        {
            if (TB == null)
            {
                MessageBox.Show("Excel文件还未正确设置！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int t = panel1.VerticalScroll.Value;
            Label Biao = new Label();
            Biao.Text = i + ".";
            if (i < 10)
            {
                Biao.Size = new Size(18, 17);
                Biao.Location = new Point(16, y2 - t);
            }
            else
            {
                Biao.Size = new Size(28, 17);
                Biao.Location = new Point(10, y2 - t);
            }
            ComboBox comboBox = new ComboBox
            {
                Location = new Point(40, y - t),
                Size = new Size(139, 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Name = "T" + i,
            };
            for (int i = 0; i < TB.Length-1; i++)
                comboBox.Items.Add(TB[i]);
            comboBox.SelectedIndex = 0;
            TextBox textBox2 = new TextBox
            {
                Location = new Point(238, y3 - t),
                Size = new Size(66, 25),
                Name = "L" + i,
                Text = "-",
                TextAlign = System.Windows.Forms.HorizontalAlignment.Center,
                Font = new Font(Font.FontFamily, 10, Font.Style)
            };
            panel1.Controls.Add(comboBox);
            panel1.Controls.Add(Biao);
            panel1.Controls.Add(textBox2);
            i++;
            y += 30;
            y2 += 30;
            y3 += 30;
        }

        private void pictureBox7_Click(object sender, EventArgs e)//清除规则
        {
            this.panel1.Controls.Clear();
             y = 2;
             y2 = 12;
             y3 = 3;
             i = 1;
            GD = null;
            LJ = null;
            checkBox1.Checked = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)//保存规则
        {
            LJ = new string[i - 1];
            GD = new string[i - 1];
            int t = 0, y = 0;
            foreach (Control control in this.panel1.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    GD[t] = comboBox.Text;
                    t++;
                }
                if(control is TextBox)
                {
                    if (control.Name.IndexOf("T") >= 0)
                    {
                        TextBox textBox = (TextBox)control;
                        GD[t] = textBox.Text;
                        t++;
                    }
                }
                if (control is TextBox)
                {
                    if (control.Name.IndexOf("L") >= 0)
                    {
                        TextBox textBox = (TextBox)control;
                        LJ[y] = textBox.Text;
                        y++;
                    }
                }
            }
            if(GD!=null&&LJ!=null)
             checkBox1.Checked = true;
            else
              MessageBox.Show("规则保存可能出现错误！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                MessageBox.Show("当前规则为空！请确认是否保存！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                DataTable dataTable;
                DataTable dataTable1=new DataTable();
                dataTable1.Columns.Add("Name1245");
                dataTable = a.Clone();
                DataRow[] dr;
                string str="";
            for (int i = 0; i < a.Rows.Count; i++)
            {
                DataRow dc = a.Rows[i];
                for (int t = 0; t < GD.Length; t++)
                {
                    if (Array.IndexOf(TB, GD[t]) > 0)
                    {
                        str += a.Rows[i][Array.IndexOf(TB, GD[t])];
                        str += LJ[t];
                    }
                    else
                    {
                        str += GD[t];
                        str += LJ[t];
                    }                          
                }
                if (checkBox2.Checked == true)
                {
                    DataRow dd = dataTable1.NewRow();
                    dd["Name1245"] = str;
                    dataTable1.Rows.Add(dd.ItemArray);
                    dr = dataTable1.Select("Name1245= '" + str + "'");
                    if (dr.Length >1)
                        str += "_" + (dr.Length).ToString();
                }
                dc["Name1245"] = str;
                dataTable.Rows.Add(dc.ItemArray);
                str = "";
            }
           a1 = dataTable;
           dataGridView1.DataSource = a1;
           label4.Text = a1.TableName + "数据共：" + a1.Rows.Count;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            try
            {
                if (a1 == null)
                {
                    MessageBox.Show("结果集为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pictureBox5.Visible = false;
                    return;
                }
                if (a1.Rows.Count > 0)
                {
                    XSSFWorkbook workbook = new XSSFWorkbook();
                    workbook.CreateSheet("sheet1");
                    XSSFSheet sheet = (XSSFSheet)workbook.GetSheet("sheet1");
                    for (int h = 0; h < a1.Rows.Count + 1; h++)
                        sheet.CreateRow(h);
                    XSSFRow sheetrow = (XSSFRow)sheet.GetRow(0);
                    XSSFCell[] sheetcell = new XSSFCell[TB.Length];
                    for (int i = 0; i < TB.Length - 1; i++)
                    {
                        sheetcell[i] = (XSSFCell)sheetrow.CreateCell(i);
                        sheetcell[i].SetCellValue(TB[i]);
                        sheet.SetColumnWidth(i, 18 * 256);
                    }
                    sheetcell[TB.Length-1] = (XSSFCell)sheetrow.CreateCell(TB.Length-1);
                    sheetcell[TB.Length-1].SetCellValue("生成字符");
                    sheet.SetColumnWidth(TB.Length-1, 18 * 288);
                    for (int i = 0; i < a1.Rows.Count; i++)
                    {
                        sheetrow = (XSSFRow)sheet.GetRow(i + 1);
                        for (int t = 0; t < a1.Columns.Count; t++)
                        {
                            sheetcell[t] = (XSSFCell)sheetrow.CreateCell(t);
                            if (a1.Rows[i][t] != null || a1.Rows[i][t].ToString() == "")
                            {
                                sheetcell[t].SetCellValue(a1.Rows[i][t].ToString());
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
                        FileName = a1.TableName + "拼接数据.xlsx",
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
    }
}
