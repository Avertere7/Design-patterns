using AbstractFactoryPattern.Base;
using System;

namespace AbstractFactoryPattern
{
    class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sit on the modern chair");

        }
    }
}
