using System;
using System.Collections.Generic;
using System.Text;
using MH.FactoryMethod;

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