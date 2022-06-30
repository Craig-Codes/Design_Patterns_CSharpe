// Class has single responsibility - state managment
// Keeps track of changes in the state 
// Called 'Caretaker' in GoF

using System;
using System.Collections.Generic;

namespace Memento
{
    class History
    {
        // Would actually be better to use a Stack here - LIFO
        // Store a list of all the EditorState objects
        private List<EditorState> states = new List<EditorState>();

        public void Push(EditorState state)
        {
            states.Add(state);  // Adds state object at end of the list
        }

        // Removes last EditorState Item in list and returns it
        public EditorState Pop()
        {
            var lastIndex = states.Count - 1;
            var lastState = states[lastIndex];

            states.Remove(lastState);

            return lastState;
        }
    }
}