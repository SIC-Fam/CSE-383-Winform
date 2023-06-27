using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De07
{
    internal class Modify
    {
        public Modify() { }

        SqlCommand cmd;


        public void Command (string query)
        {
            using (SqlConnection conn = Connection.GetSqlConnection())
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public int Get_DoanhThu (int num)
        {
            using (SqlConnection conn = Connection.GetSqlConnection ())
            {
                conn.Open();
                string query = "select * from TTHoaDon where mauXe = '"+num+"'";
                cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader ();
                int doanhThu = 0;
                while (reader.Read())
                {
                    doanhThu += int.Parse(reader["thanhTien"].ToString());
                }
                return doanhThu;
            }
        }
    }
}
