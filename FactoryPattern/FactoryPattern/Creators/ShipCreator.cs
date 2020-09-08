using FactoryPattern.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Creators
{
    class ShipCreator : Creator
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
