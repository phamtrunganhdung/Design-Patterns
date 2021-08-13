using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonPattern
    {
        private int index;
        private static readonly object lockObject = new object();
        private static volatile SingletonPattern uniqueInstance;

        private SingletonPattern(int index)
        {
            this.index = index;
        }

        public static SingletonPattern GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (lockObject)
                {
                    var random = new Random();

                    uniqueInstance = new SingletonPattern(random.Next(1, 4));
                }
            }
            return uniqueInstance;
        }

        public void SingletonNumber()
        {
            Console.WriteLine("Singleton number " + index);
        }
    }
}
