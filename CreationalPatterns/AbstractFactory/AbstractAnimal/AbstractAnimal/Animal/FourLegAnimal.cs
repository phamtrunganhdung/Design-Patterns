using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal.Animal
{
    abstract class FourLegAnimal : IAnimal
    {
        public abstract string getName();
    }
}
