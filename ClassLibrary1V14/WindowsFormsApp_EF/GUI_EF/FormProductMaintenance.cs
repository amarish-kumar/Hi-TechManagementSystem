using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                listViewBook.Items.Add(item);
            }
        }

        private void ProductMaintenance_Load(object sender, EventArgs e)
        {

        }
    }
}
