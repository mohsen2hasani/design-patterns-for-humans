using System;
using System.Collections.Generic;
using System.Text;

namespace MH.AbstractFactory
{
    public class Welder : IDoorFittingExpert
    {
        public void GetDescription()
        {
            Console.WriteLine("I can only fit iron doors");
        }
    }
}
