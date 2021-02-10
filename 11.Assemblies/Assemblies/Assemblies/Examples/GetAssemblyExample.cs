using Assemblies.HelpMaterial;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Assemblies.Examples
{
    public static class GetAssemblyExample
    {
        public static void ShowGetAssembly()
        {
            var assembly = typeof(Character).Assembly;

            Console.WriteLine(assembly.FullName + "\n");

            foreach (var type in assembly.DefinedTypes)
            {
                Console.WriteLine(type.Name);
            }
        }
    }
}
