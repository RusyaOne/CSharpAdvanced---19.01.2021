using System;

namespace Delegates.DelegatesExamples
{
    public static class BuildInDelegates
    {
        public static void ShowActionDelegate()
        {
            void DestroyEarth() =>
                Console.WriteLine("We are DOOOOOOOOOOOMED!!!");

            Action actionDelegate = new Action(DestroyEarth);
            //Action actionDelegate = () => Console.WriteLine("We are DOOOOOOOOOOOMED!!!");

            actionDelegate();
        }

        public static void ShowGenericActionDelegate()
        {
            void DestroyPlanet(string planet) =>
                Console.WriteLine($"Message from {planet}: We are DOOOOOOOOOOOMED!!!");

            Action<string> actionDelegate = new Action<string>(DestroyPlanet);
            //Action actionDelegate = (planet) => Console.WriteLine($"Message from {planet}: We are DOOOOOOOOOOOMED!!!");

            actionDelegate("Solaria");
        }

        public static void ShowFunctionDelegate()
        {
            long DestroyPlanet(string planet) =>
                planet.Equals("Solaria") ? 20000 : 8000000000;

            Func<string, long> funcDelegate = new Func<string, long>(DestroyPlanet);
            //Func<string, long> funcDelegate = (planet) => planet.Equals("Solaria") ? 20000 : 8000000000;
            
            long deadInhabitantsCount = funcDelegate("Earth");
            Console.WriteLine($"There are {deadInhabitantsCount} inhabitants were killed :(");
        }

        public static void ShowPredicateDelegate()
        {
            bool TryDestroyPlanet(string planet) =>
                planet.Equals("Solaria") ? true : false;

            Predicate<string> predicateDelegate = new Predicate<string>(TryDestroyPlanet);
            //Predicate<string> funcDelegate = (planet) => planet.Equals("Solaria") ? true : false;

            bool isPlanetDestroyed = predicateDelegate("Solaria");
            Console.WriteLine("Is planet destroyed? - " + (isPlanetDestroyed ? "Yes" : "No"));
        }
    }
}
