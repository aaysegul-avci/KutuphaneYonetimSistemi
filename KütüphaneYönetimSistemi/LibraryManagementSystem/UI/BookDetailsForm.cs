using Odev12.Model;
using Odev12.Models;
using Odev12.Repository;
using Odev12.Util;
using System.Windows.Forms;
    
namespace Odev12.UI
    {
        public partial class BookDetailsForm : Form
        {
            private Book _book;

            public BookDetailsForm(Book book)
            {
                InitializeComponent();
                _book = book;
                LoadBookDetails();
            }

            private void LoadBookDetails()
            {
                lblTitle.Text = _book.Title;
                lblAuthor.Text = _book.Author;
                lblYear.Text = _book.PublishYear.ToString();
                lblCategory.Text = _book.Category;
                lblShelf.Text = _book.Shelf;
                lblStock.Text = _book.Stock.ToString();
                txtSummary.Text = _book.Summary;
            }

        private void BookDetailsForm_Load(object Sender, EventArgs e) { }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (_book.Stock <= 0)
            {
                MessageBox.Show("Bu kitap şu anda ödünç verilemez. Stokta yok.");
                return;
            }

            BorrowRepository borrowRepo =
                new BorrowRepository(Database.connectionString);

            borrowRepo.CreateBorrow(SessionManager.UserId, _book.Id);

            MessageBox.Show("Ödünç alma talebi oluşturuldu. (Beklemede)");
            this.Close();
        }

    }
}
        
