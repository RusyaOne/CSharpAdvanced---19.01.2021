using System;
using System.Linq;

namespace EntityFrameworkCoreExample.BasicEntityFrameworkExamples
{
    public static class Update
    {
        public static void UpdateCharacter()
        {
            var dbContext = new CSharpAdvancedContext();            
            var character = dbContext.Characters.FirstOrDefault();

            character.FirstName = "Tom";
            character.LastName = "Riddle";
            character.Gender = true;
            character.Age = 17;
            //dbContext.Entry(character).State = EntityState.Modified;

            dbContext.SaveChanges();
            Console.WriteLine("Character updated");
        }

        //Самостоятельно измените имя первого персонажа, 
        //воссоздайте ситуацию когда персонаж будет отслеживаться в другом контексте
    }
}
