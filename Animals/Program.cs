using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Console.WriteLine(s.Describe());
            s.PrintAvailableColors();

            Truck t = new Truck(45, 500);
            Console.WriteLine(t.Describe());
            t.PrintDarkColorsInUppercase();

            Bicycle b = new Bicycle(10);
            Console.WriteLine(b.Describe());
        }
    }
}

