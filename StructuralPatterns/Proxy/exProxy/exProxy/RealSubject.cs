using System;
using System.Collections.Generic;
using System.Text;

namespace exProxy
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called RealSubject.Request()");
        }
    }
}
