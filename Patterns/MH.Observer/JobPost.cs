namespace MH.Observer
{
    public class JobPost
    {
        protected string title;

        public JobPost(string title)
        {
            this.title = title;
        }

        public string getTitle()
        {
            return this.title;
        }
    }
}