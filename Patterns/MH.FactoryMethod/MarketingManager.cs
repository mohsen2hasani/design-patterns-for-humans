using System;
using System.Collections.Generic;
using System.Text;

namespace MH.FactoryMethod
{
    public class MarketingManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}