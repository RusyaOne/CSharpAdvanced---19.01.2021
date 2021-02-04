using System;
using System.Linq;
using System.Data.Entity;

namespace EntityFrameworkExample.EntityFrameworkExamples
{
    public static class Delete
    {   
        public static void DeleteCharacter()
        {
            var dbContext = new CSharpAdvancedContext();
            var character = dbContext.Characters.FirstOrDefault(x => x.FirstName == "John");

            dbContext.Characters.Remove(character);
            //dbContext.Entry(character).State = EntityState.Deleted;

            dbContext.SaveChanges();
            Console.WriteLine("Character deleted");
        }

        //Самостоятельно удалите 6го по счету персонажа
    }
}
