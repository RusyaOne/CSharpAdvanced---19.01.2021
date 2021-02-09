using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.IoExamples
{
    public static class FileInfoExamples
    {
        public static void ShowFileInfo()
        {
            var fileInfo = new FileInfo(@"D:\Lesson9Example\ShowFileInfo.txt");

            if (!fileInfo.Exists)
            {
                fileInfo.Create();
                Console.WriteLine($"File {fileInfo.FullName} was successfully created");
            }
            else
                Console.WriteLine(fileInfo.FullName);
        }


        public static void ShowFilesInfo()
        {
            var directory = new DirectoryInfo(@"D:\Lesson9Example");

            if (directory.Exists)
            {
                // Получаем все файлы с расширением .txt.
                FileInfo[] files = directory.GetFiles("*.txt");

                Console.WriteLine($"There are {files.Length} *.txt files\n");

                // Выводим информацию о каждом файле.
                foreach (FileInfo file in files)
                {
                    Console.WriteLine($"File name : {file.Name}");
                    Console.WriteLine($"File size : {file.Length}");
                    Console.WriteLine($"Creation  : {file.CreationTime}");
                    Console.WriteLine($"Attributes: {file.Attributes.ToString()}");
                }
            }
            else
            {
                directory.Create(); 
                Console.WriteLine($"Directory {directory.FullName} was created.");
            }
        }

        //Создайте обьект FileInfo для несуществующего файла, создайте этот файл из кода
        //Создайте еще один обьект FileInfo для того же файла, выведите их полные имена в консоль

        public static void DeleteFile()
        {
            var file = new FileInfo(@"D:\Lesson9Example\ShowFileInfo.txt");

            file.Delete();

            Console.WriteLine("File was deleted");
        }

        public static void DeleteAnyFile()
        {
            File.Delete(@"D:\Lesson9Example\ShowFileInfo.txt"); 

            Console.WriteLine("File was deleted");
        }

        //Удалите файл который вы создали
    }
}
