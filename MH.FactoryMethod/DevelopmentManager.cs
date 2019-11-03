using System;
using System.Collections.Generic;
using System.Text;

namespace MH.FactoryMethod
{
    public class DevelopmentManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }
    }
}