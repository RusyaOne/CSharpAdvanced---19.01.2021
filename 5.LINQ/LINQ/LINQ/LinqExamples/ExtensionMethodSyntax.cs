﻿using LINQ.HelpMaterial;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.LinqExamples
{
    public static class ExtensionMethodSyntax
    {
        public static void ShowExtensionMethodSyntax()
        {
            var characters = CharactersRepository.GetCharacters();

            var adults = characters.Where(character => character.Age > 20);

            //var adults = from character in characters
            //             where character.Age > 20
            //             select character;

            foreach (var adult in adults)            
                Console.WriteLine(adult.ToString());            
        }

        public static void DefferedExecution()
        {
            var characters = CharactersRepository.GetCharacters().ToList();

            var adults = characters.Where(character => character.FirstName.StartsWith("A"));

            characters.Add(new Character("Andrew", "Harlan", true, 37, 2, "Foundation"));

            //Запрос выполняется в момент его использования
            foreach (var adult in adults)
                Console.WriteLine(adult.ToString());
        }
    }
}
