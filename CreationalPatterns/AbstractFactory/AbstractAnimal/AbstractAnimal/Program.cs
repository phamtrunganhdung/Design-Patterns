using AbstractAnimal.AbstractFactory;
using AbstractAnimal.Animal;
using AbstractAnimal.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory;

            Random random = new Random();
            int type = random.Next(0, 3);

            if (type == 0)
            {
                factory = new ZeroLegAnimalFactory();
            }
            else if(type == 1)
            {
                factory = new TwoLegAnimalFactory();
            }
            else
            {
                factory = new FourLegAnimalFactory();
            }

            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());
            Console.WriteLine(factory.createAnimal().getName());

            Console.ReadLine();
        }
    }
}
