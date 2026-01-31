using Microsoft.Data.SqlClient;
using Odev12.Model;
using Odev12.Util;
using System.Collections.Generic;
using System.Data;

namespace Odev12.Repository
{
    public class BorrowRepository
    {
        private readonly string _connectionString;

        public BorrowRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        //For Borrowing
        public void CreateBorrow(int userId, int bookId)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
                INSERT INTO Borrows (UserId, BookId, State)
                VALUES (@userId, @bookId, 'Beklemede')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userId", userId);
            cmd.Parameters.AddWithValue("@bookId", bookId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        //To see borrowed Books by user
        public List<Borrow> GetBorrowsByUser(int userId)
        {
            List<Borrow> borrows = new();

            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
                SELECT Br.Id, B.Title, Br.State, Br.RequestDate
                FROM Borrows Br
                JOIN Books B ON Br.BookId = B.Id
                WHERE Br.UserId = @userId";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userId", userId);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                borrows.Add(new Borrow
                {
                    Id = (int)reader["Id"],
                    BookTitle = reader["Title"].ToString(),
                    State = reader["State"].ToString(),
                    RequestDate = (DateTime)reader["RequestDate"]
                });
            }

            return borrows;
        }

        //For Stuff Pending Borrows Table
        public List<Borrow> GetPendingBorrows()
        {
            List<Borrow> borrows = new();

            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
                SELECT Br.Id, U.FullName, B.Title, Br.State
                FROM Borrows Br
                JOIN Users U ON Br.UserId = U.Id
                JOIN Books B ON Br.BookId = B.Id
                WHERE Br.State = 'Beklemede'";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                borrows.Add(new Borrow
                {
                    Id = (int)reader["Id"],
                    BookTitle = reader["Title"].ToString(),
                    State = reader["State"].ToString()
                });
            }

            return borrows;
        }

        //For Stuff Aprrove
        public void ApproveBorrow(int borrowId)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
                UPDATE Borrows 
                SET State = 'Onaylandı', ApprovalDate = GETDATE()
                WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", borrowId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        //For Stuff Delivery
        public void DeliverBorrow(int borrowId)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
                UPDATE Borrows 
                SET State = @state
                WHERE Id = @id";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@state", BorrowStates.Delivered);
            cmd.Parameters.AddWithValue("@id", borrowId);

            conn.Open();
            cmd.ExecuteNonQuery();
        }

        //For User Return
        public void ReturnBorrow(int borrowId, int bookId)
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            conn.Open();

            SqlTransaction tran = conn.BeginTransaction();

            try
            {
                SqlCommand cmd = new SqlCommand(@"
                    UPDATE Borrows 
                    SET State = @state, ReturnDate = GETDATE()
                    WHERE Id = @id", conn, tran);

                cmd.Parameters.AddWithValue("@state", BorrowStates.Returned);
                cmd.Parameters.AddWithValue("@id", borrowId);
                cmd.ExecuteNonQuery();

                SqlCommand stockCmd = new SqlCommand(@"
                    UPDATE Books 
                    SET Stock = Stock + 1
                    WHERE Id = @bookId", conn, tran);

                stockCmd.Parameters.AddWithValue("@bookId", bookId);
                stockCmd.ExecuteNonQuery();

                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                throw;
            }
        }

        //For Stuff Delivery Table
        public List<Borrow> GetApprovedBorrows()
        {
            List<Borrow> list = new();

            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
                SELECT Br.Id, Br.BookId, B.Title, Br.State
                FROM Borrows Br
                JOIN Books B ON Br.BookId = B.Id
                WHERE Br.State = @state";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@state", BorrowStates.Approved);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Borrow
                {
                    Id = (int)reader["Id"],
                    BookId = (int)reader["BookId"],
                    BookTitle = reader["Title"].ToString(),
                    State = reader["State"].ToString()
                });
            }

            return list;
        }


        //Staff Form Report Functions
        public List<Borrow> GetTodayApprovedBorrows()
        {
            List<Borrow> list = new();

            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
        SELECT 
            Br.Id,
            Br.UserId,
            Br.BookId,
            B.Title,
            Br.State,
            Br.RequestDate,
            Br.ApprovalDate
        FROM Borrows Br
        JOIN Books B ON Br.BookId = B.Id
        WHERE CAST(Br.ApprovalDate AS DATE) = CAST(GETDATE() AS DATE)";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Borrow
                {
                    Id = (int)reader["Id"],
                    UserId = (int)reader["UserId"],
                    BookId = (int)reader["BookId"],
                    BookTitle = reader["Title"].ToString(),
                    State = reader["State"].ToString(),
                    RequestDate = (DateTime)reader["RequestDate"],
                    ApprovalDate = reader["ApprovalDate"] == DBNull.Value
                        ? null
                        : (DateTime)reader["ApprovalDate"]
                });
            }

            return list;
        }

        public List<Borrow> GetTodayReturns()
        {
            List<Borrow> list = new();

            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
        SELECT 
            Br.Id,
            Br.UserId,
            Br.BookId,
            B.Title,
            Br.State,
            Br.RequestDate,
            Br.ReturnDate
        FROM Borrows Br
        JOIN Books B ON Br.BookId = B.Id
        WHERE CAST(Br.ReturnDate AS DATE) = CAST(GETDATE() AS DATE)";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new Borrow
                {
                    Id = (int)reader["Id"],
                    UserId = (int)reader["UserId"],
                    BookId = (int)reader["BookId"],
                    BookTitle = reader["Title"].ToString(),
                    State = reader["State"].ToString(),
                    RequestDate = (DateTime)reader["RequestDate"],
                    ReturnDate = reader["ReturnDate"] == DBNull.Value
                        ? null
                        : (DateTime)reader["ReturnDate"]
                });
            }

            return list;
        }

        public List<Borrow> GetLateBorrows()
        {
            List<Borrow> list = new();

            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
        SELECT B.Title, Br.RequestDate
        FROM Borrows Br
        JOIN Books B ON Br.BookId = B.Id
        WHERE Br.State = @state
        AND DATEDIFF(DAY, Br.RequestDate, GETDATE()) > 14";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@state", BorrowStates.Delivered);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Borrow
                {
                    BookTitle = reader["Title"].ToString()
                });
            }

            return list;
        }


        //Admin Form Report Functions
        public DataTable GetMostBorrowedBooks()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
        SELECT B.Title, COUNT(*) AS BorrowCount
        FROM Borrows Br
        JOIN Books B ON Br.BookId = B.Id
        GROUP BY B.Title
        ORDER BY BorrowCount DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public DataTable GetAllBorrowHistory()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
        SELECT U.FullName, B.Title, Br.State, Br.RequestDate
        FROM Borrows Br
        JOIN Users U ON Br.UserId = U.Id
        JOIN Books B ON Br.BookId = B.Id";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public int GetDailyBorrowCount()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
        SELECT COUNT(*) 
        FROM Borrows
        WHERE CAST(RequestDate AS DATE) = CAST(GETDATE() AS DATE)";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            return (int)cmd.ExecuteScalar();
        }

        public int GetWeeklyBorrowCount()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
        SELECT COUNT(*) 
        FROM Borrows
        WHERE RequestDate >= DATEADD(DAY, -7, GETDATE())";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            return (int)cmd.ExecuteScalar();
        }

        public int GetMonthlyBorrowCount()
        {
            using SqlConnection conn = new SqlConnection(_connectionString);
            string query = @"
        SELECT COUNT(*) 
        FROM Borrows
        WHERE MONTH(RequestDate) = MONTH(GETDATE())
        AND YEAR(RequestDate) = YEAR(GETDATE())";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            return (int)cmd.ExecuteScalar();
        }


    }
}
