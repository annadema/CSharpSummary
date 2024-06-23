using System;

namespace DatabaseConnectionExercise
{

    class DbCommand
    {
        public DbConnection  { get; set; }
        public DbCommand(DbConnection connectionDB)
        {
            if(connectionDB==null)
                throw new Exception("Connection to DB not established");
            //Connection = new 
        }
    }

    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connection)
        {
            if (String.IsNullOrEmpty(connection))
                throw new Exception("connection can't be null or empty");

            this.ConnectionString = connection;
        }

        public abstract void Open();
        public abstract void Close();
 
        
    }
}