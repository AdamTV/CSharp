using System;

namespace Polymorphism
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _dbInstruction;

        public DbCommand(DbConnection connection, string instruction)
        {
            // throw expression
            _dbConnection = connection ?? throw new InvalidOperationException("Connection is null");
            if (string.IsNullOrEmpty(instruction))
                throw (new InvalidOperationException("Instruction cannot be null"));
            _dbInstruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine($"Connection String:  {_dbConnection.GetString()}\n" +
                              $"DB Instruction:     {_dbInstruction}");
            _dbConnection.CloseConnection();
        }
    }
}