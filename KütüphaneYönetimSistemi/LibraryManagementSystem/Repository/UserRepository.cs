using Microsoft.Data.SqlClient;
using Odev12.Model;
using System.Collections.Generic;

namespace Odev12.Repository
{
    public class UserRepository
    {
        //For listing users
        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            string sql = "SELECT Id, FullName, Email, SchoolNumber, Phone, Role FROM Users";

            SqlCommand cmd = new SqlCommand(sql, Database.GetConnection());
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    Id = reader.GetInt32(0),
                    FullName = reader.GetString(1),
                    Email = reader.GetString(2),
                    SchoolNumber = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Phone = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    Role = reader.GetString(5)
                });
            }

            reader.Close();
            return users;
        }

        //For deleting users
        public void DeleteUser(int userId)
        {
            string sql = "DELETE FROM Users WHERE Id=@id AND Role <> 'Admin'";
            SqlCommand cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@id", userId);
            cmd.ExecuteNonQuery();
        }

        //For changing role
        public void ToggleUserRole(int userId)
        {
            string sql = @"
                UPDATE Users
                SET Role = CASE 
                    WHEN Role = 'Student' THEN 'Staff'
                    WHEN Role = 'Staff' THEN 'Student'
                    ELSE Role
                END
                WHERE Id=@id AND Role <> 'Admin'";

            SqlCommand cmd = new SqlCommand(sql, Database.GetConnection());
            cmd.Parameters.AddWithValue("@id", userId);
            cmd.ExecuteNonQuery();
        }
    }
}
