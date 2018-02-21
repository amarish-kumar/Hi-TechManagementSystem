using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.BLL; //ADD
using System.Data.SqlClient; //ADD

namespace ClassLibrary1.DAL
{
    public static class EmployeeDB
    {
        //Save Method
        public static bool SaveRecord(Employee emp)
        {
            bool success = false;

            try
            {
                string sqlInsert = "INSERT INTO Employees " +
                                "VALUES (@FirstName,@LastName,@JobTitle,@UserType,@Password,@Email)";

                SqlConnection sqlConn = UtilityDB.ConnectDB();

                SqlCommand sqlCmd = new SqlCommand(sqlInsert, sqlConn);
                sqlCmd.Parameters.AddWithValue("@FirstName", emp.FirstName);
                sqlCmd.Parameters.AddWithValue("@LastName", emp.LastName);
                sqlCmd.Parameters.AddWithValue("@JobTitle", emp.JobTitle);
                sqlCmd.Parameters.AddWithValue("@UserType", emp.UserType);
                sqlCmd.Parameters.AddWithValue("@Password", emp.Password);
                sqlCmd.Parameters.AddWithValue("@Email", emp.Email);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                success = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return success;
        }

        //Delete Method
        public static bool DeleteRecord(int empId)
        {
            bool success = false;
            try
            {
                string sqlDelete = "DELETE FROM employees " +
                               "WHERE employeeId = " + empId;

                SqlConnection sqlConn = UtilityDB.ConnectDB();
                SqlCommand sqlCmd = new SqlCommand(sqlDelete, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                success = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return success;
        }

        //Search Method
        public static Employee SearchRecordById(int empId)
        {
            Employee emp = new Employee();
            string sqlSelect = "SELECT * FROM Employees " +
                               "WHERE employeeId = " + empId;

            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            if (sqlReader.Read())
            {
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                emp.UserType = sqlReader["UserType"].ToString();
                emp.Password = sqlReader["Password"].ToString();
                emp.Email = sqlReader["Email"].ToString();
            }
            else
            {
                emp = null;
            }

            sqlConn.Close();
            return emp;
        }

        //List Method
        public static List<Employee> ListRecords()
        {
            List<Employee> listEmp = new List<Employee>();

            string sqlSelect = "SELECT * FROM Employees ";

            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();

            while (sqlReader.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeId = Convert.ToInt32(sqlReader["EmployeeId"]);
                emp.FirstName = sqlReader["FirstName"].ToString();
                emp.LastName = sqlReader["LastName"].ToString();
                emp.JobTitle = sqlReader["JobTitle"].ToString();
                emp.UserType = sqlReader["UserType"].ToString();
                emp.Password = sqlReader["Password"].ToString();
                emp.Email = sqlReader["Email"].ToString();

                listEmp.Add(emp);
            }
            sqlConn.Close();
            return listEmp;
        }

        //Authentication Method
        public static string Password_Authentication(int empId)
        {
            string sqlSelect = "SELECT password FROM Employees " +
                           "WHERE employeeId = " + empId;

            SqlConnection sqlConn = UtilityDB.ConnectDB();
            SqlCommand sqlCmd = new SqlCommand(sqlSelect, sqlConn);
            SqlDataReader sqlReader = sqlCmd.ExecuteReader();
            string sqlPassword = string.Empty;

            if (sqlReader.HasRows)
            {
                while (sqlReader.Read())
                {
                    sqlPassword = sqlReader["Password"].ToString();
                }
            }

            sqlConn.Close();
            return sqlPassword;
        }

        //Change password
        public static bool ChangePassword(Employee emp)
        {
            bool success = false;

            try
            {
                string sqlUpdate = "UPDATE Employees " +
                                " SET password = '" + emp.Password + "'" +
                                " WHERE EmployeeId = " + emp.EmployeeId;

                SqlConnection sqlConn = UtilityDB.ConnectDB();
                SqlCommand sqlCmd = new SqlCommand(sqlUpdate, sqlConn);
                sqlCmd.ExecuteNonQuery();
                sqlConn.Close();
                success = true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return success;
        }

    }
}
