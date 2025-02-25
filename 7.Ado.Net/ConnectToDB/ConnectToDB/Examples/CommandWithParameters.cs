﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ConnectToDB.Examples
{
    public static class CommandWithParameters
    {
        public static void ShowParameter()
        {
            var sqlExpression = @"update Characters set LastName = 'Wasted' where FirstName = @firstName";

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

        public static void ShowNullParameter()
        {
            var sqlExpression = @"update Characters set LastName = @lastName where FirstName = @firstName";

            var connectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);

                SqlParameter parameterFirstName = new SqlParameter();
                parameterFirstName.ParameterName = "@firstName";
                parameterFirstName.Value = "Princess";

                SqlParameter parameterLastName = new SqlParameter();
                parameterLastName.ParameterName = "@lastName";
                parameterLastName.Value = DBNull.Value;

                command.Parameters.Add(parameterFirstName);
                command.Parameters.Add(parameterLastName);

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
                parameter.Value = 0;

                command.Parameters.Add(parameter);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static void ReturnScopeIdentity()
        {
            var sqlExpression = @"insert into Characters (FirstName, Lastname, Gender, Age) 
                values (@firstName, @lastName, @gender, @age);";
            sqlExpression += "select scope_identity()";

            var connectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.Add(new SqlParameter("@firstName", "Lenar"));
                command.Parameters.Add(new SqlParameter("@lastName", "Hoyt"));
                command.Parameters.Add(new SqlParameter("@gender", 1));
                command.Parameters.Add(new SqlParameter("@age", 60));

                connection.Open();
                var identity = command.ExecuteScalar();
                Console.WriteLine(identity);
            }
        }

        public static void ReturnScopeIdentityWithOutputParameter()
        {
            var sqlExpression = @"insert into Characters (FirstName, Lastname, Gender, Age) 
                values (@firstName, @lastName, @gender, @age);
                set @scopeIdentity = scope_identity()";

            var connectionString = ConfigurationManager.ConnectionStrings["AdvanceCSharpCS"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                command.Parameters.Add(new SqlParameter("@firstName", "Lenar"));
                command.Parameters.Add(new SqlParameter("@lastName", "Hoyt"));
                command.Parameters.Add(new SqlParameter("@gender", 1));
                command.Parameters.Add(new SqlParameter("@age", 60));

                SqlParameter outputParameter = new SqlParameter();
                outputParameter.Direction = ParameterDirection.Output;
                outputParameter.ParameterName = "@scopeIdentity";
                outputParameter.Size = 4;

                connection.Open();

                command.Parameters.Add(outputParameter);
                command.ExecuteNonQuery();

                Console.WriteLine(outputParameter.Value);
            }
        }
    }
}