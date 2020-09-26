using System;

namespace MH.Proxy
{
    public class LabDoor : IDoor
    {
        public void Open()
        {
            Console.WriteLine("Opening the lab door");
        }

        public void Close()
        {
            Console.WriteLine("Closing the lab door");
        }
    }
}