﻿using System;
using System.Collections.Generic;
using System.Text;

namespace exBridge
{
    class Client
    {
         public void ClientCode(Abstraction abstraction)
        {
            Console.Write(abstraction.Operation());
        }
    }
}
