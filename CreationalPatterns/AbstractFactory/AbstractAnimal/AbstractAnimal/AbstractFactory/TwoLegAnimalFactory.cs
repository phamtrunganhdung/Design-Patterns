using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractAnimal.Animal;

namespace AbstractAnimal.AbstractFactory
{
    class TwoLegAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal createAnimal()
        {
            Random random = new Random();
            int type = 0;
                type = random.Next(0, 3);
            if (type == 0)
            {
                return new Duck();
            }
            else if (type == 1)
            {
                return new Bird();
            }
            else
            {
                return new Chicken();
            }
        }
    }
}
