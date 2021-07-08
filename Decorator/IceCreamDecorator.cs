using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class IceCreamDecorator : IceCream
    {
        private readonly IceCream iceCream;

        public IceCreamDecorator(IceCream iceCream)
        {
            this.iceCream = iceCream;
        }

        public override string GetName()
        {
            return iceCream.GetName();
        }

        public override double GetPrice()
        {
            return iceCream.GetPrice();
        }
    }

    public class IceCreamWithChocolate : IceCreamDecorator
    {
        public IceCreamWithChocolate(IceCream iceCream) : base(iceCream)
        {
        }

        public override string GetName()
        {
            return $"{base.GetName()} with chocolate";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + (base.GetPrice() * 0.2);
        }
    }
    public class IceCreamWithSmarties : IceCreamDecorator
    {
        public IceCreamWithSmarties(IceCream iceCream) : base(iceCream)
        {
        }

        public override string GetName()
        {
            return $"{base.GetName()} with smarties";
        }
        public override double GetPrice()
        {
            return base.GetPrice() + (base.GetPrice() * 0.3);
        }
    }
}
