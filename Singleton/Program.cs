using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton Design Patterns");

            var settings = Settings.GetInstance();

            settings.Key = "test";
            settings.Value = "test";

            Write();

            Console.ReadKey();
        }
        static void Write()
        {
            var settings = Settings.GetInstance();

            Console.WriteLine($"key : {settings.Key}   -->  Value : {settings.Value} ");
        }
    }
}
