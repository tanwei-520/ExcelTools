
namespace WinFormsApp1
{
    partial class DuiBiFrom
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ftext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Ctext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RdFu = new System.Windows.Forms.Button();
            this.Rdch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择父数据源：";
            // 
            // Ftext
            // 
            this.Ftext.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ftext.Location = new System.Drawing.Point(310, 50);
            this.Ftext.Name = "Ftext";
            this.Ftext.ReadOnly = true;
            this.Ftext.Size = new System.Drawing.Size(709, 25);
            this.Ftext.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1062, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1062, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ctext
            // 
            this.Ctext.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ctext.Location = new System.Drawing.Point(310, 99);
            this.Ctext.Name = "Ctext";
            this.Ctext.ReadOnly = true;
            this.Ctext.Size = new System.Drawing.Size(709, 25);
            this.Ctext.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(197, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "选择子数据源：";
            // 
            // RdFu
            // 
            this.RdFu.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RdFu.Location = new System.Drawing.Point(500, 142);
            this.RdFu.Margin = new System.Windows.Forms.Padding(0);
            this.RdFu.Name = "RdFu";
            this.RdFu.Padding = new System.Windows.Forms.Padding(4);
            this.RdFu.Size = new System.Drawing.Size(113, 35);
            this.RdFu.TabIndex = 6;
            this.RdFu.Text = "读取父数据源";
            this.RdFu.UseVisualStyleBackColor = true;
            // 
            // Rdch
            // 
            this.Rdch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Rdch.Location = new System.Drawing.Point(710, 142);
            this.Rdch.Name = "Rdch";
            this.Rdch.Padding = new System.Windows.Forms.Padding(4);
            this.Rdch.Size = new System.Drawing.Size(113, 35);
            this.Rdch.TabIndex = 8;
            this.Rdch.Text = "读取子数据源";
            this.Rdch.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(197, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "设置先决条件：";
            // 
            // DuiBiFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 711);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rdch);
            this.Controls.Add(this.RdFu);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Ctext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ftext);
            this.Controls.Add(this.label1);
            this.Name = "DuiBiFrom";
            this.Text = "对比数据";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DuiBiFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ftext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Ctext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RdFu;
        private System.Windows.Forms.Button Rdch;
        private System.Windows.Forms.Label label3;
    }
}