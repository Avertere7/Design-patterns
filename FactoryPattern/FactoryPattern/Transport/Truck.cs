using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Transport
{
    class Truck : ITransport
    {
        public string LoadTransport()
        {
            return "Loading truck";
        }
    }
}
