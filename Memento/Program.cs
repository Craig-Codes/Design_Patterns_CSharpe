/*The Memento design pattern - without violating encapsulation, captures and externalizes an object‘s internal state 
 * so that the object can be restored to this state later. 
 https://www.dofactory.com/net/memento-design-pattern 

 Our example is a code editor which implements an Undo */

using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "a";
            history.Push(editor.createState()); // Create a new State and push to History list
            editor.Content = "b";
            history.Push(editor.createState());
            editor.Content = "c";
            editor.Restore(history.Pop()); // Restore to last state - content back to 'b'
            editor.Restore(history.Pop());  // Now 'a'

            Console.WriteLine(editor.Content);

        }
    }
}
