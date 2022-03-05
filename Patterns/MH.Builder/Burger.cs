namespace MH.Builder;

public class Burger
{
    protected int Size;

    protected bool Cheese;
    protected bool Pepperoni;
    protected bool Lettuce;
    protected bool Tomato;

    public Burger(BurgerBuilder builder)
    {
        Size = builder.Size;
        Cheese = builder.Cheese;
        Pepperoni = builder.Pepperoni;
        Lettuce = builder.Lettuce;
        Tomato = builder.Tomato;
    }
}