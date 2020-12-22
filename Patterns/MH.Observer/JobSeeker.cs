using System;

namespace MH.Observer
{
    public class JobSeeker : IObserver
    {
        protected string name;

        public JobSeeker(string name)
        {
            this.name = name;
        }

        public void OnJobPosted(JobPost job)
        {
            // Do something with the job posting
            Console.WriteLine($"Hi {name}! New job posted: {job.getTitle()}");
        }
    }
}