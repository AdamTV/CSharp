using System;

namespace Polymorphism
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"Opening SQL Connection for {GetString()}");
        }

        public override void CloseConnection()
        {
            Console.WriteLine($"Closing SQL Connection for {GetString()}");
        }
    }
}