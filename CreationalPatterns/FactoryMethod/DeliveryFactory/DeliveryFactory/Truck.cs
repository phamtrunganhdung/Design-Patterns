using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFactory
{
    class Truck : ITransport
    {
        public string getInfor()
        {
            return "Products are transported by truck";
        }

    }
}
