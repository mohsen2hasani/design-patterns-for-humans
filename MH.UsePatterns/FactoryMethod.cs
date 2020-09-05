using MH.FactoryMethod;
using System;

namespace MH.UsePatterns
{
    public static class FactoryMethod
    {
        public static void Run()
        {
            Console.WriteLine("=-=-=-=FactoryMethod=-=-=-=");
            Console.WriteLine("DevelopmentManager");
            var devManager = new DevelopmentManager();
            devManager.TakeInterview();

            Console.WriteLine();
            Console.WriteLine("MarketingManager");
            var marketingManager = new MarketingManager();
            marketingManager.TakeInterview();

            Console.WriteLine("----------------------------------" + Environment.NewLine);
        }
    }
}