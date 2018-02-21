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

namespace WindowsFormsApplication1.GUI
{
    public partial class FormPasswordChange : Form
    {
        public FormPasswordChange()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {         
            Employee emp = new Employee();
            emp.EmployeeId = Convert.ToInt32(maskedTextBoxEmployeeId.Text);
            emp.Password = textBoxEmployeePassword.Text;
           
                if (emp.ChangePassword(emp))
                {
                    MessageBox.Show("Password modified");
                }
                else
                {
                    MessageBox.Show("Saving problem.");
                }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogIn form = new FormLogIn();
            form.ShowDialog();
            this.Hide();
        }
    }
}
