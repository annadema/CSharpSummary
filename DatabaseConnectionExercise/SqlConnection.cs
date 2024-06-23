using System;

namespace DatabaseConnectionExercise
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connection) : base(connection)
        {
        }

        public override void Open()
        {
            Console.WriteLine("SqlConnection opened {0}", this.ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("SqlConnection closed");
        }
    }
}