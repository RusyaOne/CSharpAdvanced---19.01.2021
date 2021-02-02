using System;

namespace Events.EventsExamples
{
    //Event subscriber
    public static class BasicSyntaxEvent
    {
        public static void ShowEvent()
        {
            //Создаем экземпляр класса издателя события
            MessageSender publisher = new MessageSender();
            
            //Создаем экземпляр делегата
            EventDelegate eventDelegate = new EventDelegate(SendMessageHandler);

            //Подписываемся на событие с помощью "+="
            publisher.ShowMessageEvent += eventDelegate;

            //Используем метод издателя для вызова события
            publisher.InvokeEvent("Event is invoked!");
        }

        //Обьявляем метод-обработчик события
        //Методы-обработчики события часто имеют в своем названии суфикс Handler
        private static void SendMessageHandler(string a)
        {
            Console.WriteLine($"Message body: {a}");
        }
    }
}
