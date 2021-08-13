using AnimalFactory.Animal;
using AnimalFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimalFactory factory;

            Random random = new Random();
            int type = random.Next(0, 2);

            if (type == 0)
            {
                factory = new RandomAnimalFactory();
            }
            else
            {
                factory = new BasicAnimalFactory();
            }
            
            for (int i = 0; i < 7; i++)
            {
                IAnimal animal = factory.createAnimal();
                Console.WriteLine(animal.getName());

            }
            Console.ReadLine();
        }
    }
}
