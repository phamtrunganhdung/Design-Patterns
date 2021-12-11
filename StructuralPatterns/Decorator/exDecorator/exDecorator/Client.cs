using System;
using System.Collections.Generic;
using System.Text;

namespace exDecorator
{
    public class Client
    {
        public void ClientCode(Component component)
        {
            Console.WriteLine("RESULT: " + component.Operation());
        }
    }
}
