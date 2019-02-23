using System;
using System.Data.SqlClient;

namespace _9.IncreaseAgeStoredProcedure
{
    class StartUp
    {
        static void Main(string[] args)
        {

            var builder = new SqlConnectionStringBuilder()
            {
                ["Server"] = @"DESKTOP-U67U5UI\SQLEXPRESS",
                ["Integrated security"] = "true"
            };
            var connection = new SqlConnection(builder.ToString());
            connection.Open();
            connection.ChangeDatabase("MinionsDB");

            int id = int.Parse(Console.ReadLine());

            using (connection)
            {
                var command = new SqlCommand("EXEC usp_GetOlder @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();

                command = new SqlCommand("SELECT * FROM Minions WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", id);

                var reader = command.ExecuteReader();

                using (reader)
                {
                    reader.Read();

                    Console.WriteLine($"{(string)reader["Name"]} - {(int)reader["Age"]} years old");
                }
            }
        }
    }
}
