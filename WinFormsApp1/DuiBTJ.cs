using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class DuiBTJ : Form
    {
        private int y1 = 52;
        private int y2 = 62;
        private int ID = 2;
        public DuiBTJ()
        {
            InitializeComponent();
            for (int i = 0; i < Cplublic.A1.Length - 1; i++)
                F1.Items.Add(Cplublic.A1[i]);
            F1.SelectedIndex = 0;
            for (int i = 0; i < Cplublic.B1.Length - 1; i++)
                C1.Items.Add(Cplublic.B1[i]);
            C1.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)//添加对比
        {
            int t = panel1.VerticalScroll.Value;
            Label Biao = new Label();
            Biao.Text = ID + ".";
            if (ID< 10)
            {
                Biao.Size = new Size(18, 17);
                Biao.Location = new Point(15, y2 - t);
            }
            else
            {
                Biao.Size = new Size(28, 17);
                Biao.Location = new Point(9, y2 - t);
            }
            panel1.Controls.Add(Biao);
            y2 += 50;
            ComboBox[] Cbox = new ComboBox[2];
            Cbox[0] = new ComboBox
            {
                Location = new Point(44, y1 - t),
                Size = new Size(146, 25),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Name = "F" + ID,
            };
            for (int i = 0; i < Cplublic.A1.Length - 1; i++)
                Cbox[0].Items.Add(Cplublic.A1[i]);
            Cbox[0].SelectedIndex = 0;
            panel1.Controls.Add(Cbox[0]);
            Cbox[1] = new ComboBox();
            Cbox[1].Location = new Point(298,y1-t);
            Cbox[1].Size = new Size(146, 25);
            Cbox[1].DropDownStyle = ComboBoxStyle.DropDownList;
            Cbox[1].Name = "C" + ID;
            for (int i = 0; i < Cplublic.B1.Length - 1; i++)
                Cbox[1].Items.Add(Cplublic.B1[i]);
            Cbox[1].SelectedIndex = 0;
            panel1.Controls.Add(Cbox[1]);
            y1 += 50;
            ID += 1;
        }

        private void pictureBox2_Click(object sender, EventArgs e)//保存条件
        {
            Cplublic.TA1 = new string[ID - 1];
            Cplublic.TB1 = new string[ID - 1];
            int t = 0,i=0;
            foreach (Control control in this.panel1.Controls)
            {
                if(control is ComboBox)
                {
                    if (control.Name.IndexOf("F") >= 0)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        Cplublic.TA1[i] = comboBox.Text;
                        i++;
                    }
                    if (control.Name.IndexOf("C") >= 0)
                    {
                        ComboBox comboBox = (ComboBox)control;
                        Cplublic.TB1[t] = comboBox.Text;
                        t++;
                    }
                }
            }
            if (Cplublic.TA1 != null && Cplublic.TB1 != null)
            {
                DialogResult dr=MessageBox.Show("条件设置成功！是否关闭设置窗口？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                    this.Close();
            }
            else
            {
                MessageBox.Show("条件保存错误，请联系管理员！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cplublic.Lable = "403";
            }
        }
        private void DuiBTJ_FormClosing(object sender, FormClosingEventArgs e)//点击关闭按钮校验
        {
            if (Cplublic.TA1 != null && Cplublic.TB1 != null)
            {
                e.Cancel = false;
            }
            else
            {
                MessageBox.Show("条件设置还未保存！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }
    }
}
