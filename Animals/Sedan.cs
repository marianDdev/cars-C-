using System;
using System.Linq;
using System.Collections.Generic;
namespace Cars
{
	public class Sedan : Vehicle, IAutomobile
	{
        public Sedan(double speed) : base(speed)
        {
            Wheels = 4;
        }

        public override string Describe()
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

        public void PrintAvailableColors()
        {
            List<string> colors = GetAvailableColors();

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}

