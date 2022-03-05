using System;

namespace MH.AbstractFactory;

public class IronDoor : IDoor
{
    public void GetDescription()
    {
        Console.WriteLine("I am an iron door");
    }
}