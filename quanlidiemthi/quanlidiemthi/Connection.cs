using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlidiemthi
{
    internal class Connection
    {
        static private string connStr = "Data Source=DESKTOP-5QF04B0\\SQLEXPRESS;Initial Catalog=quanlidiem;Integrated Security=True";
        static public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connStr);
        }
    }
}
