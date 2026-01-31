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
    public partial class StaffDeliverForm : Form
    {
        private BorrowRepository _repo;

        public StaffDeliverForm()
        {
            InitializeComponent();
            _repo = new BorrowRepository(SessionManager.ConnectionString);
        }

        private void StaffDeliverForm_Load(object sender, EventArgs e)
        {
            dgvBorrows.DataSource = _repo.GetApprovedBorrows();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            if (dgvBorrows.SelectedRows.Count == 0)
                return;

            var borrow = (Borrow)dgvBorrows.SelectedRows[0].DataBoundItem;

            _repo.DeliverBorrow(borrow.Id);

            MessageBox.Show("Kitap kullanıcıya teslim edildi.");
            dgvBorrows.DataSource = _repo.GetApprovedBorrows();
        }

    }
}
