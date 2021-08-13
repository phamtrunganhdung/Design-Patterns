using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractAnimal.Animal;

namespace AbstractAnimal.AbstractFactory
{
    class ZeroLegAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal createAnimal()
        {
            Random random = new Random();
            int type = 1;
                type = random.Next(0, 3);
            if (type == 0)
            {
                return new Snake();
            }
            else if(type == 1)
            {
                return new Worms();
            }
            else
            {
                return new Shark();
            }    
        }
    }
}
