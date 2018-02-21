using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ClassLibrary_Disconnected_Mode.DAL;
using ClassLibrary_Disconnected_Mode.BLL;

namespace WindowsFormsApplication1
{
    public partial class FormClientMaintenance : Form
    {
        private DataSet dsClient = new DataSet("HiTech");
        private DataTable dtClient = new DataTable("Clients");
        private SqlDataAdapter sqlDa = new SqlDataAdapter();
        private SqlCommandBuilder sqlCmdClient;

        public FormClientMaintenance()
        {
            InitializeComponent();
        }

        private void ClientMaintenance_Load(object sender, EventArgs e)
        {
            dsClient.Tables.Add(dtClient);
            dsClient = UtilityDB.GetDataSetClients(dsClient, dtClient);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Client aClient = new Client();
            aClient.ClientName = textBoxClientName.Text;
            aClient.StreetNumber = Convert.ToInt32(textBoxStreetNumber.Text);
            aClient.StreetName = textBoxStreetName.Text;
            aClient.City = textBoxCity.Text;
            aClient.PostalCode = textBoxPostalCode.Text;
            aClient.Province = textBoxProvince.Text;
            aClient.Phone = maskedTextBoxPhone.Text;
            aClient.CreditLimit = float.Parse(textBoxCreditLimit.Text);          

                dtClient.Rows.Add(null, aClient.ClientName, aClient.StreetNumber, aClient.StreetName, aClient.City, aClient.PostalCode, aClient.Province, aClient.Phone, aClient.CreditLimit);

            MessageBox.Show("The client was saved.");

            //e se não salvar?  

        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listViewClient.Items.Clear();
            dsClient = UtilityDB.GetDataSetClients(dsClient, dtClient);

            foreach (DataRow row in dtClient.Rows)
            {
                ListViewItem item = new ListViewItem(row["ClientId"].ToString());
                item.SubItems.Add(row["ClientName"].ToString());
                item.SubItems.Add(row["Phone"].ToString());
                item.SubItems.Add(row["CreditLimit"].ToString());
                item.SubItems.Add(row["StreetNumber"].ToString());
                item.SubItems.Add(row["StreetName"].ToString());
                item.SubItems.Add(row["City"].ToString());
                item.SubItems.Add(row["PostalCode"].ToString());
                item.SubItems.Add(row["Province"].ToString());
                
                listViewClient.Items.Add(item);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e) 
        {
            int searchId = Convert.ToInt32(textBoxClientId.Text);
            DataRow row = dtClient.Rows.Find(searchId);
            if (row != null)
            {
                row["ClientName"] = textBoxClientName.Text;
                row["Phone"] = maskedTextBoxPhone.Text;
                row["CreditLimit"] = float.Parse(textBoxCreditLimit.Text);
                row["StreetNumber"] = Convert.ToInt32 (textBoxCreditLimit.Text);
                row["StreetName"] = textBoxStreetName.Text;
                row["City"] = textBoxCity.Text;
                row["PostalCode"] = textBoxPostalCode.Text;
                row["Province"] = textBoxProvince.Text;
                MessageBox.Show("In the DataSet obj, Student Info modified");
            }

            if (dsClient.HasChanges()) //DB
            {
                sqlDa = UtilityDB.GetDataAdapterClients();
                sqlCmdClient = new SqlCommandBuilder(sqlDa);
                sqlDa.Update(dsClient.Tables["Clients"]);
                MessageBox.Show("Database updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e) 
        {
            int deleteId = Convert.ToInt32(textBoxClientId.Text); //delete local
            DataRow dr = dtClient.Rows.Find(deleteId);
            if (dr != null)
            {
                dr.Delete();
                MessageBox.Show("The Client was deleted.");
            }

            if (dsClient.HasChanges()) //Update DB
            {
                sqlDa = UtilityDB.GetDataAdapterClients();
                sqlCmdClient = new SqlCommandBuilder(sqlDa);
                sqlDa.Update(dsClient.Tables["Clients"]);
                MessageBox.Show("Database updated successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void listViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClient.SelectedIndices.Count > 0)
            {
                this.textBoxClientId.Text = listViewClient.SelectedItems[0].SubItems[0].Text;
                this.textBoxClientName.Text = listViewClient.SelectedItems[0].SubItems[1].Text;
                this.maskedTextBoxPhone.Text = listViewClient.SelectedItems[0].SubItems[2].Text;
                this.textBoxCreditLimit.Text = listViewClient.SelectedItems[0].SubItems[3].Text;
                this.textBoxStreetNumber.Text = listViewClient.SelectedItems[0].SubItems[4].Text;
                this.textBoxStreetName.Text = listViewClient.SelectedItems[0].SubItems[5].Text;
                this.textBoxCity.Text = listViewClient.SelectedItems[0].SubItems[6].Text;
                this.textBoxPostalCode.Text = listViewClient.SelectedItems[0].SubItems[7].Text;
                this.textBoxProvince.Text = listViewClient.SelectedItems[0].SubItems[8].Text;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int searchId = Convert.ToInt32(textBoxSearchId.Text);
            DataRow row = dtClient.Rows.Find(searchId);
            if (row != null)
            {
                textBoxClientId.Text = row["ClientId"].ToString();
                textBoxClientName.Text = row["ClientName"].ToString();
                maskedTextBoxPhone.Text = row["Phone"].ToString();
                textBoxCreditLimit.Text = row["CreditLimit"].ToString();
                textBoxStreetNumber.Text = row["StreetNumber"].ToString();
                textBoxStreetName.Text = row["StreetName"].ToString();
                textBoxCity.Text = row["City"].ToString();
                textBoxPostalCode.Text = row["PostalCode"].ToString();
                textBoxProvince.Text = row["Province"].ToString();
            }
            else
            {
                MessageBox.Show("Client Not Found!", "Invalid Client ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxSearchId.Clear();
                textBoxSearchId.Focus();
            }
        }

        private void textBoxClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter characters only");
            }
        }

        private void textBoxCreditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char c = e.KeyChar;
            //if (!Char.IsDigit(c) && c !=8 )
            //{
            //    e.Handled = true;
            //    MessageBox.Show("Enter digits only");
            //}
        }

        private void textBoxStreetNumber_KeyPress(object sender, KeyPressEventArgs e)
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
