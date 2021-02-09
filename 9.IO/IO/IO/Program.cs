using IO.IoExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.StreamReader;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.DirectoryInfo:
                    DirectoryInfoExamples.ShowDirectoryInfo();
                    break;
                case ExamplesEnumeration.CreateSubdirectory:
                    DirectoryInfoExamples.CreateSubdirectory();
                    break;
                case ExamplesEnumeration.DeleteDirectory:
                    DirectoryInfoExamples.DeleteDirectory();
                    break;
                case ExamplesEnumeration.DeleteAnyDirectory:
                    DirectoryInfoExamples.DeleteAnyDirectory();
                    break;
                case ExamplesEnumeration.FileInfo:
                    FileInfoExamples.ShowFileInfo();
                    break;
                case ExamplesEnumeration.FilesInfo:
                    FileInfoExamples.ShowFilesInfo();
                    break;
                case ExamplesEnumeration.DeleteFile:
                    FileInfoExamples.DeleteFile();
                    break;
                case ExamplesEnumeration.DeleteAnyFile:
                    FileInfoExamples.DeleteAnyFile();
                    break;
                case ExamplesEnumeration.FileStream:
                    FileStreamExample.ShowFileStream();
                    break;
                case ExamplesEnumeration.MemoryStream:
                    MemoryStreamExample.ShowMemoryStream();
                    break;
                case ExamplesEnumeration.StreamWriter:
                    StreamWriterExample.ShowStreamWriter();
                    break;
                case ExamplesEnumeration.StreamReader:
                    StreamReaderExample.ShowStreamReader();
                    break;
            }

            Console.Read();
        }
    }
}
