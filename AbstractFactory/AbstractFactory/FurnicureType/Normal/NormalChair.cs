using AbstractFactoryPattern.Base;
using System;

namespace AbstractFactoryPattern
{
    class NormalChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sit on the normal chair");

        }
    }
}
