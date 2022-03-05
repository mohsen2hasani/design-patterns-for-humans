using System.Collections.Generic;

namespace MH.Observer;

public class EmploymentAgency
{
    protected List<IObserver> Observers = new();

    protected void Notify(JobPost jobPosting)
    {
        Observers.ForEach(observer => observer.OnJobPosted(jobPosting));
    }

    public void Attach(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void AddJob(JobPost jobPosting)
    {
        Notify(jobPosting);
    }
}