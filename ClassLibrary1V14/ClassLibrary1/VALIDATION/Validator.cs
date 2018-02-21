using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //ADD
using System.Configuration; //ADD
using ClassLibrary1.BLL; //ADD
using ClassLibrary1.DAL;

namespace ClassLibrary1.VALIDATION
{
    public static class Validator
    {
        //public static Employee SearchPasswordById(int empId)
        //{
        //    Employee emp = new Employee();
        //    string sqlSelect = "SELECT * FROM Employees " +
        //                       "WHERE employeeId = " + empId;

        //    SqlConnection sqlConn = UtilityDB.ConnectDB();
        //    SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
        //    SqlDataReader sqlReader = sqlCmd.ExecuteReader();

        //    if (sqlReader.Read())
        //    {               
        //        emp.Password = sqlReader["Password"].ToString();
        //    }
        //    else
        //    {
        //        emp = null;
        //    }

        //    sqlConn.Close();
        //    return emp;
        //}

        public static bool ValidatePassword(int empId, string password)
        {
            bool success = false;
            try
            {
                Employee emp = new Employee();
                string sqlSelect = "SELECT * FROM Employees " +
                               "WHERE employeeId = " + empId;

                SqlConnection sqlConn = UtilityDB.ConnectDB();
                SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
                SqlDataReader sqlReader = sqlCmd.ExecuteReader();
                if (sqlReader.Read())
                {
                    emp.Password = sqlReader["Password"].ToString();
                }
                else
                {
                    emp = null;
                }

                if (emp.Password == password)
                {
                    success = true;
                }


            }
            catch (SqlException ex)
            {

                throw ex;
            }


            return success;
        }

    }
}
