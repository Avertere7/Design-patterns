using FactoryPattern.Creators;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new TruckCreator();
            Console.WriteLine(creator.PrepareTransport());

            Creator creator2 = new ShipCreator();
            Console.WriteLine(creator2.PrepareTransport());
        }
    }
}
