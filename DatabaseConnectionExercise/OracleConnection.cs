using System;

namespace DatabaseConnectionExercise
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connection) : base(connection)
        {
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnection opened");
        }

        public override void Close()
        {
            Console.WriteLine("OracleConnection closed");
        }
    }
}