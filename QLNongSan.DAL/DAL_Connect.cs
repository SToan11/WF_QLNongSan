using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNongSan.DAL
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=DESKTOP-CNGEDRR\\MSSQLSERVER01;Initial Catalog=QuanLiNongSan_fix3;Integrated Security=True;");
    }
}
