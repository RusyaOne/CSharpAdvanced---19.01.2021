using EntityFrameworkCoreExample.BasicEntityFrameworkExamples;
using System;

namespace EntityFrameworkCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {            
            var exampleToRun = ExamplesEnumeration.DeleteCharacter;

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
