using ConnectToDB.Examples;
using System;

namespace ConnectToDB
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.ShowTransaction;

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
                case ExamplesEnumeration.ShowParametersInCommand:
                    CommandWithParameters.ShowParameter();
                    break;
                case ExamplesEnumeration.ShowMultipleParaters:
                    CommandWithParameters.MultipleParameters();
                    break;
                case ExamplesEnumeration.ShowParatersType:
                    CommandWithParameters.SpecifyParameterType();
                    break;
                case ExamplesEnumeration.ShowTransaction:
                    CommandWithTransaction.ShowTransaction();
                    break;
            }
        }
    }
}