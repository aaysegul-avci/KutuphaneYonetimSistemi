using Odev12.Repository;
using Odev12.Util;
using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace Odev12.UI
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object Sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            string sql = @"INSERT INTO Users 
                           (FullName, Email, PasswordHash, SchoolNumber, Phone, Role)
                           VALUES (@fullName, @email, @password, @school, @phone, 'Student')";

            SqlCommand cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@fullName", txtFullName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@password",
                PasswordHelper.HashPassword(txtPassword.Text));
            cmd.Parameters.AddWithValue("@school", txtSchoolNumber.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı. Giriş yapabilirsiniz.");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Bu e-posta zaten kayıtlı.");
            }
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Ad Soyad boş bırakılamaz.");
                return false;
            }

            if (!IsStrongPassword(txtPassword.Text))
            {
                MessageBox.Show("Parola en az 8 karakter, büyük harf, küçük harf ve rakam içermelidir.");
                return false;
            }

            return true;
        }

        private bool IsStrongPassword(string password)
        {
            return password.Length >= 8 &&
                   password.Any(char.IsUpper) &&
                   password.Any(char.IsLower) &&
                   password.Any(char.IsDigit);
        }
    }
}
