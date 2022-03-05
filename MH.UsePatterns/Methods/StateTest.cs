using MH.State;

namespace MH.UsePatterns.Methods;

public class StateTest
{
    public static void Run()
    {
        var editor = new TextEditor(new DefaultText());

        editor.Type("First line");

        editor.SetState(new UpperCase());

        editor.Type("Second line");
        editor.Type("Third line");

        editor.SetState(new LowerCase());

        editor.Type("Fourth line");
        editor.Type("Fifth line");

        // Output:
        // First line
        // SECOND LINE
        // THIRD LINE
        // fourth line
        // fifth line
    }
}