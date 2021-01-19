using System;
using System.Collections;

namespace Collections.CollectionsExamples
{
    public static class HashTableExample
    {
        public static void ShowHashTable()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad");
            openWith.Add("doc", "word");
            openWith.Add("vsd", "photoshop");
            openWith.Add("md", 1);

            foreach (var value in openWith.Values)
            {
                Console.WriteLine(value);
            }
        }

        public static void PrintKeys()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad");
            openWith.Add("doc", "word");
            openWith.Add("vsd", "photoshop");
            openWith.Add("md", "vsCode");

            foreach (var key in openWith.Keys)
            {
                Console.WriteLine(key);
            }
        }

        public static void GetValueByKey()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad");
            openWith.Add("doc", "word");
            openWith.Add("vsd", "photoshop");
            openWith.Add("md", "vsCode");

            Console.WriteLine(openWith["txt"]);
        }

        public static void DuplicateKeys()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad");
            openWith.Add("doc", "word");
            openWith.Add("vsd", "photoshop");
            openWith.Add("md", "vsCode");

            try
            {
                openWith.Add("txt", "note");
                Console.WriteLine("Insert successful");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DuplicateValues()
        {
            Hashtable openWith = new Hashtable();

            openWith.Add("txt", "notepad");
            openWith.Add("doc", "word");
            openWith.Add("vsd", "photoshop");
            openWith.Add("md", "vsCode");

            try
            {
                openWith.Add("cs", "vsCode");
                Console.WriteLine("Insert successful");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void ConstructorInitialization()
        {
            Hashtable openWith = new Hashtable
            {
                { "txt", "notepad" },
                { "doc", "word" },
                { "vsd", "photoshop" },
                { "md", "vsCode" }
            };

            // Исплользуем DictionaryEntry вместо var, чтоб вытянуть Key и Value в теле цыкла
            foreach (DictionaryEntry element in openWith)
            {
                Console.WriteLine($"Key:{element.Key}  \tValue:{element.Value}");
            }
        }
    }
}
