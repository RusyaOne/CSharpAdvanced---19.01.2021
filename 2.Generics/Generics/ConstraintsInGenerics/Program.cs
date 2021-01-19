using System;
using ConstraintsInGenerics.ConstraintsExamples;
using ConstraintsInGenerics.ConstraintsExamples.HelpMaterial;

namespace ConstraintsInGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.InterfaceConstraint;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.StandartConstaint:
                    Account<int> account = new Account<int>(5);
                    account.ShowSum();
                    break;
                case ExamplesEnumeration.CustomConstraint:
                    //AdvancedSum sum = new AdvancedSum() { Quantity = 5, Currency = "eur" };
                    CustomSum sum = new CustomSum(){ Quantity = 5};
                    CustomAccount<CustomSum> customAccount = new CustomAccount<CustomSum>(sum);
                    customAccount.ShowSum();
                    break;
                case ExamplesEnumeration.InterfaceConstraint:
                    //SpecialSum specialSum = new SpecialSum() { Quantity = 5.2 };
                    CustomSum specialSum = new CustomSum() { Quantity = 5 };
                    InterfaceAccount<CustomSum, int> interfaceAccount = new InterfaceAccount<CustomSum, int>(specialSum);
                    interfaceAccount.ShowData();
                    break;
            }

            Console.Read();
        }
    }
}
