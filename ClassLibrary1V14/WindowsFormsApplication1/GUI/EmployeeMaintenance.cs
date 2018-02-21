using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1.BLL;

namespace WindowsFormsApplication1
{
    public partial class FormEmployeeMaintenance : Form
    {
        
        public FormEmployeeMaintenance()
        {
            InitializeComponent();

            textBoxEmployeeId.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e) //OK
        {
            Employee emp = new Employee();
            emp.FirstName = textBoxFirstName.Text;
            emp.LastName = textBoxLastName.Text;
            emp.JobTitle = textBoxJobTitle.Text;
            emp.UserType = textBoxUserType.Text;
            emp.Password = textBoxPassword.Text;
            emp.Email = textBoxEmail.Text;

            if (emp.SaveEmployee(emp))
            {
                MessageBox.Show("Employee saved!");
            }
            else
            {
                MessageBox.Show("Saving problem.");
            }

        }

        private void FormEmployeeMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void buttonList_Click(object sender, EventArgs e) //ok
        {
            Employee emp = new Employee();
            List<Employee> listE = emp.ListEmployees();

            listViewEmployee.Items.Clear(); 
            if (listE != null)
            {
                foreach (Employee current in listE)
                {
                    ListViewItem item = new ListViewItem(current.EmployeeId.ToString()); 
                    item.SubItems.Add(current.FirstName);
                    item.SubItems.Add(current.LastName);
                    item.SubItems.Add(current.JobTitle);
                    item.SubItems.Add(current.UserType);
                    item.SubItems.Add(current.Password);
                    item.SubItems.Add(current.Email);

                    listViewEmployee.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No data saved.");
            }
        }

        private void listViewEmployee_SelectedIndexChanged(object sender, EventArgs e) //erro
        {
            
        }

        private void buttonDelete_Click(object sender, EventArgs e) //ok
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text);
            emp.FirstName = textBoxFirstName.Text;
            emp.LastName = textBoxLastName.Text;
            emp.JobTitle = textBoxJobTitle.Text;
            emp.UserType = textBoxUserType.Text;
            emp.Password = textBoxPassword.Text;
            emp.Email = textBoxEmail.Text;

            if (emp.DeleteEmployee(emp.EmployeeId))
            {
                MessageBox.Show("Employee deleted");
            }
            else
            {
                MessageBox.Show("Deleting problem.");
            }
        }

        private void listViewEmployee_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listViewEmployee.SelectedIndices.Count > 0)
            {
                this.textBoxEmployeeId.Text = listViewEmployee.SelectedItems[0].SubItems[0].Text;
                this.textBoxFirstName.Text = listViewEmployee.SelectedItems[0].SubItems[1].Text;
                this.textBoxLastName.Text = listViewEmployee.SelectedItems[0].SubItems[2].Text;
                this.textBoxJobTitle.Text = listViewEmployee.SelectedItems[0].SubItems[3].Text;
                this.textBoxUserType.Text = listViewEmployee.SelectedItems[0].SubItems[4].Text;
                this.textBoxPassword.Text = listViewEmployee.SelectedItems[0].SubItems[5].Text;
                this.textBoxEmail.Text = listViewEmployee.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)  //ok
        {
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(textBoxEmployeeId.Text);
            emp.FirstName = textBoxFirstName.Text;
            emp.LastName = textBoxLastName.Text;
            emp.JobTitle = textBoxJobTitle.Text;
            emp.UserType = textBoxUserType.Text;
            emp.Password = textBoxPassword.Text;
            emp.Email = textBoxEmail.Text;

            emp.DeleteEmployee(emp.EmployeeId);
            emp.SaveEmployee(emp);

            MessageBox.Show("Employee has been modified.");
        }

        private void buttonSearch_Click(object sender, EventArgs e) //ok
        {
            int searchEmpId = Convert.ToInt32(textBoxSearchId.Text);
            Employee emp = new Employee();
            emp = emp.SearchEmployeeById(searchEmpId);
            if (emp != null)
            {
                textBoxEmployeeId.Text = (emp.EmployeeId).ToString();
                textBoxFirstName.Text = emp.FirstName;
                textBoxLastName.Text = emp.LastName;
                textBoxJobTitle.Text = emp.JobTitle;
                textBoxUserType.Text = emp.UserType;
                textBoxPassword.Text = emp.Password;
                textBoxEmail.Text = emp.Email;
                textBoxSearchId.Clear();
            }
            else
            {
                MessageBox.Show("Employee not found!");
                textBoxSearchId.Clear();
            }
        }

        private void textBoxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter characters only");
            }
        }

        private void textBoxSearchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;
                MessageBox.Show("Enter digits only");
            }
        }
    }
}

