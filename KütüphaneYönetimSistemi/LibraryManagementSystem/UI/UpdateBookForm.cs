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
    public partial class UpdateBookForm : Form
    {
        private Book _book;
        private BookRepository _repo;

        public UpdateBookForm(Book book)
        {
            InitializeComponent();
            _book = book;
            _repo = new BookRepository(SessionManager.ConnectionString);
        }

        private void UpdateBookForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = _book.Title;
            txtAuthor.Text = _book.Author;
            txtYear.Text = _book.PublishYear.ToString();
            txtCategory.Text = _book.Category;
            txtSummary.Text = _book.Summary;
            txtShelf.Text = _book.Shelf;
            txtStock.Text = _book.Stock.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _book.Title = txtTitle.Text;
            _book.Author = txtAuthor.Text;
            _book.PublishYear = int.Parse(txtYear.Text);
            _book.Category = txtCategory.Text;
            _book.Summary = txtSummary.Text;
            _book.Shelf = txtShelf.Text;
            _book.Stock = int.Parse(txtStock.Text);

            _repo.Update(_book);
            MessageBox.Show("Kitap güncellendi");
            Close();
        }
    }

}
