using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.IoExamples
{
    public static class DirectoryInfoExamples
    {
        public static void ShowDirectoryInfo()
        {
            var directory = new DirectoryInfo(@"D:\Lesson9Example\ShowDirectoryInfo");

            if (directory.Exists) 
            {
                Console.WriteLine($"FullName      : {directory.FullName}");              // Полное Имя директории, (включая путь).
                Console.WriteLine($"Name          : {directory.Name}");                  // Имя директории, (НЕ включая путь).
                Console.WriteLine($"Parent        : {directory.Parent}");                // Родительская директория. 
                Console.WriteLine($"CreationTime  : {directory.CreationTime}");          // Время создания директории.
                Console.WriteLine($"Attributes    : {directory.Attributes.ToString()}"); // Аттрибуты.
                Console.WriteLine($"Root          : {directory.Root}");                  // Корневой диск, на котором находится директория.
                Console.WriteLine($"LastAccessTime: {directory.LastAccessTime}");        // Время последнего доступа к директории.
                Console.WriteLine($"LastWriteTime : {directory.LastWriteTime}");         // Время последнего изменения файлов в директории.                 
            }
            else
            {
                directory.Create(); //Если директории не существует - создаем новую 
                Console.WriteLine($"Directory {directory.FullName} was created." );
            }
        }

        //Создайте экземпляр обьекта DirectoryInfo для несуществующей директории 
        //создайте саму директорию из кода и выведите ее полное имя 

        public static void CreateSubdirectory()
        {
            var directory = new DirectoryInfo(@"D:\Lesson9Example\ShowDirectoryInfo");

            if (directory.Exists)
            {
                //Создание подкаталога
                directory.CreateSubdirectory("SubDirectory");

                //Рекурсивное создание подкаталога
                directory.CreateSubdirectory(@"Recursive\SubDirectory");

                Console.WriteLine("Directories are created");
            }
        }

        public static void DeleteDirectory()
        {
            var directory = new DirectoryInfo(@"D:\Lesson9Example\ShowDirectoryInfo");

            if (directory.Exists)
            {
                //Удаление каталога
                //try
                //{
                //    directory.Delete();
                //}
                //catch (Exception e)
                //{
                //    Console.WriteLine(e);
                //}

                //Удаление каталога рекурсивно
                directory.Delete(true);

                Console.WriteLine("Directories are deleted");
            }
        }

        public static void DeleteAnyDirectory()
        {
            //Рекурсивно удаляем каталог
            Directory.Delete(@"D:\Lesson9Example", true);

            Console.WriteLine("Directories are deleted");            
        }
    }
}
