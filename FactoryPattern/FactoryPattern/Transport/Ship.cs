using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Transport
{
    class Ship : ITransport
    {
        public string LoadTransport()
        {
            return "Filling Ship";
        }
    }
}
