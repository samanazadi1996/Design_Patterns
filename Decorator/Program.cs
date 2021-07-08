using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCream largeIceCream = new LargeIceCream();
            IceCream mediumIceCream = new MediumIceCream();
            IceCream smallIceCream = new SmallIceCream();

            Console.WriteLine($"{largeIceCream.GetName()} = {largeIceCream.GetPrice()}");
            Console.WriteLine($"{mediumIceCream.GetName()} = {mediumIceCream.GetPrice()}");
            Console.WriteLine($"{smallIceCream.GetName()} = {smallIceCream.GetPrice()}");

            IceCreamDecorator largeIceCreamWithChocolate = new IceCreamWithChocolate(largeIceCream);
            Console.WriteLine($"{largeIceCreamWithChocolate.GetName()} = {largeIceCreamWithChocolate.GetPrice()}");

            IceCreamDecorator smallIceCreamWithChocolate = new IceCreamWithChocolate(smallIceCream);
            Console.WriteLine($"{smallIceCreamWithChocolate.GetName()} = {smallIceCreamWithChocolate.GetPrice()}");

            IceCreamDecorator smallIceCreamWithSmarties = new IceCreamWithSmarties(smallIceCream);
            Console.WriteLine($"{smallIceCreamWithSmarties.GetName()} = {smallIceCreamWithSmarties.GetPrice()}");

            IceCreamDecorator smallIceCreamWithChocolatewithSmarties = new IceCreamWithChocolate(smallIceCreamWithSmarties);
            Console.WriteLine($"{smallIceCreamWithChocolatewithSmarties.GetName()} = {smallIceCreamWithChocolatewithSmarties.GetPrice()}");

            IceCreamDecorator largeIceCreamWithChocolatewithSmarties = new IceCreamWithSmarties(largeIceCreamWithChocolate);
            Console.WriteLine($"{largeIceCreamWithChocolatewithSmarties.GetName()} = {largeIceCreamWithChocolatewithSmarties.GetPrice()}");

            Console.ReadKey();
        }
    }
}
