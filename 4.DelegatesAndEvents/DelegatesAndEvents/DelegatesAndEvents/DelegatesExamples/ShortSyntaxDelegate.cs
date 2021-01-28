using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DelegatesExamples
{
    public static class ShortSyntaxDelegate
    {
        delegate void MessageDelegate();

        public static void ShowMessage()
        {
            Console.WriteLine("This is delegate with short syntax");
        }

        public static void ShowShortSyntax()
        {
            //Вместо явного создания экземпляра делегата мы присваиваем ссылку на метод переменной делегата
            //MessageDelegate messageDelegate = new MessageDelegate(ShowMessage); 
            MessageDelegate messageDelegate = ShowMessage;

            //Также мы можем упустить метод Invoke и вызвать метод, на который указывает делегат, следующим образом:
            messageDelegate();
        }
    }
}
