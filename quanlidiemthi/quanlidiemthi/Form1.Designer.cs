namespace quanlidiemthi
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanrLýĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MASV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HOTEN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TOAN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.VAN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NGOAINGU = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanrLýĐiểmToolStripMenuItem,
            this.thốngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(553, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanrLýĐiểmToolStripMenuItem
            // 
            this.quanrLýĐiểmToolStripMenuItem.Name = "quanrLýĐiểmToolStripMenuItem";
            this.quanrLýĐiểmToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.quanrLýĐiểmToolStripMenuItem.Text = "Quản lý điểm";
            // 
            // thốngToolStripMenuItem
            // 
            this.thốngToolStripMenuItem.Name = "thốngToolStripMenuItem";
            this.thốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.thốngToolStripMenuItem.Text = "Thống kê ";
            this.thốngToolStripMenuItem.Click += new System.EventHandler(this.thốngToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.NGOAINGU);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.VAN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TOAN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.HOTEN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MASV);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 244);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ma SV";
            // 
            // MASV
            // 
            this.MASV.Location = new System.Drawing.Point(57, 16);
            this.MASV.Name = "MASV";
            this.MASV.Size = new System.Drawing.Size(157, 20);
            this.MASV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ho ten SV";
            // 
            // HOTEN
            // 
            this.HOTEN.Location = new System.Drawing.Point(304, 16);
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(157, 20);
            this.HOTEN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Diem toan";
            // 
            // TOAN
            // 
            this.TOAN.Location = new System.Drawing.Point(73, 42);
            this.TOAN.Name = "TOAN";
            this.TOAN.Size = new System.Drawing.Size(68, 20);
            this.TOAN.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Diem van";
            // 
            // VAN
            // 
            this.VAN.Location = new System.Drawing.Point(220, 42);
            this.VAN.Name = "VAN";
            this.VAN.Size = new System.Drawing.Size(68, 20);
            this.VAN.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Diem ngoai ngu";
            // 
            // NGOAINGU
            // 
            this.NGOAINGU.Location = new System.Drawing.Point(393, 42);
            this.NGOAINGU.Name = "NGOAINGU";
            this.NGOAINGU.Size = new System.Drawing.Size(68, 20);
            this.NGOAINGU.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(312, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Xoa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 126);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 283);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Chuong trinh quan li diem thi";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanrLýĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NGOAINGU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox VAN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TOAN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox HOTEN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MASV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

