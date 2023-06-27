using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace De07
{
    internal class Connection
    {
        static private string conn = "Data Source=DESKTOP-5QF04B0\\SQLEXPRESS;Initial Catalog=cuaHangXe;Integrated Security=True";

        static public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(conn);
        }
    }
}
