using System;
using System.Collections.Generic;
using System.Text;

namespace MH.SimpleFactory
{
    public class DoorFactory
    {
        public static IDoor MakeDoor(float width, float height)
        {
            return new WoodenDoor(width, height);
        }
    }
}