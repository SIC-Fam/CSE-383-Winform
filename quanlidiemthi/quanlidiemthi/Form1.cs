using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlidiemthi
{
    public partial class Form1 : Form
    {
        Modify modify = new Modify();

        public bool checkDiem (int diem)
        {
            return diem >= 0 && diem <= 10;
        }

        public void load()
        {
            string query = "select *, (diemToan + diemVan + diemNgoaiNgu) / 3 AS diemTrungBinh from diemSV";
            DataTable dt = modify.GetDataTable(query);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[5].Visible = false;
        }
        public Form1()
        {
            InitializeComponent();
            load();
        }

        private void thốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masv = MASV.Text;
            string hoten = HOTEN.Text;
            string toan =(TOAN.Text);
            string van = (VAN.Text);
            string ngoaingu = (NGOAINGU.Text);
            if (masv == "" || hoten == "" || toan == "" || van == "" || ngoaingu == "")
            {
                MessageBox.Show("Hay nhap het tat ca cac truong");
            }
            else if(checkDiem(int.Parse(toan)) ==false || checkDiem(int.Parse(van)) ==false || checkDiem(int.Parse(ngoaingu)) == false)
            {
                MessageBox.Show("Diem nhap vao phai trong khoang tu 0 den 10");
            } else
            {
                string query = "insert into diemSV values(N'" + masv + "', N'" + hoten + "', '" + int.Parse(toan) + "', '" + int.Parse(van) + "', '" + int.Parse(ngoaingu) + "')";
                modify.Command(query);
                load();
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MASV.Text = dataGridView1.CurrentRow.Cells["maSV"].Value.ToString();
            HOTEN.Text = dataGridView1.CurrentRow.Cells["tenSV"].Value.ToString();
            TOAN.Text = dataGridView1.CurrentRow.Cells["diemToan"].Value.ToString();
            VAN.Text = dataGridView1.CurrentRow.Cells["diemVan"].Value.ToString();
            NGOAINGU.Text = dataGridView1.CurrentRow.Cells["diemNgoaiNgu"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string masv = MASV.Text;
            string hoten = HOTEN.Text;
            int toan = int.Parse(TOAN.Text);
            int van = int.Parse(VAN.Text);
            int ngoaingu = int.Parse(NGOAINGU.Text);

            string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

            string query = "update diemSV set maSV = N'" + masv + "', tenSV = N'" + hoten + "', diemToan = '" + toan + "', diemVan = '" + van + "', diemNgoaiNgu = '" + ngoaingu + "' where id = '"+id+"'";
            modify.Command(query);
            load();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

            string query = "delete from diemSV where id = '" + id + "'";
            modify.Command(query);
            load();
        }
    }
}
