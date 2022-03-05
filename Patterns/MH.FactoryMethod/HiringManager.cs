namespace MH.FactoryMethod;

public abstract class HiringManager
{
    protected abstract IInterviewer MakeInterviewer();

    public void TakeInterview()
    {
        var interviewer = MakeInterviewer();
        interviewer.AskQuestions();
    }
}