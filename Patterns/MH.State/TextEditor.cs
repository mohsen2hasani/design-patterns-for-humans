namespace MH.State;

public class TextEditor
{
    protected IWritingState State;

    public TextEditor(IWritingState state)
    {
        State = state;
    }

    public void SetState(IWritingState state)
    {
        State = state;
    }

    public void Type(string words)
    {
        State.Write(words);
    }
}