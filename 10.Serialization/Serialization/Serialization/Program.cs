using Serialization.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.GetFromFile;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.ShowJsonSerialization:
                    SimpleJsonSerizalization.ShowJsonSerialization();
                    break;
                case ExamplesEnumeration.SerializerOptions:
                    SimpleJsonSerizalization.ShowSerializerOptions();
                    break;
                case ExamplesEnumeration.CustomAttributes:
                    SimpleJsonSerizalization.ShowSerializedAttributes();
                    break;
                case ExamplesEnumeration.Deserialize:
                    JsonDesirealization.ShowDeserialization();
                    break;
                case ExamplesEnumeration.SaveToFile:
                    SaveToFile.SaveJsonToFile();
                    break;
                case ExamplesEnumeration.GetFromFile:
                    SaveToFile.GetFromFile();
                    break;
            }

            Console.Read();
        }
    }
}
