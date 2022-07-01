using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new BrowseHistory();
            history.Push("a");
            history.Push("b");
            history.Push("c");

            IIterator<string> iterator = history.CreateIterator();

            // This code will now work for any different implementation types
            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.Write(url);
                iterator.Next();
            }
        }
    }
}
