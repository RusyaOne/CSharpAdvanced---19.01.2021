using Collections.CollectionsExamples;
using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //Which example to run
            var exampleToRun = Examples.HashtableInitialization;

            switch (exampleToRun)
            {
                case Examples.ArrayListShow:
                    ArrayListExample.ShowArrayList();
                    break;
                case Examples.ArrayListIntergers:
                    ArrayListExample.UseIntegers();
                    break;
                case Examples.ArrayListDelete:
                    ArrayListExample.DeleteElement();
                    break;
                case Examples.ArrayListInitialization:
                    ArrayListExample.ConstructorInitialization();
                    break;
                case Examples.StackShow: 
                    StackExample.ShowStack();
                    break;
                case Examples.StackPop:
                    StackExample.PopElement();
                    break;
                case Examples.StackPeek:
                    StackExample.PeekElement();
                    break;
                case Examples.QueueShow:
                    QueueExample.ShowQueue();
                    break;
                case Examples.QueueDequeue:
                    QueueExample.DequeueElement();
                    break;
                case Examples.QueuePeek:
                    QueueExample.PeekElement();
                    break;
                case Examples.HashtableShow:
                    HashTableExample.ShowHashTable();
                    break;
                case Examples.HashtablePrintKeys:
                    HashTableExample.PrintKeys();
                    break;
                case Examples.HashtableValueByKey:
                    HashTableExample.GetValueByKey();
                    break;
                case Examples.HashtableDuplicateKeys:
                    HashTableExample.DuplicateKeys();
                    break;
                case Examples.HashtableDuplicateValues:
                    HashTableExample.DuplicateValues();
                    break;
                case Examples.HashtableInitialization:
                    HashTableExample.ConstructorInitialization();
                    break;
                default:
                    break;
            }

            Console.Read();
        }
    }
}
