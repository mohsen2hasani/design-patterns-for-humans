namespace MH.ChainOfResponsibility
{
    public class Bank : Account
    {
        public Bank(int amount) : base(amount)
        {
        }
    }

    public class Paypal : Account
    {
        public Paypal(int amount) : base(amount)
        {
        }
    }

    public class Bitcoin : Account
    {
        public Bitcoin(int amount) : base(amount)
        {
        }
    }
}