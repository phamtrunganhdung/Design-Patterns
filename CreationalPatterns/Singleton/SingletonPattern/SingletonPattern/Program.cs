using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(() => SingletonPattern.GetInstance().SingletonNumber());
            var thread2 = new Thread(() => SingletonPattern.GetInstance().SingletonNumber());
            var thread3 = new Thread(() => SingletonPattern.GetInstance().SingletonNumber());
            var thread4 = new Thread(() => SingletonPattern.GetInstance().SingletonNumber());

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            Console.Read();
        }
    }
}
