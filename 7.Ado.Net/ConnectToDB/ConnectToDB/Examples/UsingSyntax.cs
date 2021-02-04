using System;
using System.Data.SqlClient;

namespace ConnectToDB.Examples
{
    public static class UsingSyntax
    {
        public static void DeleteCharacter()
        {
            var queryString = @"delete from Characters where FirstName = 'Harry'";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = UKR-RUSLANAN; 
                    Initial Catalog = CSharpAdvanced;
                    Integrated Security = SSPI;";
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                var rows = command.ExecuteNonQuery();
                Console.WriteLine(rows);
            }
        }

        public static void SelectCharacters()
        {
            var queryString = @"select * from Characters";

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source = UKR-RUSLANAN; 
                    Initial Catalog = CSharpAdvanced;
                    Integrated Security = SSPI;";
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
