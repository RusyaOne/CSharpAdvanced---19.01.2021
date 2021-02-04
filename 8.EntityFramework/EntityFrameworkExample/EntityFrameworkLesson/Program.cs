using System;

namespace EntityFrameworkLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            var cinemaService = new CinemaService();
            //cinemaService.AddCharacters();
            //cinemaService.GetCharactersFromDb();
            //cinemaService.DeleteCharacters();
            cinemaService.AddCharacter();


            Console.WriteLine();
            cinemaService.GetCharactersFromDb();            
            Console.Read();
        }
    }
}
