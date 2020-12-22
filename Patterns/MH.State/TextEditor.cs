namespace MH.State
{
    public class TextEditor
    {
        protected IWritingState state;

        public TextEditor(IWritingState state)
        {
            this.state = state;
        }

        public void SetState(IWritingState state)
        {
            this.state = state;
        }

        public void Type(string words)
        {
            state.Write(words);
        }
    }
}