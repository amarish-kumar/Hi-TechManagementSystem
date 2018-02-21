using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.GUI
{
    public partial class FormOrderMaintenance : Form
    {
        public FormOrderMaintenance()
        {
            InitializeComponent();
        }

        private void buttonOrderSoftware_Click(object sender, EventArgs e)
        {
            FormOrderSoftware soft = new FormOrderSoftware();
            soft.ShowDialog();
            this.Hide();
        }

        private void buttonOrderBook_Click(object sender, EventArgs e)
        {
            FormOrderBook book = new FormOrderBook();
            book.ShowDialog();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
