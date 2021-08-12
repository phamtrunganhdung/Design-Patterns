using AnimalFactory.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory.Factory
{
    interface IAnimalFactory
    {
        IAnimal createAnimal();
    }
}
