using FactoryPattern.Transport;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Creators
{
    class TruckCreator : Creator
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
