using Attributes.Examples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    public static class ExamplesRunner<T>
    {
        public static void ShowTypeAttributes(T instance)
        {
            var customAttributes = instance.GetType().CustomAttributes;

            foreach (var attribute in customAttributes)
                Console.WriteLine(attribute);
        }        

        public static void ShowMethodsAttributes(T instance)
        {
            var methods = instance.GetType().GetMethods();

            foreach (var method in methods)
                foreach (var attributeData in method.CustomAttributes)
                    Console.WriteLine(attributeData);
        }

        public static void ShowPropertiesAttributes(T instance)
        {
            var properties = instance.GetType().GetProperties();

            foreach (var property in properties)
                foreach (var attributeData in property.CustomAttributes)
                    Console.WriteLine(attributeData);
        }

        public static void ShowAllAttributes(T instance)
        {
            var members = instance.GetType().GetMembers();

            foreach (var member in members)
                foreach (var attributeData in member.CustomAttributes)
                    Console.WriteLine(attributeData);
        }
    }
}
