using Odev12.Util;
using System.Windows.Forms;

namespace Odev12.UI
{
    public partial class AdminForms : Form
    {
        public AdminForms()
        {
            InitializeComponent();
        }

        private void AdminForms_Load(object sender, EventArgs e)
        {
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            new UserListForm().ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            new AdminReportForm().ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            new AdminBookListForm().ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

//Adm!n_2025#Secure$Lib
//admin3@library.com