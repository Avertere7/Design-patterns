using BuilderPattern.Base;
using BuilderPattern.Houses;
using System;

namespace BuilderPattern.Builder
{
    public class NormalBuilder : IBuilder
    {
        private NormalHouse house = new NormalHouse();
        public void AddDoor()
        {
            Console.WriteLine("Add door");
        }

        public void AddGarden()
        {
            Console.WriteLine("Add garden");

        }

        public void AddRoof()
        {
            Console.WriteLine("Add roof");
        }

        public void AddSwimmingPool()
        {
            Console.WriteLine("Add swimming pool");
        }

        public void AddWindow()
        {
            Console.WriteLine("Add window");
        }

        public void BuildWalls()
        {
            Console.WriteLine("Build walls");
        }

        public void Reset()
        {
            house = new NormalHouse();
        }

        public NormalHouse GetResult()
        {
            return house;
        }
    }
}
