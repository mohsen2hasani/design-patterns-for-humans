using System;
using System.Collections.Generic;
using System.Text;

namespace MH.AbstractFactory
{
    public class WoodenDoor : IDoor
    {
        public void GetDescription()
        {
            Console.WriteLine("I am a wooden door");
        }
    }
}
