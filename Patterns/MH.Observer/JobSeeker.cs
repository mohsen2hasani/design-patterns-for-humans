using System;

namespace MH.Observer;

public class JobSeeker : IObserver
{
    protected string Name;

    public JobSeeker(string name)
    {
        Name = name;
    }

    public void OnJobPosted(JobPost job)
    {
        // Do something with the job posting
        Console.WriteLine($"Hi {Name}! New job posted: {job.GetTitle()}");
    }
}