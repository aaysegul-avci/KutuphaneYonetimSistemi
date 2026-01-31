using Microsoft.Data.SqlClient;
using Odev12.Models;
using System.Collections.Generic;

namespace Odev12.DataAccess
{
    public class BookRepository
    {
        private readonly string _connectionString;

        public BookRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //For listing books
        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Books";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    books.Add(new Book
                    {
                        Id = (int)reader["Id"],
                        Title = reader["Title"].ToString(),
                        Author = reader["Author"].ToString(),
                        PublishYear = (int)reader["PublishYear"],
                        Category = reader["Category"].ToString(),
                        Summary = reader["Summary"].ToString(),
                        Shelf = reader["Shelf"].ToString(),
                        Stock = (int)reader["Stock"]
                    });
                }
            }

            return books;
        }

        //For adding books
        public void Add(Book book)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
                INSERT INTO Books 
                (Title, Author, PublishYear, Category, Summary, Shelf, Stock)
                VALUES (@t,@a,@y,@c,@s,@sh,@st)";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@t", book.Title);
            cmd.Parameters.AddWithValue("@a", book.Author);
            cmd.Parameters.AddWithValue("@y", book.PublishYear);
            cmd.Parameters.AddWithValue("@c", book.Category);
            cmd.Parameters.AddWithValue("@s", book.Summary);
            cmd.Parameters.AddWithValue("@sh", book.Shelf);
            cmd.Parameters.AddWithValue("@st", book.Stock);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        //For updating books
        public void Update(Book book)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
                UPDATE Books SET
                Title=@t, Author=@a, PublishYear=@y,
                Category=@c, Summary=@s, Shelf=@sh, Stock=@st
                WHERE Id=@id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", book.Id);
            cmd.Parameters.AddWithValue("@t", book.Title);
            cmd.Parameters.AddWithValue("@a", book.Author);
            cmd.Parameters.AddWithValue("@y", book.PublishYear);
            cmd.Parameters.AddWithValue("@c", book.Category);
            cmd.Parameters.AddWithValue("@s", book.Summary);
            cmd.Parameters.AddWithValue("@sh", book.Shelf);
            cmd.Parameters.AddWithValue("@st", book.Stock);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        //For deleting books
        public void Delete(int bookId)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = "DELETE FROM Books WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", bookId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

    }
}
