using System;
using System.Data.SqlClient;

class Program
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

        using (connection)
        {
            SqlCommand command = new SqlCommand("SELECT v.Name, COUNT(mv.VillainId) AS MinionsCount FROM Villains AS v JOIN MinionsVillains AS mv ON v.Id = mv.VillainId GROUP BY v.Id, v.Name HAVING COUNT(mv.VillainId) > 3 ORDER BY COUNT(mv.VillainId)", connection);
            connection.ChangeDatabase("MinionsDB");

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                string villainName = (string)reader["Name"];
                int minionsCount = (int)reader["MinionsCount"];

                Console.WriteLine($"{villainName} - {minionsCount}");
            }

        }
    }
}