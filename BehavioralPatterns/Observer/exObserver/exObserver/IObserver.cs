using System;
using System.Collections.Generic;
using System.Text;

namespace exObserver
{
    public interface IObserver
    {
        
        void Update(ISubject subject);
    }
}
