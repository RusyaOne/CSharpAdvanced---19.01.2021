using EntityFrameworkLesson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkLesson
{
    public class CinemaService
    {
        public void AddCharacters()
        {
            var dbContext = new CinemaContext();
            List<Character> characters = GetCharacters();
            
            dbContext.Characters.AddRange(characters);            

            dbContext.SaveChanges();
        }

        public void GetCharactersFromDb()
        {
            var dbContext = new CinemaContext();
            var characters = dbContext.Characters;

            foreach (var c in characters)
                Console.WriteLine($"Id: {c.Id},  \tFirstName: {c.FirstName}  " +
                    $"\tLastName: {c.LastName}  \tGender: {c.Gender}  \tAge: {c.Age}");
        }

        public void DeleteCharacters()
        {
            var dbContext = new CinemaContext();
            var deleteCharacters = dbContext.Characters.Where(x => x.FirstName == "John");

            dbContext.Characters.RemoveRange(deleteCharacters);

            dbContext.SaveChanges();
        }

        public void AddCharacter()
        {
            var dbContext = new CinemaContext();
            var character = new Character()
                { FirstName = "Tom", LastName = "Riddle", Gender = true, Age = 17 };
            
            dbContext.Characters.Add(character);           

            dbContext.SaveChanges();

            Console.WriteLine($"Character {character.FirstName} added");
        }

        public static void UpdateCharacter()
        {
            var dbContext = new CinemaContext();
            var character = dbContext.Characters.FirstOrDefault(x => x.FirstName == "Tom");

            character.FirstName = "Lord";
            character.LastName = "Voldemort";
            character.Gender = true;
            character.Age = 40;
            //dbContext.Entry(character).State = EntityState.Modified;

            dbContext.SaveChanges();
            Console.WriteLine("Character updated");
        }

        private List<Character> GetCharacters()
        {
            var characters = new List<Character>();

            characters.Add(new Character() { FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14 });
            characters.Add(new Character() { FirstName = "Philip", LastName = "Fry", Gender = true, Age = 25 });
            characters.Add(new Character() { FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700 });
            characters.Add(new Character() { FirstName = "Audrey", LastName = "Hepburn", Gender = false, Age = 29 });
            characters.Add(new Character() { FirstName = "John", LastName = "Wick", Gender = true, Age = 42 });
            characters.Add(new Character() { FirstName = "Anakin", LastName = "Skywalker", Gender = true, Age = 29 });
            characters.Add(new Character() { FirstName = "Princess", LastName = "Bubblegum", Gender = false, Age = 827 });
            characters.Add(new Character() { FirstName = "Svetlana", LastName = "Sokolova", Gender = false, Age = 45 });
            characters.Add(new Character() { FirstName = "Varian", LastName = "Wrynn", Gender = true, Age = 42 });
            characters.Add(new Character() { FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35 });

            return characters;
        }
    }
}
