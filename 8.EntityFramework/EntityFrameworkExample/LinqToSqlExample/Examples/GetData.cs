using LinqToSqlExample.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlExample.Examples
{
    public static class GetData
    {
        public static void GetCharacters()
        {
            DataContext dataContext = new DataContext(
                ConfigurationManager.ConnectionStrings["CSharpAdvancedContext"].ToString());

            var characters = dataContext.GetTable<Character>();

            //Console.WriteLine(dataContext.GetCommand(characters).CommandText + "\n");

            foreach (var c in characters)
            {
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");
            }
        }

        public static void GetCharactersWithLinq()
        {
            DataContext dataContext = new DataContext(
                ConfigurationManager.ConnectionStrings["CSharpAdvancedContext"].ToString());

            var characters = dataContext.GetTable<Character>().Where(x => x.Gender == true).OrderBy(x => x.FirstName);

            foreach (var c in characters)
            {
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}   \tGender: {c.Gender}  \tAge: {c.Age}");
            }
        }

        //Самостоятельно создайте проект и с помощью Linq To Sql 
        //выведите в консоль персонажей Gender == false и старше 100 лет
        //отсортируйте персонажей по возрасту
    }
}
