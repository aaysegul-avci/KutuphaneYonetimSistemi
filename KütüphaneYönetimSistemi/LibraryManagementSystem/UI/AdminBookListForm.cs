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
    public partial class AdminBookListForm : Form
    {
        private BookRepository _repo;

        public AdminBookListForm()
        {
            InitializeComponent();
            _repo = new BookRepository(SessionManager.ConnectionString);
        }

        private void AdminBookListForm_Load(object sender, EventArgs e)
        {
            LoadBooks();

            if (dgvBooks.Columns["Update"] == null)
                AddButtons();
        }


        private void LoadBooks()
        {
            dgvBooks.DataSource = _repo.GetAllBooks();
        }

        private void AddButtons()
        {
            DataGridViewButtonColumn updateBtn = new();
            updateBtn.Name = "Update";
            updateBtn.Text = "Update";
            updateBtn.UseColumnTextForButtonValue = true;
            dgvBooks.Columns.Add(updateBtn);

            DataGridViewButtonColumn deleteBtn = new();
            deleteBtn.Name = "Delete";
            deleteBtn.Text = "Delete";
            deleteBtn.UseColumnTextForButtonValue = true;
            dgvBooks.Columns.Add(deleteBtn);
        }


        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var book = (Book)dgvBooks.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == dgvBooks.Columns["Update"].Index)
            {
                new UpdateBookForm(book).ShowDialog();
                LoadBooks();
            }

            else if (e.ColumnIndex == dgvBooks.Columns["Delete"].Index)
            {
                var result = MessageBox.Show(
                    $"'{book.Title}' kitabını silmek istiyor musunuz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        _repo.Delete(book.Id);
                        MessageBox.Show("Kitap silindi.");
                        LoadBooks();
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Bu kitap şu anda ödünçte olduğu için silinemez.",
                            "Hata",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            new AddBookForm().ShowDialog();
            LoadBooks();
        }
    }

}
