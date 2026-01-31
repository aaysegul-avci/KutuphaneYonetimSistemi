using Odev12.Util;
using System.Windows.Forms;

namespace Odev12.UI
{
    public partial class StudentForms : Form
    {
        public StudentForms()
        {
            InitializeComponent();
            this.Text = "Öğrenci Panel";
            MessageBox.Show("Hoş geldiniz Öğrenci: " + SessionManager.FullName);
        }

        private void StudentForms_Load(object Sender, EventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new BookListForm().ShowDialog();
        }
        private void btnReturns_Click(object sender, EventArgs e)
        {
            new BookReturnForm().ShowDialog();
        }
    }
}
