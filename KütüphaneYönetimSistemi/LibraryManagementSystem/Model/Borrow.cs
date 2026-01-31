namespace Odev12.Model;

    public class Borrow
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string State { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public DateTime? ReturnDate { get; set;}
    }

