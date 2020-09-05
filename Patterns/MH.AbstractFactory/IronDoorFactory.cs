using System;
using System.Collections.Generic;
using System.Text;

namespace MH.AbstractFactory
{
    public class IronDoorFactory : IDoorFactory
    {
        public IDoor MakeDoor()
        {
            return new IronDoor();
        }

        public IDoorFittingExpert MakeFittingExpert()
        {
            return new Welder();
        }
    }
}