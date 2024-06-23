using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main(string[] args)
    {
        var connectionString = "Server=localhost;" +
                               "Database=sakila;" +
                               "User ID=root;" +
                               "Password=cipolle";
        var query = "SELECT actor_id,first_name FROM actor ";



        using (MySqlConnection connection = new MySqlConnection(connectionString))
        {
            connection.Open();

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                   string id= reader.GetString(0);
                    string name = reader.GetString(1);


                    Console.WriteLine($"{id};{name} ");
                }

                reader.Close();
            }
        }

        Console.ReadKey();
    }
}