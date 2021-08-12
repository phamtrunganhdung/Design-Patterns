using AnimalFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory.Animal
{
    class Cat : IAnimal
    {
        public string getName()
        {
            return "Le Van Cat";
        }
    }
}
