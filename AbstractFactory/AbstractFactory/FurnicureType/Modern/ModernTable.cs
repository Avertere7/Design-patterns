using AbstractFactoryPattern.Base;
using System;

namespace AbstractFactoryPattern
{
    class ModernTable : ITable
    {
        public void SetTheTable()
        {
            Console.WriteLine("Set the modern table");
        }
    }
}
