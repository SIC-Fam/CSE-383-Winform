using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlysinhvien
{
    internal class Connection
    {

        private static string sqlStr = "Data Source=DESKTOP-5QF04B0\\SQLEXPRESS;Initial Catalog=quanlisinhvien;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(sqlStr);
        }
    }
}
