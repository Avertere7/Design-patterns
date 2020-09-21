using Prototype.Models;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen(1,Color.Blue,10.02,false);
           
            Console.WriteLine(pen.ToString());
            var penClone =pen.Clone();
            penClone.Id = 2;
            Console.WriteLine(penClone.ToString());

        }
    }
}
