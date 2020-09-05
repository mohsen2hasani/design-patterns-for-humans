using MH.ChainOfResponsibility;
using System;

namespace MH.UsePatterns.Methods
{
    public static class ChainOfResponsibilityTest
    {
        public static void Run()
        {
            Console.WriteLine("=-=-=-=ChainOfResponsibility=-=-=-=");

            var bank = new Bank(100);          // Bank with balance 100
            var paypal = new Paypal(200);      // Paypal with balance 200
            var bitcoin = new Bitcoin(300);    // Bitcoin with balance 300

            bank.SetNext(paypal);
            paypal.SetNext(bitcoin);

            // Let's try to pay using the first priority i.e. bank
            bank.Pay(259);

            Console.WriteLine("----------------------------------" + Environment.NewLine);
        }
    }
}