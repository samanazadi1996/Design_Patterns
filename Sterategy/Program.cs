using System;

namespace Sterategy
{

    class Program
    {
        static void Main(string[] args)
        {
            Calculate nullCalcutor = new NullCalcutor();
            Console.WriteLine($"Ordinary customer final amount = {nullCalcutor.GetPrice(1000)}");

            Calculate goldCalculator = new GoldCalculator();
            Console.WriteLine($"The final amount of Golden Customer is 20% discount = {goldCalculator.GetPrice(1000)}");

            Calculate silverCalculator = new SilverCalculator();
            Console.WriteLine($"The final amount of Silver Customer is 10% discount = {silverCalculator.GetPrice(1000)}");

            Console.ReadKey();
        }
    }
}
