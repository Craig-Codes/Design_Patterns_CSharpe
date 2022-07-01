using System;
using System.Collections.Generic;
using System.Text;

    public interface IIterator<T> // T allows us to use different implemetations
        // Eg. Class : IIterator<string> Or IIterator<User> etc
    {
        Boolean HasNext();
        T Current();  // Generic, whatever type is supplied is the type returned
        void Next();
    }
