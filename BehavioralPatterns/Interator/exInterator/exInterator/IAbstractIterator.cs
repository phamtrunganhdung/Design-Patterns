using System;
using System.Collections.Generic;
using System.Text;

namespace exInterator
{
    public interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
