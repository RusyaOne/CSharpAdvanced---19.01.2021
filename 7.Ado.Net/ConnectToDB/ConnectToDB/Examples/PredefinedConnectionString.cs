using System.Data.SqlClient;
using System.Configuration;

namespace ConnectToDB.Examples
{
    public static class PredefinedConnectionString
    {
        public static void UpdateCharacter()
        {
            var queryString =
                @"update Characters set LastName = 'Undomiel' where FirstName = 'Arven'";
                   
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString;
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
