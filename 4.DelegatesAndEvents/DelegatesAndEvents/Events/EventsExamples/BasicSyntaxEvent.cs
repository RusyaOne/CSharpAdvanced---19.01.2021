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



    //Делегат можно обьявлять вне класса
    //Делегат определяет сигнатуру метода подписчика
    public delegate void EventDelegate(string a);

    //Event publisher
    public class MessageSender
    {
        //Событие можно обьявлять только в нестатическом классе
        public event EventDelegate ShowMessageEvent;

        public void InvokeEvent(string a)
        {
            //Делаем проверку что у события есть подписчик
            //и вызываем событие

            ShowMessageEvent?.Invoke(a);

            //ShowMessageEvent(a);

            //if (ShowMessageEvent != null)
            //{
            //    ShowMessageEvent(a);
            //}
        }
    }
}
