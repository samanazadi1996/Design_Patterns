using Iterator.Collection;
using Iterator.Stack;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

            PersonCollection personCollection = new PersonCollection();
            personCollection[0] = new Person
            {
                FirstName = "Collection FirstName 1",
                LastName = " Collection LastName 1"
            };
            personCollection[1] = new Person
            {
                FirstName = "Collection FirstName 2",
                LastName = "Collection LastName 2"
            };
            var enumeratro1 = personCollection.GetEnumerator();
            while (enumeratro1.MoveNext() != null)
            {
                Console.WriteLine(enumeratro1.Curent.FirstName);
            }

            PersonStack personStack = new PersonStack();
            personStack[0] = new Person
            {
                FirstName = "Stack FirstName 1",
                LastName = "Stack LastName 1"
            };
            personStack[1] = new Person
            {
                FirstName = "Stack FirstName 2",
                LastName = "Stack LastName 2"
            };

            var enumeratro2 = personStack.GetEnumerator();
            while (enumeratro2.MoveNext() != null)
            {
                Console.WriteLine(enumeratro2.Curent.FirstName);
            }

            Console.ReadKey();
        }
    }
}
