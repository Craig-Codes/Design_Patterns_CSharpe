// The simple browser editor - Just deals with content
// Called 'Origninator' in GoF

using System;

namespace Memento
{
    class Editor
    {
        // Property allows get and set methods of current state
        public string Content { get; set; }

        // Create a new State Object based on current content
        public EditorState createState()
        {
            return new EditorState(Content);
        }

        // Restore to a previous editor state object state
        public void Restore(EditorState state)
        {
            Content = state.Content;
        }
    }
}