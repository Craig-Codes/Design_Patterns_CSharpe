// Stores list of visted websites

using System;
using System.Collections.Generic;

public class BrowseHistory
{
    private List<string> urls = new List<string>();

    public void Push(string url)
    {
        urls.Add(url);
    }

    public IIterator<string> CreateIterator()
    {
        return new ListIterator(this);
    }


    // Nested Class implements the Concrete Iterator interface
    // Implementation knows how to iterate over a List object
    public class ListIterator : IIterator<string>
    {
        private BrowseHistory history;
        private int index;

        // Iterate over object passed to constructor
        public ListIterator(BrowseHistory history)
        {
            this.history = history;
        }
        public string Current()
        {
            return history.urls[index];
            // get the item at the current index
        }

        public bool HasNext()
        {
            return (index < history.urls.Count);
            // If history has more items than index, then still entries left
        }

        public void Next()
        {
            index++;
        }
    }
}