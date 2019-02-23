using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Get_Minions_Names
{
    class P03_GetMinionsNames
    {

        static void Main(string[] args)
        {
            var builder = new SqlConnectionStringBuilder()
            {
                ["Server"] = @"DESKTOP-U67U5UI\SQLEXPRESS",
                ["Integrated security"] = "true"
            };
            var connection = new SqlConnection(builder.ToString());

            int villainId = int.Parse(Console.ReadLine());
            connection.Open();
            connection.ChangeDatabase("MinionsDB");

            using (connection)
            {
                SqlCommand command = new SqlCommand($"SELECT Name FROM Villains WHERE Id = {villainId} ", connection);
                var villainName = (string)command.ExecuteScalar();
                if (villainName == null)
                {
                    Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                    return;
                }

                Console.WriteLine($"Villain: {villainName}");

                command = new SqlCommand($"SELECT m.Name, m.Age, ROW_NUMBER() OVER (ORDER BY m.Name) as RowNum FROM MinionsVillains AS mv JOIN Minions As m ON mv.MinionId = m.Id WHERE mv.VillainId = {villainId} ORDER BY m.Name", connection);

                SqlDataReader reader = command.ExecuteReader();
                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        Console.WriteLine("(no minions)");
                        reader.Close();
                        connection.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        string minionName = (string)reader["Name"];
                        long rowNum = (long)reader["RowNum"];
                        int minionAge = (int)reader["Age"];

                        Console.WriteLine($"{rowNum}. {minionName} {minionAge}");
                    }
                }
            }
        }

    }
}