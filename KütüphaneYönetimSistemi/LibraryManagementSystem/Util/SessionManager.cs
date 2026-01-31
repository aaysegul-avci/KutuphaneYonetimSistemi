using Odev12.Repository;
using System.Configuration;

namespace Odev12.Util
{
    public static class SessionManager
    {
        public static int UserId { get;  set; }
        public static string FullName { get;  set; }
        public static string Role { get;  set; }

        public static string ConnectionString = Database.connectionString;

    }
}
