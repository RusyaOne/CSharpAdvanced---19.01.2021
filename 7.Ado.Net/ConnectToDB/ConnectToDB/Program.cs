using ConnectToDB.Examples;
using System;

namespace ConnectToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.SelectCharactersWithUsing;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.BasicConnection:
                    BasicConnectionExample.ShowBasicSyntaxConnection();
                    break;
                case ExamplesEnumeration.InsertCharacter:
                    BasicConnectionExample.InsertCharacter();
                    break;
                case ExamplesEnumeration.SelectCharacters:
                    BasicConnectionExample.SelectCharacters();
                    break;
                case ExamplesEnumeration.DeleteCharacterWithUsing:
                    UsingSyntax.DeleteCharacter();
                    break;
                case ExamplesEnumeration.SelectCharactersWithUsing:
                    UsingSyntax.SelectCharacters();
                    break;
                case ExamplesEnumeration.UpdateCharactersWithPredefinedCS:
                    PredefinedConnectionString.UpdateCharacter();
                    break;
            }

            Console.Read();
        }
    }
}
