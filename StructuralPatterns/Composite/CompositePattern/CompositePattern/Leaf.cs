using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Leaf : Component
    {
        public override string Operation()
        {
            return "Leaf";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
