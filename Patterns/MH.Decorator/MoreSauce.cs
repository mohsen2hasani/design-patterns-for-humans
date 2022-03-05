namespace MH.Decorator
{
    public class MoreSauce : IFastFood
    {
        public readonly IFastFood FastFood;
        public MoreSauce(IFastFood fastFood)
        {
            FastFood = fastFood;
        }

        public double Price => FastFood.Price + 0.1;
    }
}