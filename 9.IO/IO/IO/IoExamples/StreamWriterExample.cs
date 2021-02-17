using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.IoExamples
{
    class StreamWriterExample
    {
        public static void ShowStreamWriter()
        {
            var file = new FileInfo(@"D:\Courses\CSharpAdvanced - 19.01.2021\9.IO\IO\Lesson9Example\ShowFileInfo.txt");

            using (StreamWriter writer = file.CreateText())
            {
                writer.WriteLine("ExampleLine1");
                writer.WriteLine("ExampleLine2" + writer.NewLine);
                writer.WriteLine("ExampleLine3");

                Console.WriteLine("Lines are written to the file");
            }            
        }
    }
}

