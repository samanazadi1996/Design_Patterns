using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class IceCream
    {
        public abstract string GetName();
        public abstract double GetPrice();
    }
    public class LargeIceCream : IceCream
    {
        public override string GetName()
        {
            return "Large Ice Cream";
        }

        public override double GetPrice()
        {
            return 2000;
        }
    }
    public class MediumIceCream : IceCream
    {
        public override string GetName()
        {
            return "Medium Ice Cream";
        }

        public override double GetPrice()
        {
            return 1500;
        }
    }
    public class SmallIceCream : IceCream
    {
        public override string GetName()
        {
            return "Small Ice Cream";
        }

        public override double GetPrice()
        {
            return 1000;
        }
    }
}
