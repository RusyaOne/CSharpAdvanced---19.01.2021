using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.IoExamples
{
    public static class FileStreamExample
    {
        public static void ShowFileStream()
        {
            //FileStream хранит данные в файле
            // Создаем файл в текущем каталоге.
            using (var stream = new FileStream("Test.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                for (int i = 0; i < 10; i++)
                    stream.WriteByte((byte)i);

                //т.к. FileStream создан для работы с байтами 
                //у такого потока есть каретка (внутренний укзатель позиции), которая находится в месте последней операции
                //и которая двигается на одну позицию вперед при выполнении операции
                Console.WriteLine(stream.Position);

                //Ставим каретку в начальную позицию
                //stream.Position = 0;

                for (int i = 0; i < 20; i++)                
                    Console.Write(" " + stream.ReadByte());
            }
        }
    }
}
