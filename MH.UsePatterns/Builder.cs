using MH.Builder;
using System;

namespace MH.UsePatterns
{
    public static class Builder
    {
        public static void Run()
        {
            Console.WriteLine("=-=-=-=Builder=-=-=-=");

            Console.WriteLine("BurgerBuilder");
            _ = new BurgerBuilder(14)
                     .AddPepperoni()
                     .AddLettuce()
                     .AddTomato()
                     .Build();

            Console.WriteLine("Burger: size 14, with pepperoni, lettuce and tomatos");
            Console.WriteLine("----------------------------------" + Environment.NewLine);
        }
    }
}