using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;
using DesignPattern.Pattern.Decorator;

namespace DesignPattern.Client
{
	public class DecoratorDriver
	{
		public static void Run()
		{
			IVehicle myCar = new Saloon(new StandardEngine(1200));
			myCar.Paint(VehicleColor.Blue);
			Console.WriteLine(myCar);

			myCar = new AirconditionedVehicle(myCar);
			Console.WriteLine(myCar);

			myCar = new AollyWheeledVehicle(myCar);
			Console.WriteLine(myCar);

			myCar = new LeatherSeatedVehicle(myCar);
			Console.WriteLine(myCar);

			myCar = new MetallicPaintedVehicle(myCar);
			Console.WriteLine(myCar);

			myCar = new SatNavVehicle(myCar);
			Console.WriteLine(myCar);
		}
	}
}
