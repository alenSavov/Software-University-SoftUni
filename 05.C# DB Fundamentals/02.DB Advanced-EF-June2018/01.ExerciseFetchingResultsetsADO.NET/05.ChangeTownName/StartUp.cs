using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _05.ChangeTownName
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

            string countryName = Console.ReadLine();

            connection.Open();
            connection.ChangeDatabase("MinionsDB");

            using (connection)
            {
                int? countryId = (int?)new SqlCommand($"SELECT Id FROM Countries WHERE Name = '{countryName}'", connection).ExecuteScalar();

                if (countryId == null)
                {
                    Console.WriteLine("No town names were affected.");
                }
                else
                {
                    int townsCount = (int)new SqlCommand($"SELECT COUNT(*) FROM Towns WHERE CountryId = {countryId}", connection).ExecuteScalar();

                    SqlDataReader reader = new SqlCommand($"SELECT * FROM Towns WHERE CountryId = {countryId}", connection).ExecuteReader();

                    var townNamesAffected = new List<String>();
                    var townIdsAffected = new List<int>();

                    using (reader)
                    {
                        if (!reader.HasRows)
                        {
                            Console.WriteLine("No town names were affected.");
                            reader.Close();
                            connection.Close();
                            return;
                        }

                        while (reader.Read())
                        {

                            string townName = (string)reader["Name"];
                            int townId = (int)reader["Id"];

                            townNamesAffected.Add(townName.ToUpper());
                            townIdsAffected.Add(townId);
                        }
                    }

                    for (int i = 0; i < townIdsAffected.Count; i++)
                    {
                        new SqlCommand($"UPDATE Towns SET Name = '{townNamesAffected[i].ToUpper()}' WHERE Id = {townIdsAffected[i]}", connection).ExecuteNonQuery();
                    }

                    Console.WriteLine($"{townsCount} town names were affected.");
                    Console.WriteLine($"[{String.Join(", ", townNamesAffected)}]");
                }
            }
        }
    }
}
