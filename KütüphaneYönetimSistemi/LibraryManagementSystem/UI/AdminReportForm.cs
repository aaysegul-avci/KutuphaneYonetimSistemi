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
    public partial class AdminReportForm : Form
    {
        private BorrowRepository _repo;

        public AdminReportForm()
        {
            InitializeComponent();
            _repo = new BorrowRepository(SessionManager.ConnectionString);
        }

        private void AdminReportForm_Load(object sender, EventArgs e)
        {
            dgvMostBorrowed.DataSource = _repo.GetMostBorrowedBooks();
            dgvAllBorrows.DataSource = _repo.GetAllBorrowHistory();

            lblDaily.Text = _repo.GetDailyBorrowCount().ToString();
            lblWeekly.Text = _repo.GetWeeklyBorrowCount().ToString();
            lblMonthly.Text = _repo.GetMonthlyBorrowCount().ToString();
        }

        private void lblDaily_Click(object sender, EventArgs e)
        {

        }
    }
}
