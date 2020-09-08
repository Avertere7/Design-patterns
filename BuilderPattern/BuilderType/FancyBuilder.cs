using BuilderPattern.Base;
using BuilderPattern.Houses;
using System;

namespace BuilderPattern.Builder
{
    public class FancyBuilder : IBuilder
    {
        private FancyHouse house = new FancyHouse();

        public void AddDoor()
        {
            Console.WriteLine("Add fancy door");
        }

        public void AddGarden()
        {
            Console.WriteLine("Add beautyfull garden");

        }

        public void AddRoof()
        {
            Console.WriteLine("Add nice roof");
        }

        public void AddSwimmingPool()
        {
            Console.WriteLine("Add swimming pool");
        }

        public void AddWindow()
        {
            Console.WriteLine("Add fancy window");
        }

        public void BuildWalls()
        {
            Console.WriteLine("Build fancy walls");
            AddFancyWallpaper();
        }
        private void AddFancyWallpaper()
        {
            Console.WriteLine("Add wallpapers to wall");
        }
        public void Reset()
        {
            house = new FancyHouse();
        }

        public FancyHouse GetResult()
        {
            return house;
        }
    }
}
