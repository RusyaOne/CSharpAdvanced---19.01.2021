using System;

namespace Events.EventsExamples
{
    public static class EvenShorterSyntaxEvent
    {
        public static void ShowEvent()
        {
            MessageSender sender = new MessageSender();

            sender.ShowMessageEvent += message => Console.WriteLine($"Message body: {message}");

            sender.InvokeEvent("Short syntax");
        }

        //private static void SendMessageHandler(string message)
        //{
        //    Console.WriteLine($"Message body: {message}");
        //}
    }
}