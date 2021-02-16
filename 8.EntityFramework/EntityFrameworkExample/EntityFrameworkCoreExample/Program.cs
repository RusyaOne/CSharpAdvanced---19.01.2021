using EntityFrameworkCoreExample.BasicEntityFrameworkExamples;
using System;

namespace EntityFrameworkCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {            
            var exampleToRun = ExamplesEnumeration.GetDependentDataWithLazyLoading;

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
                case ExamplesEnumeration.GetDependentDataWithExplicitLoading:
                    GetData.GetDependentDataWithExplicitLoading();
                    break;
                case ExamplesEnumeration.GetDependentDataWithEagerLoading:
                    GetData.GetDependentDataWithEagerLoading();
                    break;
                case ExamplesEnumeration.GetDependentDataWithLazyLoading:
                    GetData.GetDependentDataWithLazyLoading();
                    break;
            }

            Console.Read();
        }
    }
}
