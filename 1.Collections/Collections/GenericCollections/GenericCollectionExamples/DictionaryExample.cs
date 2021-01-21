using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollections.GenericCollectionExamples
{
    public static class DictionaryExample
    {
        public static void ShowDictionary()
        {
            Dictionary<string, string> openWith = new Dictionary<string, string>();

            openWith.Add("txt", "notepad");
            openWith.Add("doc", "word");
            openWith.Add("vsd", "photoshop");
            openWith.Add("md", "vsCode");

            //Каждый элемент Hashtable это object, потому в цикле необходимо приведение типа
            //Каждый элемент Dictionary это KeyValuePair<T,T>, приведение необязательно, можно использовать var
            foreach (var element in openWith)
            {
                Console.WriteLine($"Key: {element.Key} \tValue: {element.Value}");
            }
        }

        public static void CompileTimeError()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad");
            openWith.Add("doc", "word");
            openWith.Add("vsd", "photoshop");
            openWith.Add("md", new Queue());

            //Dictionary<string, string> strictOpenWith = new Dictionary<string, string>();

            //strictOpenWith.Add("txt", "notepad");
            //strictOpenWith.Add("doc", "word");
            //strictOpenWith.Add("vsd", "photoshop");
            //strictOpenWith.Add("md", new Queue());

            try
            {
                Console.WriteLine((string)openWith["txt"] + (string)openWith["md"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void InitializationSyntaxes()
        {
            //Adding elements after initialization
            Dictionary<string, string> openWith = new Dictionary<string, string>();
            openWith.Add("txt", "notepad");
            openWith.Add("doc", "word");

            //Adding elements with initialization
            Dictionary<string, string> initializedWithValues = new Dictionary<string, string> 
            {
                { "txt", "notepad" },
                { "doc", "word" }
            };

            //Addin elements with new syntax
            Dictionary<string, string> initializedWithNewSyntax = new Dictionary<string, string>
            {
                ["txt"] = "notepad",
                ["doc"] = "word" 
            };

            try
            {
                Console.WriteLine((string)openWith["txt"] + (string)openWith["md"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
