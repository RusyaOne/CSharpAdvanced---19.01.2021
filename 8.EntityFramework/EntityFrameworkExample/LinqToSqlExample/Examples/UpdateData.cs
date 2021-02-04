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
    public static class UpdateData
    {
        public static void UpdateCharacter()
        {
            DataContext dataContext = new DataContext(
                ConfigurationManager.ConnectionStrings["CSharpAdvancedContext"].ToString());

            var character = dataContext.GetTable<Character>().FirstOrDefault(x => x.FirstName == "Tom" && x.LastName == "Riddle");

            character.FirstName = "Lord";
            character.LastName = "Voldemort";

            //dataContext.SubmitChanges();

            Console.WriteLine("Character updated");
        }

        //Самостоятельно создайте метод в котором измените Gender = false для Волдеморта
        //выведите в консоль SQL запрос, который при этом был сгенирирован
    }
}
