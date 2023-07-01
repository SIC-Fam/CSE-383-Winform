using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlidiemthi
{
    internal class Modify
    {
        public Modify() { }
        SqlCommand cmd;
        public void Command(string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataTable GetDataTable(string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();

                return dt;
            }
        }
    }
}
