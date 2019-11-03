using System;
using System.Collections.Generic;
using System.Text;

namespace MH.FactoryMethod
{
    public class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine("Asking about design patterns!");
        }
    }
}