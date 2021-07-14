using Adapter.Adapters;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iprinter printer = new PrintToFile();
            //Iprinter printer = new ObjectAdapter();
            Iprinter printer = new InheritanceAdapter();
            printer.Print("Hello World");
            Console.ReadKey();
        }
    }
}
