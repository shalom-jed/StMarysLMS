using System;
using Microsoft.Data.SqlClient;

namespace StMarysLMS
{
    public static class DatabaseHelper
    {
        // Update "localhost" if your SQL Server instance has a different name
        private static readonly string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=StMarysLibraryDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}