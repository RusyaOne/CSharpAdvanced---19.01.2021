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
    public static class InsertData
    {
        public static void InsertCharacter()
        {
            DataContext dataContext = new DataContext(
                ConfigurationManager.ConnectionStrings["CSharpAdvancedContext"].ToString());

            dataContext.GetTable<Character>().InsertOnSubmit(new Character()
                { FirstName = "Johann", LastName = "Bach", Age = 0, Gender = true });
            dataContext.SubmitChanges();

            Console.WriteLine("Character inserted");
        }
    }
}
