using System;

namespace Delegates.DelegatesExamples
{
    public static class LambdaExpressionDelegate
    {
        public static void ShowLambdaExpression()
        {
            //Используем лямбда выражение 
            //MultiplyDelegate multiplyDelegate = delegate (int t)
            //{
            //    return t * 2;
            //};
            MultiplyDelegate multiplyDelegate = t => t * 2;

            Console.WriteLine(multiplyDelegate(4));
        }



        delegate int MultiplyDelegate(int a);

        public static void AnonymousMethodVsLambda()
        {
            MultiplyDelegate multiplyDelegate;

            //Показываем как анонимный метод эволюционировал в лямбда выражение
            multiplyDelegate = delegate(int x) { return x * 2; };

            //Убираем delegate и тип параметра, т.к. сигнатура делегата уже подразумевает тип
            multiplyDelegate = (x) => { return x * 2; };

            //Убираем слово return и фигурные скобки, т.к. если выражение не полное 
            //и так подразумевается что должно стоять слово return
            multiplyDelegate = (x) => x * 2;

            //Если входящий параметр всего один - круглые скобки можно убрать
            multiplyDelegate = x => x * 2;

            Console.WriteLine(multiplyDelegate(6));
        }
    }
}
