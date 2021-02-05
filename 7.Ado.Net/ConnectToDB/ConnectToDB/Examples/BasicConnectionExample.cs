using System;
using System.Data.SqlClient;

namespace ConnectToDB.Examples
{
    public static class BasicConnectionExample
    {
        public static void ShowBasicSyntaxConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Server = UKR-RUSLANAN; Database = CSharpAdvanced; Trusted_Connection = True;";

            try
            {
                connection.Open();
                Console.WriteLine("DB name: " + connection.Database);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void InsertCharacter()
        {
            string queryString = @"insert into Characters ([FirstName], [LastName], [Gender], [Age]) 
                                   values ('Harry', 'Seldon', 1, 50)";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = UKR-RUSLANAN; 
                    Initial Catalog = CSharpAdvanced;
                    Integrated Security = SSPI;";

            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                var rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine("Rows affected: " + rowsAffected);
            }
            finally
            {
                connection.Close();
            }
        }

        public static void SelectCharacters()
        {
            string queryString = @"select * from Characters";

            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = @"Data Source = UKR-RUSLANAN; 
                    Initial Catalog = CSharpAdvanced;
                    Integrated Security = SSPI;";

            SqlCommand command = new SqlCommand(queryString, connection);

            try
            {
                connection.Open();
                SqlDataReader sqlReader = command.ExecuteReader(); 

                try
                {
                    while (sqlReader.Read())
                    {
                        Console.WriteLine(sqlReader["LastName"].ToString());
                    }
                }
                finally
                {
                    sqlReader.Close();
                }
            }
            finally
            {
                connection.Close();
            }
        }

        //Установите подключение к базе данных 
    }
}