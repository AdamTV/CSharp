namespace Polymorphism
{
    internal class Program
    {
        private static void Main()
        {
            var sql = new SqlConnection("1");
            var oracle = new OracleConnection("2");
            sql.OpenConnection();
            oracle.OpenConnection();
            oracle.CloseConnection();
            sql.CloseConnection();

            var command1 = new DbCommand(new SqlConnection("1"),"Adam is the best SQL" );
            var command2 = new DbCommand(new OracleConnection("2"), "Adam is the best Oracle");
            command1.Execute();
            command2.Execute();
        }
    }
}
