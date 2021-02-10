using System;

namespace EntityFrameworkCoreExample.BasicEntityFrameworkExamples
{
    public static class GetData
    {
        public static void GetCharactersFromDb()
        {
            var dbContext = new CharactersDbContext();            

            foreach (var c in dbContext.Characters)            
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");                     
        }

        //Самостоятельно создайте метод, который будет выводить персонажей из БД в консоль
    }
}
