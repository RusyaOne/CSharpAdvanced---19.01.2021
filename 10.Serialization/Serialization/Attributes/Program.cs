using Attributes.CustomAttributes;
using Attributes.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.ShowTypeAttributes;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.ShowTypeAttributes:
                    var attribute = new AttributesExample();
                    ExamplesRunner<AttributesExample>.ShowTypeAttributes(attribute);
                    break;
                case ExamplesEnumeration.ShowMethodsAttributes:
                    ExamplesRunner<AttributesExample>.ShowMethodsAttributes(new AttributesExample());
                    break;
                case ExamplesEnumeration.ShowPropertiesAttributes:
                    ExamplesRunner<AttributesExample>.ShowPropertiesAttributes(new AttributesExample());
                    break;
                case ExamplesEnumeration.ShowAllAttributes:
                    ExamplesRunner<AttributesExample>.ShowAllAttributes(new AttributesExample());
                    break;
                case ExamplesEnumeration.ShowImportantAttribute:
                    ExamplesRunner<ImportantClass>.ShowTypeAttributes(new ImportantClass());
                    break;
                case ExamplesEnumeration.ShowAttributesOnType:
                    foreach (var attr in typeof(ImportantClass).CustomAttributes)
                        Console.WriteLine(attr);
                    break;
            }

            Console.Read();
        }
    }
}