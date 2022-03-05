using MH.Decorator;
using System;

namespace MH.UsePatterns.Methods;

public static class DecoratorTest
{
    public static void Run()
    {
        Console.WriteLine("=-=-=-=Decorator=-=-=-=");

        var pizza = new Pizza();
        Console.WriteLine($"Pizza price: {pizza.Price}");

        var moreCheese = new MoreCheese(pizza);
        Console.WriteLine($"+More cheese: {moreCheese.Price}");

        var moreSauce = new MoreSauce(moreCheese);
        Console.WriteLine($"+More sauce: {moreSauce.Price}");

        Console.WriteLine("----------------------------------" + Environment.NewLine);
    }
}