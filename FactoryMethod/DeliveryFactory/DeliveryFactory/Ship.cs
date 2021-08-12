using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryFactory
{
    class Ship : ITransport
    {
        public string getInfor()
        {
            return "Products are transported by ship";
        }
    }
}
