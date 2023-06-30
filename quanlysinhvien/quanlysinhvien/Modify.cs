using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlysinhvien
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand cmd;
        public void Command(string query) { 
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                try
                {

                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                }
                    catch
                {
                    MessageBox.Show("Invalid MaSv");
                }
                conn.Close();
            }
        }

        public DataTable GetDataTable(string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                DataTable dt = new DataTable();
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close();
                return dt;
            }
        }
    }
}
