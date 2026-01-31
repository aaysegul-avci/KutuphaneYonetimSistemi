using Odev12.Model;
using Odev12.Repository;
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
    public partial class BookReturnForm : Form
    {
        private BorrowRepository _repo;

        public BookReturnForm()
        {
            InitializeComponent();
            _repo = new BorrowRepository(SessionManager.ConnectionString);
        }

        private void BookReturnForm_Load(object sender, EventArgs e)
        {
            LoadBorrows();
        }

        private void LoadBorrows()
        {
            dgvBorrows.DataSource =
                _repo.GetBorrowsByUser(SessionManager.UserId);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBorrows.SelectedRows.Count == 0)
                return;

            var borrow = (Borrow)dgvBorrows.SelectedRows[0].DataBoundItem;

            if (borrow.State != BorrowStates.Delivered)
            {
                MessageBox.Show("Sadece teslim edilmiş kitaplar iade edilebilir.");
                return;
            }

            _repo.ReturnBorrow(borrow.Id, borrow.BookId);

            MessageBox.Show("Kitap başarıyla iade edildi.");
            LoadBorrows();
        }

    }
}
