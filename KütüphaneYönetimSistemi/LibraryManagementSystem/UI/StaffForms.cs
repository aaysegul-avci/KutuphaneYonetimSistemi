using Odev12.Util;
using System.Windows.Forms;

namespace Odev12.UI
{
    public partial class StaffForms : Form
    {
        public StaffForms()
        {
            InitializeComponent();
            this.Text = "Personel Panel";
            MessageBox.Show("Hoş geldiniz Personel: " + SessionManager.FullName);
        }

        private void StaffForms_Load(object Sender, EventArgs e)
        {

        }

        private void btnApproval_Click(object sender, EventArgs e)
        {
            new StaffBorrowApprovalForm().ShowDialog();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            new StaffDeliverForm().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new StaffDailyReportForm().ShowDialog();
        }
    }
}
