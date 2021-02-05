using System;
using System.Data.SqlClient;

namespace ConnectToDB.Examples
{
    public static class UsingSyntax
    {
        public static void DeleteCharacter()
        {
            var queryString = @"delete from Characters where FirstName = 'Harry'";

            string connectionString = 
                @"Server = UKR-RUSLANAN; Database = CSharpAdvanced; Trusted_Connection = True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                var rows = command.ExecuteNonQuery();
                Console.WriteLine(rows);
            }
        }

        public static void SelectCharacters()
        {
            var queryString = @"select * from Characters";

            string connectionString =
                @"Server = UKR-RUSLANAN; Database = CSharpAdvanced; Trusted_Connection = True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                
                using (SqlDataReader sqlReader = command.ExecuteReader())
                {
                    while (sqlReader.Read())
                    {
                        Console.WriteLine($"FirstName: {sqlReader[0]}, \tLastName: {sqlReader[1]}," +
                            $"  \tGender: {sqlReader[2]}, \tAge: {sqlReader[3]}");
                    }
                }                
            }
        }
    }
}
