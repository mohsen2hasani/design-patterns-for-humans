using System;
using System.Collections.Generic;
using System.Text;

namespace MH.FactoryMethod
{
    public abstract class HiringManager
    {
        abstract protected IInterviewer MakeInterviewer();

        public void TakeInterview()
        {
            var interviewer = this.MakeInterviewer();
            interviewer.AskQuestions();
        }
    }
}