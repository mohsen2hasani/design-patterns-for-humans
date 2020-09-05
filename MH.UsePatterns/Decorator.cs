using MH.Decorator;
using System;

namespace MH.UsePatterns
{
    public static class Decorator
    {
        public static void Run()
        {
            Console.WriteLine("=-=-=-=Decorator=-=-=-=");

            Pizza pizza = new Pizza();
            Console.WriteLine($"Pizza priec: {pizza.Price}");

            MoreCheese moreCheese = new MoreCheese(pizza);
            Console.WriteLine($"+More cheese: {moreCheese.Price}");

            MoreSauce moreSauce = new MoreSauce(moreCheese);
            Console.WriteLine($"+More sauce: {moreSauce.Price}");

            Console.WriteLine("----------------------------------" + Environment.NewLine);
        }
    }
}