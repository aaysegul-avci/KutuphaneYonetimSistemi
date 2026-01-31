using Odev12.Repository;
using Odev12.Util;
using System;
using System.Windows.Forms;

namespace Odev12.UI;
public partial class StudentBorrowListForm : Form
{
    private BorrowRepository _borrowRepository;

    public StudentBorrowListForm()
    {
        InitializeComponent();
        _borrowRepository = new BorrowRepository(Database.connectionString);
    }

    private void StudentBorrowListForm_Load(object sender, EventArgs e)
    {
        dgvBorrows.DataSource =
            _borrowRepository.GetBorrowsByUser(SessionManager.UserId);
    }
}
