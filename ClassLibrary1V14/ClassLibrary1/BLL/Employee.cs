using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1.DAL; //ADD

namespace ClassLibrary1.BLL
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string UserType { get; set; }
        public string Password { get; set; }
        public string Email{ get; set; }

        public Employee()
        { }

        public bool SaveEmployee(Employee emp)
        {
            return EmployeeDB.SaveRecord(emp);
        }

        public bool DeleteEmployee(int empid)
        {
            return EmployeeDB.DeleteRecord(empid);
        }

        public Employee SearchEmployeeById(int empid)
        {
            return EmployeeDB.SearchRecordById(empid);
        }

        public List<Employee> ListEmployees()
        {
            return EmployeeDB.ListRecords();
        }

        public string Password_Authentication(int empId)
        {
            return EmployeeDB.Password_Authentication(empId);
        }

        public bool ChangePassword(Employee emp)
        {
            return EmployeeDB.ChangePassword(emp);
        }
    }
}
