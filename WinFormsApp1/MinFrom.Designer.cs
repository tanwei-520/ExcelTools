
namespace WinFormsApp1
{
    partial class del1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(del1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.替换列值ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据对比ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.更多工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.替换列值ToolStripMenuItem,
            this.数据对比ToolStripMenuItem1,
            this.更多工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1334, 32);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 替换列值ToolStripMenuItem
            // 
            this.替换列值ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("替换列值ToolStripMenuItem.Image")));
            this.替换列值ToolStripMenuItem.Name = "替换列值ToolStripMenuItem";
            this.替换列值ToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.替换列值ToolStripMenuItem.Text = "替换列值";
            this.替换列值ToolStripMenuItem.Click += new System.EventHandler(this.选择文件ToolStripMenuItem_Click);
            // 
            // 数据对比ToolStripMenuItem1
            // 
            this.数据对比ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("数据对比ToolStripMenuItem1.Image")));
            this.数据对比ToolStripMenuItem1.Name = "数据对比ToolStripMenuItem1";
            this.数据对比ToolStripMenuItem1.Size = new System.Drawing.Size(93, 24);
            this.数据对比ToolStripMenuItem1.Text = "数据对比";
            this.数据对比ToolStripMenuItem1.Click += new System.EventHandler(this.选择文件夹ToolStripMenuItem1_Click);
            // 
            // 更多工具ToolStripMenuItem
            // 
            this.更多工具ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("更多工具ToolStripMenuItem.Image")));
            this.更多工具ToolStripMenuItem.Name = "更多工具ToolStripMenuItem";
            this.更多工具ToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.更多工具ToolStripMenuItem.Text = "更多工具";
            this.更多工具ToolStripMenuItem.Click += new System.EventHandler(this.数据对比ToolStripMenuItem_Click);
            // 
            // del1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1334, 747);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "del1";
            this.RightToLeftLayout = true;
            this.Text = "Excel工具";
            this.Load += new System.EventHandler(this.del1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 替换列值ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据对比ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 更多工具ToolStripMenuItem;
    }
}

