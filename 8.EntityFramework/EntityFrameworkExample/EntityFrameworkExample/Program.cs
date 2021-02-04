using EntityFrameworkExample.EntityFrameworkExamples;
using System;

namespace EntityFrameworkExample
{
    class Program
    {
        static void Main(string[] args)
        {            
            var exampleToRun = ExamplesEnumeration.GetCharactersFromDb;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.AddCharactersToDb:
                    AddData.AddCharactersToDb();
                    break;
                case ExamplesEnumeration.GetCharactersFromDb:
                    GetData.GetCharactersFromDb();
                    break;
                case ExamplesEnumeration.UpdateCharacter:
                    Update.UpdateCharacter();
                    break;
                case ExamplesEnumeration.DeleteCharacter:
                    Delete.DeleteCharacter();
                    break;
            }

            Console.Read();
        }
    }
}
