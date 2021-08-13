using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractAnimal.Animal;

namespace AbstractAnimal.AbstractFactory
{
    class FourLegAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimal createAnimal()
        {
            Random random = new Random();
            int type = 2;
                type = random.Next(0, 3);
            if (type == 0)
            {
                return new Dog();
            }
            else if(type == 1 )
            {
                return new Cow();
            }
            else
            {
                return new Cat();
            }
        }
    }
}
