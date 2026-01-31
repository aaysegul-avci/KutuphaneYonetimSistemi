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
    public partial class StaffDailyReportForm : Form
    {

        private BorrowRepository _repo;
        public StaffDailyReportForm()
        {
            InitializeComponent();
            _repo = new BorrowRepository(SessionManager.ConnectionString);
        }

        private void StaffDailyReportForm_Load(object sender, EventArgs e)
        {
            var todayBorrows = _repo.GetTodayApprovedBorrows();
            dgvTodayBorrows.DataSource = todayBorrows;

            lblTodayBorrowCount.Text = todayBorrows.Count.ToString();

            dgvReturns.DataSource = _repo.GetTodayReturns();
            dgvLate.DataSource = _repo.GetLateBorrows();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblTodayBorrowCount_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
