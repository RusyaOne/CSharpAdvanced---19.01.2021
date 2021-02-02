using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.EventsExamples
{
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
