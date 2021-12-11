using System;
using System.Collections.Generic;
using System.Text;

namespace exDecorator
{
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
