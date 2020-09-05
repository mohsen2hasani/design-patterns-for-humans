using MH.AbstractFactory;
using System;

namespace MH.UsePatterns.Methods
{
    public static class AbstractFactoryTest
    {
        public static void Run()
        {
            Console.WriteLine("=-=-=-=AbstractFactory=-=-=-=");

            Console.WriteLine("WoodenDoorFactory");
            var woodenFactory = new WoodenDoorFactory();

            var door = woodenFactory.MakeDoor();
            var expert = woodenFactory.MakeFittingExpert();

            door.GetDescription();  // Output: I am a wooden door
            expert.GetDescription(); // Output: I can only fit wooden doors

            Console.WriteLine(Environment.NewLine + "IronDoorFactory");
            var ironFactory = new IronDoorFactory();

            door = ironFactory.MakeDoor();
            expert = ironFactory.MakeFittingExpert();

            door.GetDescription();  // Output: I am an iron door
            expert.GetDescription(); // Output: I can only fit iron doors

            Console.WriteLine("----------------------------------" + Environment.NewLine);
        }
    }
}