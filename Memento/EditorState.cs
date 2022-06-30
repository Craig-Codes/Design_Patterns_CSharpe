// Stores an editor state object containing state information
// Called 'Memento' in GoF
public class EditorState
{
    private string _content;
    public string Content  // C# Property more flexible than a field
    {
        get { return _content; }
        set { _content = value; }
    }

    // Store string value of current state though constructor
    public EditorState(string content)
    {
        Content = content;
    }
}