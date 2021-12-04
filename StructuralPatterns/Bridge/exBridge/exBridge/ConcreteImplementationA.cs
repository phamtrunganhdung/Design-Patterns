using System;
using System.Collections.Generic;
using System.Text;

namespace exBridge
{
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }
}
