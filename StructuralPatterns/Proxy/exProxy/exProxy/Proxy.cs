using System;
using System.Collections.Generic;
using System.Text;

namespace exProxy
{
    public class Proxy : Subject
    {
        private RealSubject realSubject;
        public override void Request()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject();
            }
            realSubject.Request();
        }
    }
}

