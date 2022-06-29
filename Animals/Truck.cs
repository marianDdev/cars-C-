using System;
using System.Collections.Generic;
using System.Linq;
namespace Cars
{
	public class Truck : Vehicle, IAutomobile
    {
        public double Weight
        { get; }

        public Truck(double speed, double weight) : base(speed)
        {
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public override string Describe()
        {
            return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

        public void PrintDarkColorsInUppercase()
        {
            List<string> colors = GetAvailableColors();

            var darkColors = colors.Where(c => c.Contains("dark"));
            var darkColorsUppercased = darkColors.Select(c => c.ToUpper());
            string darkColorsUppercasedString = String.Join(",", darkColorsUppercased);

            Console.WriteLine($"This are the dark colors in uppercase: {darkColorsUppercasedString}");
        }
    }
}

