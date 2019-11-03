using System;
using System.Collections.Generic;
using System.Text;

namespace MH.AbstractFactory
{
    public interface IDoorFactory
    {
        IDoor MakeDoor();
        IDoorFittingExpert MakeFittingExpert();
    }
}