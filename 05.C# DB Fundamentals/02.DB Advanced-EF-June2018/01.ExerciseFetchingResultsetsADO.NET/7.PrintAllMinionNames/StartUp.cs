using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _7.PrintAllMinionNames
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

            List<string> minionsInitial = new List<string>();
            List<string> minionsArranged = new List<string>();

            using (connection)
            {
                SqlCommand command = new SqlCommand("SELECT Name FROM Minions", connection);

                SqlDataReader reader = command.ExecuteReader();

                using (reader)
                {
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        connection.Close();
                        return;
                    }

                    while (reader.Read())
                    {
                        minionsInitial.Add((string)reader["Name"]);
                    }
                }
            }

            while (minionsInitial.Count > 0)
            {
                minionsArranged.Add(minionsInitial[0]);
                minionsInitial.RemoveAt(0);

                if (minionsInitial.Count > 0)
                {
                    minionsArranged.Add(minionsInitial[minionsInitial.Count - 1]);
                    minionsInitial.RemoveAt(minionsInitial.Count - 1);
                }
            }

            minionsArranged.ForEach(m => Console.WriteLine(m));
        }
    }
}
