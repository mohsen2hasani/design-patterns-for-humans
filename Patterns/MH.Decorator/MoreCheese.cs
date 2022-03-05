namespace MH.Decorator
{
    public class MoreCheese : IFastFood
    {
        public readonly IFastFood FastFood;
        public MoreCheese(IFastFood fastFood)
        {
            FastFood = fastFood;
        }

        public double Price => FastFood.Price + 0.3;
    }
}