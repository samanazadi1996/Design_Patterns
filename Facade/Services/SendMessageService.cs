using System;

namespace Facade.Services
{
    public class SendMessageService
    {
        public void Send(string customer, string text)
        {
            Console.WriteLine($"The message \"{text}\" was sent to \"{customer}\"");
        }
    }
}
