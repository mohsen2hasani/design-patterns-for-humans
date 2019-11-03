using System;
using System.Collections.Generic;
using System.Text;

namespace MH.AbstractFactory
{
    public class Carpenter : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit wooden doors");
        }
    }
}
