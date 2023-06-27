using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCanBo
{
    public partial class Form1 : Form
    {
        Modify modify = new Modify();

        public void load_Data(string query)
        {
            DataTable dt = modify.GetDataTable(query);
            dataGridView1.DataSource = dt;
        }

        public void load_Data_Without_Condition()
        {
            string query = "select MaCB as 'Mã CB', HoTen as 'Họ tên', Format(NgaySinh, 'dd/MM/yyyy') as 'Ngày sinh', GioiTinh as 'Giới tính', Email, Phone from canbo";
            DataTable dt = modify.GetDataTable(query);
            dataGridView1.DataSource = dt;
        }

        public void reset () // reset all field
        {
            MaCB.Text = "";
            HoTen.Text = "";
            Email.Text = "";
            phone.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        public bool check () // To check valid input
        {
            if (
                MaCB.Text == "" ||
                HoTen.Text == "" ||
                Email.Text == "" ||
                phone.Text == "")
            {
                return false;
            }
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                return false;
            }
            return true;
        }

        public Form1()
        {
            InitializeComponent();
            load_Data_Without_Condition();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (check())
            {

            string MA = MaCB.Text;
            string HOTEN = HoTen.Text;
            string EMAIL = Email.Text;
            string PHONE = phone.Text;
            string NGAYSINH = ngaySinh.Value.ToShortDateString();
            string GIOITINH = radioButton1.Checked ? "Nam" : "Nữ";
            string query = "insert into canbo values(N'" + MA + "', N'" + HOTEN + "', '" + NGAYSINH + "', N'" + GIOITINH + "', N'" + EMAIL + "', '" + PHONE + "')";
            try
            {
                modify.Command(query);
                load_Data_Without_Condition();
                reset();
            }
            catch
            {
                MessageBox.Show("Ma CB da ton tai truoc do");
            }
            }
                 else
            {
                MessageBox.Show("Can dien het cac truong trong");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MaCB.Text = dataGridView1.CurrentRow.Cells["Mã CB"].Value.ToString();
            HoTen.Text = dataGridView1.CurrentRow.Cells["Họ tên"].Value.ToString();
            if (DateTime.TryParse(dataGridView1.CurrentRow.Cells["Ngày sinh"].Value.ToString(), out DateTime parsedDate))
            {
                ngaySinh.Value = parsedDate;
            }
            Email.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            phone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["Giới tính"].Value.ToString() == "Nam")
            {
                radioButton1.Checked = true;
            } else
            {
                radioButton2.Checked = true;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = "select MaCB as 'Mã CB', HoTen as 'Họ tên', Format(NgaySinh, 'dd/MM/yyyy') as 'Ngày sinh', GioiTinh as 'Giới tính', Email, Phone from canbo where HoTen like '%" + searchBox.Text + "%'";
            load_Data(query);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string MA = dataGridView1.CurrentRow.Cells["Mã CB"].Value.ToString();
            string query = "delete from canbo where MaCB = N'" + MA + "'";
            modify.Command(query);
            load_Data_Without_Condition();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string MA_CHOOSEN = dataGridView1.CurrentRow.Cells["Mã CB"].Value.ToString();
                string HOTEN = HoTen.Text;
                string EMAIL = Email.Text;
                string PHONE = phone.Text;
                string NGAYSINH = ngaySinh.Value.ToShortDateString();
                string GIOITINH = radioButton1.Checked ? "Nam" : "Nữ";
                string query = "update canbo set MaCB = N'" + MA_CHOOSEN + "', HoTen = N'" + HOTEN + "', NgaySinh = '" + NGAYSINH + "', GioiTinh = N'" + GIOITINH + "', Email = N'" + EMAIL + "', Phone = '" + PHONE + "' where MaCB = N'"+ MA_CHOOSEN + "'";
                modify.Command(query);
                load_Data_Without_Condition();
            }
                else
            {
                MessageBox.Show("Can dien het cac truong trong");
            }
        }
    }
}
