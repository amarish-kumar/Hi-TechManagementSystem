using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApplication1.EntityFramework;

namespace WindowsFormsApplication1.GUI
{
    public partial class FormOrderSoftware : Form
    {
        HiTechEntities dbEntities = new HiTechEntities();

        public FormOrderSoftware()
        {
            InitializeComponent();         
        }

        private void FormOrderSoftware_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hiTechDataSet.Softwares' table. You can move, or remove it, as needed.
            this.softwaresTableAdapter.Fill(this.hiTechDataSet.Softwares);
            // TODO: This line of code loads data into the 'hiTechDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.hiTechDataSet.Orders);
            // TODO: This line of code loads data into the 'hiTechDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hiTechDataSet.Clients);

            comboBoxEmployeeId.Items.Add(1111114);
            comboBoxEmployeeId.Items.Add(1111115);

            comboBoxMadeBy.Items.Add("Email");
            comboBoxMadeBy.Items.Add("Phone");
            comboBoxMadeBy.Items.Add("Fax");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.EmployeeId = Convert.ToInt32(comboBoxEmployeeId.Text);
            order.ClientId = Convert.ToInt32(comboBoxClientID.Text);
            order.MadeBy = comboBoxMadeBy.Text;
            order.OrderDate = Convert.ToDateTime(maskedTextBoxOrderDate.Text);
            //order.ShippingDate = Convert.ToDateTime(maskedTextBoxShippingDate.Text);

            DateTime newDate = order.OrderDate.AddDays(1);
            order.ShippingDate = newDate;

            dbEntities.Orders.Add(order);
            dbEntities.SaveChanges();

            MessageBox.Show("The order was saved");
        }

        private void listViewOrder_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewOrder.SelectedIndices.Count > 0)
            {
                this.textBoxOrderID.Text = listViewOrder.SelectedItems[0].SubItems[0].Text;
                comboBoxEmployeeId.Text = listViewOrder.SelectedItems[0].SubItems[1].Text;
                comboBoxClientID.Text = listViewOrder.SelectedItems[0].SubItems[2].Text;
                comboBoxMadeBy.Text = listViewOrder.SelectedItems[0].SubItems[3].Text;
                maskedTextBoxOrderDate.Text= listViewOrder.SelectedItems[0].SubItems[4].Text;
                maskedTextBoxShippingDate.Text = listViewOrder.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void buttonListOrder_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            foreach (var current in dbEntities.Orders)
            {
                ListViewItem item = new ListViewItem(current.OrderId.ToString());
                item.SubItems.Add(current.EmployeeId.ToString());
                item.SubItems.Add(current.ClientId.ToString());
                item.SubItems.Add(current.MadeBy);
                item.SubItems.Add(current.OrderDate.ToShortDateString());
                item.SubItems.Add(current.ShippingDate.ToShortDateString());
                listViewOrder.Items.Add(item);
            }
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            Order order = dbEntities.Orders.Find(Convert.ToInt32(textBoxOrderID.Text));
            order.EmployeeId = Convert.ToInt32(comboBoxEmployeeId.Text);
            order.ClientId = Convert.ToInt32(comboBoxClientID.Text);
            order.MadeBy = comboBoxMadeBy.Text;
            order.OrderDate = Convert.ToDateTime(maskedTextBoxOrderDate.Text);
            //order.ShippingDate = Convert.ToDateTime(maskedTextBoxShippingDate.Text);
            order.ShippingDate = order.OrderDate.AddDays(1);
            dbEntities.SaveChanges();

            MessageBox.Show("The order was modified");
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            Order delOrder = dbEntities.Orders.Find(Convert.ToInt32(textBoxOrderID.Text));
            dbEntities.Orders.Remove(delOrder);
            dbEntities.SaveChanges();
            MessageBox.Show("The order was deleted.");
        }

        private void buttonSearchOrder_Click(object sender, EventArgs e)
        {
            Order searchOrder = dbEntities.Orders.Find(Convert.ToInt32(maskedTextBoxSearchOrderID.Text));
            if (searchOrder != null)
            {
                textBoxOrderID.Text = searchOrder.OrderId.ToString();
                comboBoxEmployeeId.Text = searchOrder.EmployeeId.ToString();
                comboBoxClientID.Text = searchOrder.ClientId.ToString();
                comboBoxMadeBy.Text = searchOrder.MadeBy;
                maskedTextBoxOrderDate.Text = searchOrder.OrderDate.ToShortDateString();
                maskedTextBoxShippingDate.Text = searchOrder.ShippingDate.ToShortDateString();
            }
        }


/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void buttonReturn_Click(object sender, EventArgs e)
        {
            FormOrderMaintenance form = new FormOrderMaintenance();
            form.ShowDialog();
            this.Hide();
        }

        private void buttonSaveOL_Click(object sender, EventArgs e)
        {
            OrderLineSoftware olSoftware = new OrderLineSoftware();
            olSoftware.OrderId = Convert.ToInt32(comboBoxOrderID.Text);
            olSoftware.SoftwareId = Convert.ToInt32(comboBoxSoftwareID.Text);
            olSoftware.OlQuantity = Convert.ToInt32(textBoxOrderLineQuantity.Text);
            dbEntities.OrderLineSoftwares.Add(olSoftware);
            dbEntities.SaveChanges();

            MessageBox.Show("The order line was saved");
        }

        private void buttonListOL_Click(object sender, EventArgs e)
        {
            listViewOrderLine.Items.Clear();
            foreach (var ol in dbEntities.OrderLineSoftwares)
            {
                ListViewItem item = new ListViewItem(ol.OlSoftwareId.ToString());
                item.SubItems.Add(ol.OrderId.ToString());
                item.SubItems.Add(ol.SoftwareId.ToString());
                item.SubItems.Add(ol.OlQuantity.ToString());
                listViewOrderLine.Items.Add(item);
            }
        }

        private void listViewOrderLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrderLine.SelectedIndices.Count >0)
            {
                textBoxOLID.Text = listViewOrderLine.SelectedItems[0].SubItems[0].Text;
                comboBoxOrderID.Text = listViewOrderLine.SelectedItems[0].SubItems[1].Text;
                comboBoxSoftwareID.Text = listViewOrderLine.SelectedItems[0].SubItems[2].Text;
                textBoxOrderLineQuantity.Text = listViewOrderLine.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void buttonUpdateOL_Click(object sender, EventArgs e)
        {
            OrderLineSoftware ol = dbEntities.OrderLineSoftwares.Find(Convert.ToInt32(textBoxOLID.Text));
            ol.OrderId = Convert.ToInt32(comboBoxOrderID.Text);
            ol.SoftwareId = Convert.ToInt32(comboBoxSoftwareID.Text);
            ol.OlQuantity = Convert.ToInt32(textBoxOrderLineQuantity.Text);
            dbEntities.SaveChanges();

            MessageBox.Show("The order line was modified");       
        }

        private void buttonDeleteOL_Click(object sender, EventArgs e)
        {
            OrderLineSoftware ol = dbEntities.OrderLineSoftwares.Find(Convert.ToInt32(textBoxOLID.Text));
            dbEntities.OrderLineSoftwares.Remove(ol);
            dbEntities.SaveChanges();
            MessageBox.Show("The order line was deleted.");            
        }

        private void buttonSearchOL_Click(object sender, EventArgs e)
        {
            OrderLineSoftware ol = dbEntities.OrderLineSoftwares.Find(Convert.ToInt32(maskedTextBoxSearchOLID.Text));
            if (ol != null)
            {
                textBoxOLID.Text = ol.OlSoftwareId.ToString();
                comboBoxOrderID.Text = ol.OrderId.ToString();
                comboBoxSoftwareID.Text = ol.SoftwareId.ToString();
                textBoxOrderLineQuantity.Text = ol.OlQuantity.ToString();
            }
        }

        private void textBoxOrderLineQuantity_KeyPress(object sender, KeyPressEventArgs e)
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
