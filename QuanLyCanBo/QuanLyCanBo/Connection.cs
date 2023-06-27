using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCanBo
{
    internal class Connection
    {
        private static string connectionStr = "Data Source=DESKTOP-5QF04B0\\SQLEXPRESS;Initial Catalog=quanlicanbo;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionStr);
        }
    }
}
