using MH.Observer;

namespace MH.UsePatterns.Methods;

public class ObserverTest
{
    public static void Run()
    {
        // Create subscribers
        var johnDoe = new JobSeeker("John Doe");
        var janeDoe = new JobSeeker("Jane Doe");

        // Create publisher and attach subscribers
        var jobPostings = new EmploymentAgency();
        jobPostings.Attach(johnDoe);
        jobPostings.Attach(janeDoe);

        // Add a new job and see if subscribers get notified
        jobPostings.AddJob(new JobPost("Software Engineer"));

        // Output
        // Hi John Doe! New job posted: Software Engineer
        // Hi Jane Doe! New job posted: Software Engineer
    }
}