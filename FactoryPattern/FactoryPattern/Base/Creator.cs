using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    abstract class Creator
    {
        public abstract ITransport CreateTransport();

        public string PrepareTransport()
        {
           ITransport transport = CreateTransport();
           return transport.LoadTransport();
        }
    }
}
