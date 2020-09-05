using System;

namespace MH.UsePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactory.Run();
            FactoryMethod.Run();
            AbstractFactory.Run();
            Builder.Run();
            Mediator.Run();
            Decorator.Run();

            Console.WriteLine(Environment.NewLine + "Press any key to exit ...");
            Console.ReadKey();
        }
    }
}