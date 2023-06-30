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
    public partial class Form1 : Form
    {
        Modify modify = new Modify();

        public void load()
        {
            string query = "SELECT id, MaSV AS 'Ma SV', HoTen AS 'Ho Ten', format(NgaySinh, 'd/M/yyyy') AS 'Ngay Sinh', NoiSinh AS 'Noi Sinh', case when GioiTinh = 0 Then 'Nu' Else 'Nam' end as 'Gioi tinh' FROM sinhvien";
            dataGridView2.DataSource = modify.GetDataTable(query);
            dataGridView2.Columns[0].Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
            load();
        }
        private void thembtn_Click(object sender, EventArgs e)
        {
            string masv = maSV.Text;
            string hoten = hoTen.Text;
            string date = dateTimePicker1.Value.ToShortDateString();
            string noisinh = noiSinh.SelectedItem.ToString();
            int gioiTinh = radioButton1.Checked ? 1 : 0;
            string query = "insert into sinhvien values(N'" + masv + "', N'" + hoten + "', '" + date + "', N'" + noisinh + "', '" + gioiTinh + "')";
            modify.Command(query);
            load();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maSV.Text = dataGridView2.CurrentRow.Cells["Ma SV"].Value.ToString();
            hoTen.Text = dataGridView2.CurrentRow.Cells["Ho Ten"].Value.ToString();
            noiSinh.Text = dataGridView2.CurrentRow.Cells["Noi Sinh"].Value.ToString();
            if (dataGridView2.CurrentRow.Cells["Gioi Tinh"].Value.ToString() == "Nam") {
                radioButton1.Checked = true;
            } else
            {
                radioButton2.Checked = true;
            };
            string dateString = dataGridView2.CurrentRow.Cells["Ngay Sinh"].Value.ToString();
            if (!string.IsNullOrEmpty(dateString) && DateTime.TryParse(dateString, out DateTime dt))
            {
                dateTimePicker1.Value = dt;
            }

        }

        private void xoabtn_Click(object sender, EventArgs e)
        {
            string id = dataGridView2.CurrentRow.Cells["id"].Value.ToString();
            string query = "delete from sinhvien where id like '" + id + "'";
            modify.Command(query);
            load();
        }

        private void suabtn_Click(object sender, EventArgs e)
        {
            string masv = maSV.Text;
            string hoten = hoTen.Text;
            string date = dateTimePicker1.Value.ToShortDateString();
            string noisinh = noiSinh.SelectedItem.ToString();
            int gioiTinh = radioButton1.Checked ? 1 : 0;
            string query = "update sinhvien set MaSV = N'"+masv+"', HoTen = N'"+hoten+"', NoiSinh = N'"+noisinh+"', gioiTinh = '"+gioiTinh+"', NgaySinh = '"+date+"' where id = '" + dataGridView2.CurrentRow.Cells["id"].Value.ToString() +"'";
            modify.Command(query);
            load();
        }


        public void setquery(string query)
        {
            dataGridView2.DataSource = modify.GetDataTable(query);
        }

        private void locbtn_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
        }
    }
}
