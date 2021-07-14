using System;

namespace Adapter.Adapters
{
    public class PrintToScreen
    {
        public void PrintText(string input)
        {
            Console.WriteLine(input);
        }
    }
}
