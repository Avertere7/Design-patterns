using AbstractFactoryPattern.Base;
using System;

namespace AbstractFactoryPattern
{
    class NormalTable : ITable
    {
        public void SetTheTable()
        {
            Console.WriteLine("Set the normal table");
        }
    }
}
