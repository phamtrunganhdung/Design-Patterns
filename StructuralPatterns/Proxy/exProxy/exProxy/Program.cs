using System;

namespace exProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Proxy proxy = new Proxy();
            proxy.Request();
            Console.ReadKey();
        }
    }
}
