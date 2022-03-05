namespace MH.Observer;

public class JobPost
{
    protected string Title;

    public JobPost(string title)
    {
        Title = title;
    }

    public string GetTitle()
    {
        return Title;
    }
}