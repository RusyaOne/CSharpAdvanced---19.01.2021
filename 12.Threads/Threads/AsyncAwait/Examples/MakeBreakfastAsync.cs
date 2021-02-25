using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait.Examples
{
    public static class MakeBreakfastAsync
    {
        public static void MakeBreakfast()
        {
            Stopwatch timer = new Stopwatch();

            timer.Start();

            var cookOatmealTask = CookOatmeal();
            var boilEggsTask = BoilEggs();
            var makeSaladTask = MakeSalad();

            while (!cookOatmealTask.IsCompleted || !boilEggsTask.IsCompleted || !makeSaladTask.IsCompleted)
                Thread.Sleep(TimeSpan.FromSeconds(1));

            timer.Stop();
            Console.WriteLine($"Elapsed seconds: {timer.ElapsedMilliseconds/1000}");
        }

        private static async Task CookOatmeal()
        {
            await Task.Delay(TimeSpan.FromSeconds(20));
            Console.WriteLine("Oatmeal is ready");
        }


        private static async Task BoilEggs()
        {
            await Task.Delay(TimeSpan.FromSeconds(7));
            Console.WriteLine("Eggs are ready");
        }

        private static async Task MakeSalad()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("Salad is ready");
        }
    }
}