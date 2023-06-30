using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysinhvien
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int gioitinh = radioButton1.Checked == true ? 1 : 0;
            string masv = textBox1.Text;
            string noisinh = comboBox1.SelectedItem.ToString();
            if (masv != "")
            {
                string query = "SELECT id, MaSV AS 'Ma SV', HoTen AS 'Ho Ten', format(NgaySinh, 'd/M/yyyy') AS 'Ngay Sinh', NoiSinh AS 'Noi Sinh', case when GioiTinh = 0 Then 'Nu' Else 'Nam' end as 'Gioi tinh' FROM sinhvien where NoiSinh = '"+noisinh+"' and MaSV = '"+masv+"' and GioiTinh = '"+gioitinh+"'";
                Form1 form = (Form1) Application.OpenForms["Form1"];
                form.setquery(query);
            }
                else
            {
                MessageBox.Show("Can phai dien het tat ca cac truong");
            }

        }
    }
}
