using System;

namespace Polymorphism
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {

        }
        public override void CloseConnection()
        {
            Console.WriteLine($"Closing Oracle Connection for {ConnectionString}");
        }

        public override void OpenConnection()
        {
            Console.WriteLine($"Opening Oracle Connection for {ConnectionString}");
        }
    }
}