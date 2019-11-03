namespace MH.Builder
{
    public class Burger
    {
        protected int size;

        protected bool cheese = false;
        protected bool pepperoni = false;
        protected bool lettuce = false;
        protected bool tomato = false;

        public Burger(BurgerBuilder builder)
        {
            this.size = builder.size;
            this.cheese = builder.cheese;
            this.pepperoni = builder.pepperoni;
            this.lettuce = builder.lettuce;
            this.tomato = builder.tomato;
        }
    }
}