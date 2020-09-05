using System;
using MH.UsePatterns.Methods;

namespace MH.UsePatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactoryTest.Run();
            FactoryMethodTest.Run();
            AbstractFactoryTest.Run();
            BuilderTest.Run();
            MediatorTest.Run();
            DecoratorTest.Run();
            ChainOfResponsibilityTest.Run();


            Console.WriteLine(Environment.NewLine + "Press any key to exit ...");
            Console.ReadKey();
        }
    }
}