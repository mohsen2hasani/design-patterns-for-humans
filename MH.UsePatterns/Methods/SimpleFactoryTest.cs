using System;
using System.Collections.Generic;
using System.Text;
using MH.SimpleFactory;

namespace MH.UsePatterns.Methods
{
    public static class SimpleFactoryTest
    {
        public static void Run()
        {
            Console.WriteLine("=-=-=-=SimpleFactory=-=-=-=");
            Console.WriteLine("Make me a door of 100x200");
            var door = DoorFactory.MakeDoor(100, 200);

            Console.WriteLine($"door - Width: {door.GetWidth()}");
            Console.WriteLine($"door - Height: {door.GetHeight()}");

            Console.WriteLine();

            Console.WriteLine("Make me a door of 50x100");
            var door2 = DoorFactory.MakeDoor(50, 100);

            Console.WriteLine($"door2 - Width: {door2.GetWidth()}");
            Console.WriteLine($"door2 - Height: {door2.GetHeight()}");

            Console.WriteLine("----------------------------------" + Environment.NewLine);
        }
    }
}