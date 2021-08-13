using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal.Animal
{
    class Dog : FourLegAnimal
    {
        public override string getName()
        {
            return "Nguyen Van Dog";
        }
    }
}
