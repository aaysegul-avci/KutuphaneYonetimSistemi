using Odev12.DataAccess;
using Odev12.Models;
using Odev12.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev12.UI
{
    public partial class AddBookForm : Form
    {
        private BookRepository _repo;

        public AddBookForm()
        {
            InitializeComponent();
            _repo = new BookRepository(SessionManager.ConnectionString);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new()
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                PublishYear = int.Parse(txtYear.Text),
                Category = txtCategory.Text,
                Summary = txtSummary.Text,
                Shelf = txtShelf.Text,
                Stock = int.Parse(txtStock.Text)
            };

            _repo.Add(book);
            MessageBox.Show("Kitap eklendi");
            Close();
        }

        private void AddBookForm_Load(object Sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
