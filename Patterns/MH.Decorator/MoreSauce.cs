namespace MH.Decorator
{
    public class MoreSauce : IFastFood
    {
        IFastFood _fastFood;
        public MoreSauce(IFastFood fastFood)
        {
            _fastFood = fastFood;
        }

        public double Price => _fastFood.Price + 0.1;
    }
}