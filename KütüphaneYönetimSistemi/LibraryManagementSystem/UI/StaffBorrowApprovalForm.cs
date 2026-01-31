
using Odev12.Model;
using Odev12.Repository;
using Odev12.Util;
using System;
using System.Windows.Forms;

namespace Odev12.UI;
public partial class StaffBorrowApprovalForm : Form
{
    BorrowRepository _borrowRepository;

    public StaffBorrowApprovalForm()
    {
        InitializeComponent();
        _borrowRepository = new BorrowRepository(Database.connectionString);
    }

    private void StaffBorrowApprovalForm_Load(object sender, EventArgs e)
    {
        LoadBorrows();
    }

    private void LoadBorrows()
    {
        dgvBorrows.DataSource = _borrowRepository.GetPendingBorrows();
    }

    private void btnApprove_Click(object sender, EventArgs e)
    {
        if (dgvBorrows.SelectedRows.Count == 0)
            return;

        int borrowId =
            ((Borrow)dgvBorrows.SelectedRows[0].DataBoundItem).Id;

        _borrowRepository.ApproveBorrow(borrowId);

        MessageBox.Show("Talep onaylandı.");
        LoadBorrows();
    }
}
