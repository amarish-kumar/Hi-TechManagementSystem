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

namespace WindowsFormsApp_EF
{
    public partial class FormProductMaintenance : Form
    {
        HiTechEntities dbEntities = new HiTechEntities();


        public FormProductMaintenance()
        {
            InitializeComponent();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listViewBook.Items.Clear();

            foreach (var current in dbEntities.Books)
            {
                ListViewItem item = new ListViewItem(current.BookId.ToString());
                item.SubItems.Add(current.Title);
                item.SubItems.Add(current.Isbn);
                item.SubItems.Add(current.UnitPrice.ToString());
                item.SubItems.Add(current.YearPublished.ToString());
                item.SubItems.Add(current.Qoh.ToString());
                item.SubItems.Add(current.CategoryId.ToString());
                item.SubItems.Add(current.PublisherId.ToString());

                item.SubItems.Add(current.AuthorId.ToString());
                listViewBook.Items.Add(item);
            }
        }

        private void ProductMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hiTechDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.hiTechDataSet.Authors);
            // TODO: This line of code loads data into the 'hiTechDataSet.Publishers' table. You can move, or remove it, as needed.
            this.publishersTableAdapter.Fill(this.hiTechDataSet.Publishers);
            // TODO: This line of code loads data into the 'hiTechDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.hiTechDataSet.Categories);
            // TODO: This line of code loads data into the 'hiTechDataSet.Books' table. You can move, or remove it, as needed.
            //this.booksTableAdapter.Fill(this.hiTechDataSet.Books);

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Isbn = textBoxISBN.Text;
            book.Title = textBoxTitle.Text;
            book.UnitPrice = Math.Round(float.Parse(textBoxUnitPrice.Text),2);
            book.YearPublished = Convert.ToInt32( textBoxYearPublished.Text);
            book.Qoh = Convert.ToInt32(textBoxQOH.Text);
            book.CategoryId = Convert.ToInt32(comboBoxCategoryId.Text);
            book.PublisherId = Convert.ToInt32(comboBoxPublisherId.Text);

            book.AuthorId = Convert.ToInt32(comboBoxAuthorId.Text);

            dbEntities.Books.Add(book);
            dbEntities.SaveChanges();

            MessageBox.Show("The book was saved");

            ////Adding in AuthorBooks
            //AuthorBook ab = new AuthorBook();
            //ab.BookId = book.BookId;
            //ab.AuthorId = Convert.ToInt32(comboBoxAuthorId.Text);
            //dbEntities.AuthorBooks.Add(ab);
            //dbEntities.SaveChanges();           

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Book book = dbEntities.Books.Find(Convert.ToInt32(textBoxBookId.Text));
            book.Isbn = textBoxISBN.Text;
            book.Title = textBoxTitle.Text;
            book.UnitPrice = Math.Round(float.Parse( textBoxUnitPrice.Text),2);
            book.YearPublished = Convert.ToInt32(textBoxYearPublished.Text);
            book.Qoh = Convert.ToInt32(textBoxQOH.Text);
            book.CategoryId = Convert.ToInt32(comboBoxCategoryId.Text);
            book.PublisherId = Convert.ToInt32(comboBoxPublisherId.Text);

            book.AuthorId = Convert.ToInt32(comboBoxAuthorId.Text);

            dbEntities.SaveChanges();
            MessageBox.Show("The book has been updated.");


            ////Updating in AuthorBooks
            //AuthorBook authorBook = dbEntities.AuthorBooks.Find(Convert.ToInt32(textBoxBookId.Text), Convert.ToInt32(comboBoxAuthorId.Text));
            //authorBook.BookId = Convert.ToInt32(textBoxBookId.Text);
            //authorBook.AuthorId = Convert.ToInt32(comboBoxAuthorId.Text);
            //dbEntities.SaveChanges();
            //MessageBox.Show("AB was saved");

        }

        private void listViewBook_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listViewBook.SelectedIndices.Count > 0)
            {
                this.textBoxBookId.Text = listViewBook.SelectedItems[0].SubItems[0].Text;
                this.textBoxTitle.Text = listViewBook.SelectedItems[0].SubItems[1].Text;
                this.textBoxISBN.Text = listViewBook.SelectedItems[0].SubItems[2].Text;
                this.textBoxUnitPrice.Text = listViewBook.SelectedItems[0].SubItems[3].Text;
                this.textBoxYearPublished.Text = listViewBook.SelectedItems[0].SubItems[4].Text;
                this.textBoxQOH.Text = listViewBook.SelectedItems[0].SubItems[5].Text;
                this.comboBoxCategoryId.Text = listViewBook.SelectedItems[0].SubItems[6].Text;
                this.comboBoxPublisherId.Text = listViewBook.SelectedItems[0].SubItems[7].Text;
                this.comboBoxAuthorId.Text = listViewBook.SelectedItems[0].SubItems[8].Text;
            }        
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Book searchBook = dbEntities.Books.Find(Convert.ToInt32(maskedTextBoxSearchBook.Text));
            if (searchBook != null)
            {
                textBoxBookId.Text = searchBook.BookId.ToString();
                textBoxISBN.Text = searchBook.Isbn;
                textBoxTitle.Text = searchBook.Title;
                textBoxUnitPrice.Text = searchBook.UnitPrice.ToString();
                textBoxYearPublished.Text = searchBook.YearPublished.ToString();
                textBoxQOH.Text = searchBook.Qoh.ToString();
                comboBoxCategoryId.Text = searchBook.CategoryId.ToString();
                comboBoxPublisherId.Text = searchBook.PublisherId.ToString();
                comboBoxAuthorId.Text = searchBook.AuthorId.ToString();
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void buttonExitSoftware_Click(object sender, EventArgs e)
        {
            DialogResult option = MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (option == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonSaveSoftware_Click(object sender, EventArgs e)
        {
            Software aSoftware = new Software();
            aSoftware.SoftwareName = textBoxSoftwareName.Text;
            aSoftware.Company = textBoxCompany.Text;
            aSoftware.CategoryId = Convert.ToInt32(comboBoxCatId.Text);
            aSoftware.Price = Math.Round(float.Parse(textBoxPrice.Text),2);
            aSoftware.Qoh = Convert.ToInt32(textBoxQOHSoftware.Text);
            dbEntities.Softwares.Add(aSoftware);
            dbEntities.SaveChanges();
            MessageBox.Show("The software was saved");
        }

        private void buttonListSoftware_Click(object sender, EventArgs e)
        {
            listViewSoftware.Items.Clear();
            foreach (var current in dbEntities.Softwares)
            {
                ListViewItem item = new ListViewItem(current.SoftwareId.ToString());
                item.SubItems.Add(current.SoftwareName);
                item.SubItems.Add(current.Company);
                item.SubItems.Add(current.CategoryId.ToString());
                item.SubItems.Add(current.Price.ToString());
                item.SubItems.Add(current.Qoh.ToString());

                listViewSoftware.Items.Add(item);
            }          
        }

        private void buttonUpdateSoftware_Click(object sender, EventArgs e)
        {
            Software aSoftware = dbEntities.Softwares.Find(Convert.ToInt32(textBoxSoftwareID.Text));
            aSoftware.SoftwareName = textBoxSoftwareName.Text;
            aSoftware.Company = textBoxCompany.Text;
            aSoftware.CategoryId = Convert.ToInt32(comboBoxCatId.Text);
            aSoftware.Price = Math.Round(float.Parse(textBoxPrice.Text), 2);
            aSoftware.Qoh = Convert.ToInt32(textBoxQOHSoftware.Text);
            dbEntities.SaveChanges();
            MessageBox.Show("The software has been updated.");

        }

        private void listViewSoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSoftware.SelectedIndices.Count >0)
            {
                textBoxSoftwareID.Text = listViewSoftware.SelectedItems[0].SubItems[0].Text;
                textBoxSoftwareName.Text = listViewSoftware.SelectedItems[0].SubItems[1].Text;
                textBoxCompany.Text = listViewSoftware.SelectedItems[0].SubItems[2].Text;
                comboBoxCatId.Text = listViewSoftware.SelectedItems[0].SubItems[3].Text;
                textBoxPrice.Text = listViewSoftware.SelectedItems[0].SubItems[4].Text;
                textBoxQOHSoftware.Text = listViewSoftware.SelectedItems[0].SubItems[5].Text;
            } 
        }

        private void buttonDeleteSoftware_Click(object sender, EventArgs e)
        {
            Software delSoftware = dbEntities.Softwares.Find(Convert.ToInt32(textBoxSoftwareID.Text));
            dbEntities.Softwares.Remove(delSoftware);
            dbEntities.SaveChanges();
            MessageBox.Show("The software was deleted.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Book delBook = dbEntities.Books.Find(Convert.ToInt32(textBoxBookId.Text));
            dbEntities.Books.Remove(delBook);
            dbEntities.SaveChanges();
            MessageBox.Show("The book was deleted.");
        }

        private void buttonSearchSoftware_Click(object sender, EventArgs e)
        {
            Software searchSoftware = dbEntities.Softwares.Find(Convert.ToInt32(maskedTextBoxSearchSoftware.Text));
            if (searchSoftware != null)
            {
                textBoxSoftwareID.Text = searchSoftware.SoftwareId.ToString();
                textBoxSoftwareName.Text = searchSoftware.SoftwareName;
                textBoxCompany.Text = searchSoftware.Company;
                comboBoxCatId.Text = searchSoftware.CategoryId.ToString();
                textBoxPrice.Text = searchSoftware.Price.ToString();
                textBoxQOHSoftware.Text = searchSoftware.Qoh.ToString();
            }
        }

        private void textBoxTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
                base.OnKeyPress(e);
                MessageBox.Show("Enter characters only");
            }
        }

        private void textBoxYearPublished_KeyPress(object sender, KeyPressEventArgs e)
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
