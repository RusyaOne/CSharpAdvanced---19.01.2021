using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToDB.Examples
{
    public static class CommandWithTransaction
    {
        public static void ShowTransaction()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand command = new SqlCommand();
                    command.Transaction = transaction;
                    command.Connection = connection;

                    command.CommandText = @"insert into Characters (FirstName, Lastname, Gender, Age) 
                        values ('Paul', 'Duré', 1, 75)";
                    command.ExecuteNonQuery();

                    command.CommandText = @"insert into Characters (FirstName, Lastname, Gender, Age) 
                        values ('Rachel', 'Weintraub', 0, 24)";
                    command.ExecuteNonQuery();

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    transaction.Rollback();
                }
            }
        }
    }
}