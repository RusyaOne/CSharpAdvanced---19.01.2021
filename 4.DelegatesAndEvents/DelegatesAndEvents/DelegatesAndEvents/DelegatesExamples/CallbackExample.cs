using System;

namespace Delegates.DelegatesExamples
{
    public static class CallbackExample
    {
        public static void UseCallback()
        {
            Action<bool> sayCatchFrase = (isExplosionHappened) =>
                Console.WriteLine(isExplosionHappened ? "Art is an Explosion *-_(^_^)_-* " : "...");

            PerformExplosion(sayCatchFrase);
        }

        public static void PerformExplosion(Action<bool> actionAfterExplosion)
        {
            var isExplosionHappened = new Random().Next(1, 11) > 5;

            actionAfterExplosion(isExplosionHappened);
        }

        //Самостоятельно создайте два класса, в каждом по методу,
        //в методе одного и классов создайте экземпляр второго и вызовите метод второго класса
        //передайте в метод экземпляр Func<bool, string> 
        //который в зависимости от входящего значения bool должен возвращать "Mission complete" или "Mission failed"
        //выведите это значение в методе, который вызывает экзмепляр делегата Func<bool, string> 
    }
}