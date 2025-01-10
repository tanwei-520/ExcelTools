
namespace WinFormsApp1
{
    partial class ThuanFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThuanFrom));
            filenameonly = new System.Windows.Forms.TextBox();
            button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            filelog = new System.Windows.Forms.TextBox();
            filename = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            comboBox3 = new System.Windows.Forms.ComboBox();
            label16 = new System.Windows.Forms.Label();
            button5 = new System.Windows.Forms.Button();
            label15 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label11 = new System.Windows.Forms.Label();
            fujia = new System.Windows.Forms.TextBox();
            button3 = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            sel = new System.Windows.Forms.TextBox();
            biiteml = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            a1itm = new System.Windows.Forms.ComboBox();
            button4 = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            qishih = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            Isname = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // filenameonly
            // 
            filenameonly.Location = new System.Drawing.Point(372, 118);
            filenameonly.Name = "filenameonly";
            filenameonly.ReadOnly = true;
            filenameonly.Size = new System.Drawing.Size(470, 23);
            filenameonly.TabIndex = 15;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new System.Drawing.Point(478, 174);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(92, 30);
            button2.TabIndex = 14;
            button2.Text = "读取源数据";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.MouseDown += button2_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(4);
            label1.Size = new System.Drawing.Size(66, 27);
            label1.TabIndex = 13;
            label1.Text = "选择文件";
            // 
            // filelog
            // 
            filelog.Location = new System.Drawing.Point(372, 77);
            filelog.Name = "filelog";
            filelog.ReadOnly = true;
            filelog.Size = new System.Drawing.Size(470, 23);
            filelog.TabIndex = 12;
            // 
            // filename
            // 
            filename.Location = new System.Drawing.Point(372, 28);
            filename.Name = "filename";
            filename.Size = new System.Drawing.Size(470, 23);
            filename.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(899, 24);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(37, 30);
            button1.TabIndex = 10;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(12, 408);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(1310, 291);
            dataGridView1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            label2.Location = new System.Drawing.Point(12, 353);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(4);
            label2.Size = new System.Drawing.Size(95, 27);
            label2.TabIndex = 18;
            label2.Text = "Excel中的数据";
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(fujia);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(sel);
            panel1.Controls.Add(biiteml);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(a1itm);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(qishih);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Isname);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(filename);
            panel1.Controls.Add(filelog);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(filenameonly);
            panel1.Controls.Add(button2);
            panel1.Location = new System.Drawing.Point(15, 11);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1307, 339);
            panel1.TabIndex = 20;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new System.Drawing.Point(735, 267);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(139, 25);
            comboBox3.TabIndex = 43;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(682, 295);
            label16.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(104, 17);
            label16.TabIndex = 42;
            label16.Text = "取数据源作为条件";
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(637, 265);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(92, 30);
            button5.TabIndex = 41;
            button5.Text = "置换数据";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label15.ForeColor = System.Drawing.Color.RoyalBlue;
            label15.Location = new System.Drawing.Point(6, 298);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(160, 14);
            label15.TabIndex = 40;
            label15.Text = "列名：数据起始行减一即为列名获取源";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(899, 92);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(308, 17);
            label14.TabIndex = 39;
            label14.Text = "添加先决条件，若条件为空则以处理自动和源字段为条件";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(1140, 118);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(20, 17);
            label13.TabIndex = 38;
            label13.Text = "待";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(944, 118);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(20, 17);
            label12.TabIndex = 37;
            label12.Text = "源";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(1084, 140);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(139, 25);
            comboBox2.TabIndex = 36;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(899, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(139, 25);
            comboBox1.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(726, 236);
            label11.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(116, 17);
            label11.TabIndex = 34;
            label11.Text = "附件条件（源数据）";
            // 
            // fujia
            // 
            fujia.Location = new System.Drawing.Point(880, 207);
            fujia.Multiline = true;
            fujia.Name = "fujia";
            fujia.Size = new System.Drawing.Size(204, 76);
            fujia.TabIndex = 33;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(506, 265);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(92, 30);
            button3.TabIndex = 32;
            button3.Text = "替换数据";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(587, 236);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(56, 17);
            label9.TabIndex = 31;
            label9.Text = "替换规则";
            // 
            // sel
            // 
            sel.Location = new System.Drawing.Point(659, 233);
            sel.Name = "sel";
            sel.Size = new System.Drawing.Size(61, 23);
            sel.TabIndex = 30;
            sel.Text = "like";
            // 
            // biiteml
            // 
            biiteml.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            biiteml.FormattingEnabled = true;
            biiteml.Location = new System.Drawing.Point(410, 233);
            biiteml.Name = "biiteml";
            biiteml.Size = new System.Drawing.Size(156, 25);
            biiteml.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(460, 213);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(56, 17);
            label8.TabIndex = 28;
            label8.Text = "处理字段";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(257, 210);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(68, 17);
            label7.TabIndex = 27;
            label7.Text = "源数据字段";
            // 
            // a1itm
            // 
            a1itm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            a1itm.FormattingEnabled = true;
            a1itm.Location = new System.Drawing.Point(235, 233);
            a1itm.Name = "a1itm";
            a1itm.Size = new System.Drawing.Size(139, 25);
            a1itm.TabIndex = 26;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(622, 174);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(107, 30);
            button4.TabIndex = 25;
            button4.Text = "读取待处理数据";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.RoyalBlue;
            label6.Location = new System.Drawing.Point(6, 314);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(254, 14);
            label6.TabIndex = 23;
            label6.Text = "数据起始行：Excel中数据开始的行序号（不算标题、列名等）";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(700, 148);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 17);
            label5.TabIndex = 22;
            label5.Text = "数据起始行";
            // 
            // qishih
            // 
            qishih.Location = new System.Drawing.Point(775, 144);
            qishih.Name = "qishih";
            qishih.Size = new System.Drawing.Size(67, 23);
            qishih.TabIndex = 21;
            qishih.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.Highlight;
            label4.Location = new System.Drawing.Point(572, 298);
            label4.Name = "label4";
            label4.Padding = new System.Windows.Forms.Padding(5);
            label4.Size = new System.Drawing.Size(131, 30);
            label4.TabIndex = 20;
            label4.Text = "后台进行中。。。";
            label4.Visible = false;
            // 
            // Isname
            // 
            Isname.AutoCheck = false;
            Isname.AutoSize = true;
            Isname.Checked = true;
            Isname.CheckState = System.Windows.Forms.CheckState.Checked;
            Isname.Location = new System.Drawing.Point(372, 144);
            Isname.Name = "Isname";
            Isname.Size = new System.Drawing.Size(99, 21);
            Isname.TabIndex = 19;
            Isname.Text = "是否包含列名";
            Isname.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.RoyalBlue;
            label3.Location = new System.Drawing.Point(12, 391);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(75, 14);
            label3.TabIndex = 21;
            label3.Text = "当前共：0条数据";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(1288, 369);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(34, 33);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(1184, 386);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(87, 16);
            label10.TabIndex = 23;
            label10.Text = "导出处理后的数据";
            // 
            // ThuanFrom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1334, 711);
            Controls.Add(label10);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ThuanFrom";
            Text = "替换列值";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += file_Load;
            SizeChanged += File_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox filenameonly;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filelog;
        private System.Windows.Forms.TextBox filename;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox qishih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox Isname;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox a1itm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sel;
        private System.Windows.Forms.ComboBox biiteml;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fujia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}