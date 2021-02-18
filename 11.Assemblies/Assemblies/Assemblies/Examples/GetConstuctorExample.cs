using Assemblies.HelpMaterial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Assemblies.Examples
{
    public static class GetConstuctorExample
    {
        public static void ShowGetConstructor()
        {
            var constructors = typeof(Character).GetConstructors();

            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
                foreach (var parameter in constructor.GetParameters())
                {
                    Console.WriteLine(parameter.Name);
                }
                Console.WriteLine();
            }
        }
    }
}
