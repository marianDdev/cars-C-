using System;
namespace Cars
{
	public interface IAutomobile
	{
		string LicensePlate { get; }
		double Speed { get; }
		int Wheels { get; }
		void Honk();
	}
}

