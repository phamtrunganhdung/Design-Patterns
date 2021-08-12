using AnimalFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory.Animal
{
    class Duck : IAnimal
    {
        public string getName()
        {
            return "Tran Van Duck";
        }
    }
}
