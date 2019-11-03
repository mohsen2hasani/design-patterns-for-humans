using System;
using System.Collections.Generic;
using System.Text;

namespace MH.FactoryMethod
{
    public class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about community building");
        }
    }
}