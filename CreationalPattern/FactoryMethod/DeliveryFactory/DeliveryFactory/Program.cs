using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ITransport trans;

            string DeliveryCategory;
            Console.WriteLine("0 : Truck");
            Console.WriteLine("1 : Ship");
            Console.WriteLine("2 : Plane");
            Console.WriteLine("Chon loai hinh van chuyen : ");
            DeliveryCategory = Console.ReadLine();
            switch (DeliveryCategory)
            {
                case "0":
                     trans = new Truck();
                    Console.WriteLine(trans.getInfor());
                    break;
                case "1":
                    trans = new Ship();
                    Console.WriteLine(trans.getInfor());
                    break;
                case "2":
                    trans = new Plane();
                    Console.WriteLine(trans.getInfor());
                    break;
                default:
                    Console.WriteLine("Khong co loai hinh van chuyen nay");
                    break;
            }
            Console.ReadLine();
        }
    }
}
