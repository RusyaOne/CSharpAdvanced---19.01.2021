using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.IoExamples
{
    public static class MemoryStreamExample
    {
        public static void ShowMemoryStream()
        {
            //MemoryStream хранит данные в памяти
            using (var memory = new MemoryStream())
            {
                for (var i = 0; i < 10; i++)
                {
                    memory.WriteByte((byte)i);
                }

                memory.Position = 0;

                for (int i = 0; i < 20; i++)
                {
                    Console.Write(" " + memory.ReadByte());
                }
            }
        }
    }
}
