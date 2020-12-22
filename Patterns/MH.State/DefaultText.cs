using System;

namespace MH.State
{
    public class DefaultText : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words);
        }
    }
}