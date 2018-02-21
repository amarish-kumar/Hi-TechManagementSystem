using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADD
using System.Configuration; //ADD

namespace ClassLibrary1.DAL
{
    public static class UtilityDB
    {
        public static SqlConnection ConnectDB()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["HiTech_DBConnectionString"].ConnectionString;
            conn.Open();
            return conn;
        }

    }
}
