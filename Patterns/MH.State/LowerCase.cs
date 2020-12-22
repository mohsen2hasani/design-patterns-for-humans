using System;

namespace MH.State
{
    public class LowerCase : IWritingState
    {
        public void Write(string words)
        {
            Console.WriteLine(words.ToLower());
        }
    }
}