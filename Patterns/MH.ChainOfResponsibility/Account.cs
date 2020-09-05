using System;

namespace MH.ChainOfResponsibility
{
    public class Account
    {
        public Account Successor { get; set; }
        public int Amount { get; set; }

        public Account(int amount)
        {
            Amount = amount;
        }

        public void SetNext(Account successor)
        {
            Successor = successor;
        }

        public void Pay(int amount)
        {
            if (CanPay(amount))
            {
                Console.WriteLine($"Paid {amount}, using {this.GetType().Name}");
            }
            else if (Successor != null)
            {
                Console.WriteLine($"Cannot pay using {this.GetType().Name}. Proceeding ...");
                Successor.Pay(amount);
            }
            else
            {
                throw new Exception("None of the accounts have enough balance");
            }
        }

        private bool CanPay(int amount)
        {
            return Amount >= amount;
        }
    }
}
