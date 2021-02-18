using Assemblies.HelpMaterial;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assemblies.Examples
{
    public static class GetTypeExamples
    {
        public static void ShowGetType()
        {
            //var character = new Character();
            Type type;

            //Different ways of getting class` type
            //type = character.GetType();

            //type = Type.GetType("Assemblies.HelpMaterial.Character");

            type = typeof(Character);

            Console.WriteLine(type.Name);
        }
    }
}
