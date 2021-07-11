using System;

namespace Prototype
{
    public interface ICloneable<T>
    {
        T Clone();
    }
    public class MyObject : ICloneable<MyObject>
    {
        public int Count { get; set; } = 10;

        public MyObject Clone()
        {
            return (MyObject)MemberwiseClone();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            MyObject MyObject = new MyObject();
            Console.WriteLine($"MyObject = { MyObject.Count}");

            var instance1 = MyObject.Clone();
            instance1.Count++;
            Console.WriteLine($"Instance 1 = { instance1.Count}");

            var instance2 = MyObject.Clone();
            instance2.Count += 20;
            Console.WriteLine($"Instance 2 = { instance2.Count}");

            Console.WriteLine($"Instance 1 = { instance1.Count}");

            Console.ReadKey();
        }
    }
}
