using MH.Builder;
using System;

namespace MH.UsePatterns.Methods;

public static class BuilderTest
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

        Console.WriteLine("Burger: size 14, with pepperoni, lettuce and tomatoes");
        Console.WriteLine("----------------------------------" + Environment.NewLine);
    }
}