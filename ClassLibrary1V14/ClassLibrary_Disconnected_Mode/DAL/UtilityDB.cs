using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ClassLibrary_Disconnected_Mode.DAL
{
    public static class UtilityDB
    {
        private static string GetConnectionString()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["HiTech_DBConnectionString"].ConnectionString;
            return connectionString;
        }

        public static SqlConnection ConnectDB()
        {
            SqlConnection sqlConn = new SqlConnection(GetConnectionString());
            sqlConn.Open();
            return sqlConn;
        }

        private static SqlDataAdapter sqlDa = new SqlDataAdapter();
        private static SqlCommandBuilder sqlCmdBuilder;

        public static string tableNameClients = "Clients";
        private static string sql = "SELECT * FROM Clients";

        public static SqlDataAdapter GetDataAdapterClients()
        {
            sqlDa = new SqlDataAdapter(sql, GetConnectionString());
            sqlCmdBuilder = new SqlCommandBuilder(sqlDa);
            return sqlDa;
        }

        public static DataSet GetDataSetClients(DataSet ds, DataTable dt)
        {
            sqlDa = GetDataAdapterClients();
            sqlDa.FillSchema(ds, SchemaType.Source, tableNameClients);
            dt.PrimaryKey = new DataColumn[] { dt.Columns["ClientId"] };
            sqlDa.Fill(ds, tableNameClients);
            return ds;
        }
    }
}
