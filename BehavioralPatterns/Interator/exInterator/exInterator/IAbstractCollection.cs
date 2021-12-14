using System;
using System.Collections.Generic;
using System.Text;

namespace exInterator
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
