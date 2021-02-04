using LinqToSqlExample.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSqlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.GetChacters;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.GetChacters:
                    GetData.GetCharacters();
                    break;
                case ExamplesEnumeration.GetCharactersWithLinq:
                    GetData.GetCharactersWithLinq();
                    break;
                case ExamplesEnumeration.UpdateCharacter:
                    UpdateData.UpdateCharacter();
                    break;
                case ExamplesEnumeration.InsertCharacter:
                    InsertData.InsertCharacter();
                    break;
            }

            Console.Read();
        }
    }
}
