using Odev12.Model;
using Odev12.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Odev12.UI
{
    public partial class UserListForm : Form
    {
        UserRepository _repo = new UserRepository();

        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object Sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dgvUsers.Columns.Clear();
            dgvUsers.AutoGenerateColumns = false;

            List<User> users = _repo.GetAllUsers();
            dgvUsers.DataSource = users;

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Ad Soyad"
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "E-Posta"
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "SchoolNumber",
                HeaderText = "Number"
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Phone",
                HeaderText = "Phone"
            });

            dgvUsers.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Role",
                HeaderText = "Rol"
            });

            dgvUsers.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Rol",
                Text = "Değiştir",
                UseColumnTextForButtonValue = true
            });

            dgvUsers.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "Sil",
                Text = "Kaldır",
                UseColumnTextForButtonValue = true
            });

            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            User selectedUser = (User)dgvUsers.Rows[e.RowIndex].DataBoundItem;

            if (e.ColumnIndex == 5)
            {
                if (selectedUser.Role == "Admin")
                {
                    MessageBox.Show("Admin rolü değiştirilemez.");
                    return;
                }

                _repo.ToggleUserRole(selectedUser.Id);
                LoadUsers();
            }

            if (e.ColumnIndex == 6)
            {
                if (selectedUser.Role == "Admin")
                {
                    MessageBox.Show("Admin kullanıcı silinemez.");
                    return;
                }

                DialogResult dr = MessageBox.Show(
                    "Kullanıcı silinsin mi?",
                    "Onay",
                    MessageBoxButtons.YesNo);

                if (dr == DialogResult.Yes)
                {
                    _repo.DeleteUser(selectedUser.Id);
                    LoadUsers();
                }
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

    