using LINQ.HelpMaterial;
using System;

namespace LINQ.LinqExamples
{
    public static class AnonymousTypes
    {
        public static void ShowAnonymousTypes()
        {
            var orc = new { Skin = "Green", Age = 46 };

            Console.WriteLine($"Anonymous type properties: {orc.Skin} {orc.Age}");
        }

        public static void TryChangeProperty()
        {
            var orc = new { Skin = "Green", Age = 46 };

            //orc.Age = 45;

            Console.WriteLine(orc.GetType());
        }

        public static void PropertiesNamesInheritance()
        {
            var orc = new { Skin = "Green", Age = 46 };

            var uruk = new { Skin = "Grey", orc.Age };

            foreach (var property in uruk.GetType().GetProperties())
                Console.WriteLine(property.Name);
        }
    }
}
