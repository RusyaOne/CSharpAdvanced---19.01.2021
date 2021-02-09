using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ConnectToDB.Examples
{
    public static class CommandWithParameters
    {
        public static void ShowParameter()
        {
            var sqlExpression = @"update Characters set LastName = 'Bubblegum' where FirstName = @firstName";

            var connectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@firstName";
                parameter.Value = "Princess";

                command.Parameters.Add(parameter);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void MultipleParameters()
        {
            var sqlExpression = @"insert into Characters (FirstName, Lastname, Gender, Age) 
                values (@firstName, @lastName, @gender, @age)";

            var connectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.Add(new SqlParameter("@firstName", "Lenar"));
                command.Parameters.Add(new SqlParameter("@lastName", "Hoyt"));
                command.Parameters.Add(new SqlParameter("@gender", 1));
                command.Parameters.Add(new SqlParameter("@age", 60));

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void SpecifyParameterType()
        {
            var sqlExpression = @"update Characters set Gender = @gender where FirstName = 'Svetlana'";

            var connectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@gender";
                parameter.SqlDbType = SqlDbType.Bit;
                parameter.Value = 1;

                command.Parameters.Add(parameter);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}