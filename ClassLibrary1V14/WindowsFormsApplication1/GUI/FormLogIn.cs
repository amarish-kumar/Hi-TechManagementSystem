using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1.DAL;
using ClassLibrary1.BLL;
using ClassLibrary1.VALIDATION;
using WindowsFormsApp_EF;

namespace WindowsFormsApplication1.GUI
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(maskedTextBoxEmployeeId.Text) || String.IsNullOrEmpty(textBoxEmployeePassword.Text))
            {
                MessageBox.Show("Please fill Employee ID and Password before loging in.");
            }

            ClassLibrary1.BLL.Employee emp = new ClassLibrary1.BLL.Employee();
            //Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(maskedTextBoxEmployeeId.Text);
            emp.Password = textBoxEmployeePassword.Text;

            //int tempId = 1111111;
            //if (emp.EmployeeId == tempId)
            //{
            //    if (emp.Password_Authentication(emp.EmployeeId) == emp.Password)
            //    {
            //        FormEmployeeMaintenance form = new FormEmployeeMaintenance();
            //        form.ShowDialog();
            //        this.Hide();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Authentication error. Please try again.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("User don't have access to this operation.");
            //}

            if (Validator.ValidatePassword(emp.EmployeeId, emp.Password) && emp.EmployeeId == 1111111) //MIS MANAGER
            {
                FormEmployeeMaintenance form = new FormEmployeeMaintenance();
                form.ShowDialog();
                this.Hide();
            }
            else if (Validator.ValidatePassword(emp.EmployeeId, emp.Password) && emp.EmployeeId == 1111112) //Sales Manager
            {
                FormClientMaintenance form2 = new FormClientMaintenance();
                form2.ShowDialog();
                this.Hide();
            }
            else if (Validator.ValidatePassword(emp.EmployeeId, emp.Password) && emp.EmployeeId == 1111113) //Inventory Controller
            {
                FormProductMaintenance form3 = new FormProductMaintenance();
                form3.ShowDialog();
                this.Hide();
            }
            else if (Validator.ValidatePassword(emp.EmployeeId, emp.Password) && emp.EmployeeId == 1111114) //Clerk Mary Brown
            {
                FormOrderMaintenance form4 = new FormOrderMaintenance();
                form4.ShowDialog();
                this.Hide();
            }
            else if (Validator.ValidatePassword(emp.EmployeeId, emp.Password) && emp.EmployeeId == 1111115) //Clerk Jennifer Bouchard
            {
                FormOrderMaintenance form4 = new FormOrderMaintenance();
                form4.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Authentication error. Please try again.");
            }



        }

        private void textBoxEmployeePassword_TextChanged(object sender, EventArgs e)
        {
            textBoxEmployeePassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UtilityDB.ConnectDB().State.ToString(), "Database Connected");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FormPasswordChange form5 = new FormPasswordChange();
            form5.ShowDialog();
            this.Hide();
        }
    }
}
