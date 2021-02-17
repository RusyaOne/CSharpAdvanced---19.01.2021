using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.IoExamples
{
    public static class StreamReaderExample
    {
        public static void ShowStreamReader()
        {
            var file = new FileInfo(@"D:\Courses\CSharpAdvanced - 19.01.2021\9.IO\IO\Lesson9Example\ShowFileInfo.txt");

            using (StreamReader reader = file.OpenText())
            {
                string input;
                while ((input = reader.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}
