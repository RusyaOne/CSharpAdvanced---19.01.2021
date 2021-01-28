using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.EventsExamples
{
    public static class ShortSyntaxEvent
    {
        public static void ShowShortSyntaxEvent()
        {
            MessageSender sender = new MessageSender();

            //Можно упустить создание экземпляра делегата и подписаться на событие методом
            //Подразумевается что делегат присутсвует, т.к. сигнатура метода совпадает с сигнатурой делегата

            sender.ShowMessageEvent += SendMessageHandler;

            sender.InvokeEvent("Short syntax");
        }

        private static void SendMessageHandler(string message)
        {
            Console.WriteLine($"Message body: {message}");
        }
    }
}