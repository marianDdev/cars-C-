using System;
using System.Linq;
using System.Collections.Generic;

namespace Cars
{
    public abstract class Vehicle
    {
        public string LicensePlate
        { get; private set; }

        public double Speed
        { get; protected set; }

        public int Wheels
        { get; protected set; }

        public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = "CL-19-CZR";
        }

        public virtual void SpeedUp()
        {
            Speed += 5;
        }

        public virtual void SlowDown()
        {
            Speed -= 5;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public virtual List<string> GetAvailableColors()
        {
            return new List<string> { "light white", "light black", "light red", "dark blue", "dark green", "dark purple" };
        }

        public abstract string Describe();

    }
}