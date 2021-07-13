namespace Sterategy
{
    public abstract class Calculate
    {
        public abstract int GetPrice(int price);
    }
    public class SilverCalculator : Calculate
    {
        public override int GetPrice(int price)
        {
            return (int)(price - (price * 0.1));
        }
    }
    public class GoldCalculator : Calculate
    {
        public override int GetPrice(int price)
        {
            return (int)(price - (price * 0.2));
        }
    }

    public class NullCalcutor : Calculate
    {
        public override int GetPrice(int price)
        {
            return price;
        }
    }

}
