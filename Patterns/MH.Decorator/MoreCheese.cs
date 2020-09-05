namespace MH.Decorator
{
    public class MoreCheese : IFastFood
    {
        IFastFood _fastFood;
        public MoreCheese(IFastFood fastFood)
        {
            _fastFood = fastFood;
        }

        public double Price => _fastFood.Price + 0.3;
    }
}