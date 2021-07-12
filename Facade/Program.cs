using Facade.Services;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new FacadePattern();
            facade.SendMessage("1234567890");

            Console.ReadKey();
        }
    }
}
