using Odev12.Repository;
using Odev12.DataAccess;
using Odev12.Models;
using Odev12.Strategy;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Odev12.UI
{
    public partial class BookListForm : Form
    {
        private BookRepository _bookRepository;
        private List<Book> _allBooks;

        public BookListForm()
        {
            InitializeComponent();

            string connectionString = Database.connectionString;

            _bookRepository = new BookRepository(connectionString);
        }

        private void BookListForm_Load(object sender, EventArgs e)
        {
            LoadSearchTypes();
            LoadBooks();
            AddDetailsButtonColumn();

            dgvBooks.CellContentClick += dgvBooks_CellContentClick;

            dgvBooks.ReadOnly = true;
            dgvBooks.AllowUserToAddRows = false;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void LoadSearchTypes()
        {
            cmbSearchType.Items.Add("Yazara Göre");
            cmbSearchType.Items.Add("Kategoriye Göre");
            cmbSearchType.Items.Add("Yayın Yılına Göre");

            cmbSearchType.SelectedIndex = 0;
        }

        private void LoadBooks()
        {
            _allBooks = _bookRepository.GetAllBooks();
            dgvBooks.DataSource = _allBooks;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                dgvBooks.DataSource = _allBooks;
                return;
            }

            IBookFilterStrategy strategy = GetSelectedStrategy();

            if (strategy == null)
                return;

            var filteredBooks = strategy.Filter(_allBooks, searchText);
            dgvBooks.DataSource = filteredBooks;
        }

        private IBookFilterStrategy GetSelectedStrategy()
        {
            switch (cmbSearchType.SelectedItem.ToString())
            {
                case "Yazara Göre":
                    return new FilterByAuthor();

                case "Kategoriye Göre":
                    return new FilterByCategory();

                case "Yayın Yılına Göre":
                    return new FilterByPublishYear();

                default:
                    return null;
            }
        }

        private void AddDetailsButtonColumn()
        {
            if (dgvBooks.Columns["Details"] != null)
                return;

            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.Name = "Details";
            btnColumn.HeaderText = "Details";
            btnColumn.Text = "Details";
            btnColumn.UseColumnTextForButtonValue = true;
            btnColumn.Width = 80;

            dgvBooks.Columns.Add(btnColumn);
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgvBooks.Columns[e.ColumnIndex].Name == "Details")
            {
                Book selectedBook = (Book)dgvBooks.Rows[e.RowIndex].DataBoundItem;

                BookDetailsForm detailsForm = new BookDetailsForm(selectedBook);
                detailsForm.ShowDialog();
            }
        }


    }
}
