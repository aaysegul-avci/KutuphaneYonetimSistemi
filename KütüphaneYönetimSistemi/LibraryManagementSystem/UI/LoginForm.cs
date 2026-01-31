using Odev12.Repository;
using Odev12.UI;
using Odev12.Util;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Odev12.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("E-posta ve şifre boş bırakılamaz.");
                return;
            }

            string hashedPassword = PasswordHelper.HashPassword(txtPassword.Text);

            string sql = @"SELECT Id, FullName, Role 
                           FROM Users 
                           WHERE Email=@email AND PasswordHash=@password";

            SqlCommand cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password", hashedPassword);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                SessionManager.UserId = reader.GetInt32(0);
                SessionManager.FullName = reader.GetString(1);
                SessionManager.Role = reader.GetString(2);

                reader.Close();
                OpenDashboard();
            }
            else
            {
                reader.Close();
                MessageBox.Show("E-posta veya şifre hatalı.");
            }
        }

        private void OpenDashboard()
        {
            this.Hide();

            switch (SessionManager.Role)
            {
                case "Admin":
                    new AdminForms().Show();
                    break;
                case "Staff":
                    new StaffForms().Show();
                    break;
                case "Student":
                    new StudentForms().Show();
                    break;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            new RegisterForm().ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
