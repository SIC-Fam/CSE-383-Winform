using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    internal class Modify
    {
        public Modify() { }

        SqlCommand cmd;

        public void Command(string query)
        {
            using (SqlConnection connnection = Connection.GetSqlConnection())
            {
                connnection.Open();
                cmd = new SqlCommand(query, connnection);
                cmd.ExecuteNonQuery();
                connnection.Close();

            }
        }

        public DataTable GetDataTable(string query)
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                cmd = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                connection.Close();
                return dt;

            }
        }
    }
}
