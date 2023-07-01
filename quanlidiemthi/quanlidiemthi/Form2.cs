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
    public partial class Form2 : Form
    {
        Modify modify = new Modify();
        public Form2()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectItem = comboBox1.SelectedItem.ToString().Trim();

            string query = "SELECT *, (diemToan + diemVan + diemNgoaiNgu) / 3 AS diemTrungBinh FROM diemSV ";

            if (selectItem == "Gioi")
            {
                query += "WHERE (diemToan + diemVan + diemNgoaiNgu) / 3 >= 8";
            }
            else if (selectItem == "Kha")
            {
                query += "WHERE ((diemToan + diemVan + diemNgoaiNgu) / 3) >= 6.5 AND ((diemToan + diemVan + diemNgoaiNgu) / 3) < 8";
            }
            else
            {
                query += "WHERE (diemToan + diemVan + diemNgoaiNgu) / 3 < 6.5";
            }
            DataTable dt = modify.GetDataTable(query);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[5].Visible = false;
            
        }
    }
}
