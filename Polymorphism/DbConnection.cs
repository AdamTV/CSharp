using System;

namespace Polymorphism
{
    public abstract class DbConnection
    {
        protected string ConnectionString { get; set; }
        protected TimeSpan Timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw (new InvalidOperationException("Connection string must not be null or empty"));
            ConnectionString = connectionString;
        }

        public string GetString()
        {
            return ConnectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}