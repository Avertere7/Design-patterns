using BuilderPattern.Builder;
using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director(new NormalBuilder());
            director.Make(BuildOption.LuxuryHouse);
            Console.WriteLine();
            director.ChangeBuilder(new FancyBuilder());
            director.Make(BuildOption.BasicHouse);
        }
    }
}
