using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De07
{
    public partial class Form1 : Form
    {
        double PHU_THU = 0.05;
        double THUE = 0.08;
        Modify modify = new Modify();
        public Form1()
        {
            InitializeComponent();
        }

        public bool Check()
        {
            if (thue.Text == ""||
            hoTen.Text == ""||
            diaChi.Text == ""||
            dienThoai.Text == ""||
            giaTien.Text == ""||
            thue.Text == ""||
            thanhTien.Text == ""||
            phuThu.Text =="" || (radioBlack.Checked ==false && radioOther.Checked ==false))
            {
                return false;
            }
            return true;
        }

        public void Reset()
        {
            thue.Text = "";
            hoTen.Text = "";
            diaChi.Text = "";
            dienThoai.Text = "";
            giaTien.Text = "";
            thue.Text = "";
            thanhTien.Text = "";
            phuThu.Text = "";
            hoTen.Focus();
            nextButton.Enabled = false;
        }

        public void Tinh()
        {
            try
            {
                double gia = double.Parse(giaTien.Text);
                thue.Text = (Math.Round(gia * THUE)).ToString();
                phuThu.Text = (Math.Round(gia * PHU_THU)).ToString();
                thanhTien.Text = (int.Parse(giaTien.Text) + int.Parse(thue.Text) + int.Parse(phuThu.Text)).ToString();
                nextButton.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Chi nhap gia tri la so");
            }
        }

        private void giaTien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Tinh();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Ban co that su muon dong cua so", "Xac nhan", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Check() == true)
            {
                int mau = radioBlack.Checked ? 1 : 0;
                string query = "insert into TTHoaDon values(N'" + hoTen.Text + "',N'"+diaChi.Text+"',N'"+dienThoai.Text+"','"+ mau+"', '"+int.Parse(giaTien.Text)+ "', '"+int.Parse(thanhTien.Text)+"')";
                modify.Command(query);
                Reset();
            }
            else
            {
                MessageBox.Show("Can dien day du het cac truong");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int doanhThu_Den = modify.Get_DoanhThu(1);
            int doanhThu_other = modify.Get_DoanhThu(0);
            MessageBox.Show($"Doanh thu xe mau den la: {doanhThu_Den}\nDoanh thu xe mau khac la: {doanhThu_other}");
        }
    }
}
