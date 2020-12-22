using System.Collections.Generic;

namespace MH.Observer
{
    public class EmploymentAgency
    {
        protected List<IObserver> observers = new List<IObserver>();

        protected void Notify(JobPost jobPosting)
        {
            observers.ForEach(observer => observer.OnJobPosted(jobPosting));
        }

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void AddJob(JobPost jobPosting)
        {
            Notify(jobPosting);
        }
    }
}