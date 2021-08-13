using AbstractAnimal.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal.Factory
{
    interface IAnimalFactory
    {
        IAnimal createAnimal();
    }
}
