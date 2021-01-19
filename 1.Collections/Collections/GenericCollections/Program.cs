using GenericCollections.GenericCollectionExamples;
using System;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = Examples.DictionaryCompileTimeError;

            switch (exampleToRun)
            {
                case Examples.ListShow:
                    ListExample.ShowList();
                    break;
                case Examples.ListCompileTimeError:
                    ListExample.CompileTimeError();
                    break;
                case Examples.LinkedListShow:
                    LinkedListExample.ShowLinkedList();
                    break;
                case Examples.LinkedListRemoveNode:
                    LinkedListExample.RemoveNode();
                    break;
                case Examples.GenericStackShow:
                    GenericStackExample.ShowGenericStack();
                    break;
                case Examples.GenericStackCompileTimeError:
                    GenericStackExample.CompileTimeError();
                    break;
                case Examples.GenericQueueShow:
                    GenericQueueExample.ShowGenericQueue();
                    break;
                case Examples.GenericQueueCompileTimeError:
                    GenericQueueExample.CompileTimeError();
                    break;
                case Examples.DictionaryShow:
                    DictionaryExample.ShowDictionary();
                    break;
                case Examples.DictionaryCompileTimeError:
                    DictionaryExample.CompileTimeError();
                    break;
                case Examples.HashSetShow:
                    HashSetExample.ShowHashSet();
                    break;
                case Examples.HashSetContainsRemove:
                    HashSetExample.ContainsAndRemove();
                    break;
                case Examples.HashSetUnion:
                    HashSetExample.UnionSets();
                    break;
                case Examples.HashSetExcept:
                    HashSetExample.ExceptSets();
                    break;
                case Examples.HashSetIntersect:
                    HashSetExample.IntersectSets();
                    break;
                default:
                    break;
            }

            Console.Read();
        }
    }
}
