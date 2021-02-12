using EntityFrameworkCoreExample.BasicEntityFrameworkExamples;
using System;

namespace EntityFrameworkCoreExample
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
                    GetData.GetDependentData();
                    break;
                case ExamplesEnumeration.UpdateCharacter:
                    Update.UpdateCharacter();
                    break;
                case ExamplesEnumeration.DeleteCharacter:
                    Delete.DeleteCharacter();
                    break;
                case ExamplesEnumeration.GetDependentData:
                    GetData.GetDependentData();
                    break;
            }

            Console.Read();
        }
    }
}
