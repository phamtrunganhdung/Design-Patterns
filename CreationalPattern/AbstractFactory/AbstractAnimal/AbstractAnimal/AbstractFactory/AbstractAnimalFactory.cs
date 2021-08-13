using AbstractAnimal.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractAnimal.Animal;

namespace AbstractAnimal.AbstractFactory
{
    abstract class AbstractAnimalFactory : IAnimalFactory
    {
        public abstract IAnimal createAnimal();
    }
}
