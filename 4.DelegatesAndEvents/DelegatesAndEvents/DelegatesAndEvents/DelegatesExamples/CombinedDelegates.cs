using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DelegatesExamples
{
    public static class CombinedDelegates
    {
        delegate void CombinedDelegate();

        public static void ShowCombinedDelegate()
        {
            //Создаем несколько экземпляров делегата типа CombinedDelegate
            CombinedDelegate countDelegateOne = CountToOne;
            CombinedDelegate countDelegateTwo = CountToTwo;
            CombinedDelegate countDelegateThree = CountToThree;

            //Комбинируем ссылки соданных делегатов на одном скомбинированом делегате
            CombinedDelegate combinedDelegate = countDelegateOne + countDelegateTwo + countDelegateThree;

            Console.WriteLine("Enter number from 1 to 5:");
            string variantToRun = string.Empty;

            while (variantToRun != "exit")
            {
                variantToRun = Console.ReadLine();
                switch (variantToRun)
                {
                    case "1":
                        countDelegateOne();
                        break;
                    case "2":
                        countDelegateTwo();
                        break;
                    case "3":
                        combinedDelegate();
                        break;
                    case "4":
                        CombinedDelegate combinedDelegateOneThree = combinedDelegate - countDelegateTwo;
                        combinedDelegateOneThree();
                        break;
                    case "5":
                        CombinedDelegate combinedDelegateTwoThree = combinedDelegate - countDelegateOne;
                        combinedDelegateTwoThree();
                        break;
                    default:
                        variantToRun = "exit";
                        break;
                }
            }
        }

        public static void CountToOne() =>        
            Console.WriteLine("CountToOne");

        public static void CountToTwo() =>
            Console.WriteLine("CountToTwo");

        public static void CountToThree() =>
            Console.WriteLine("CountToThree");
    }
}
