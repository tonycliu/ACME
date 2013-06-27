using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;
using DesignPattern.Pattern.Factory;

namespace DesignPattern.Client
{
	public class FactoryDriver
	{
		public static void Run()
		{
			IVehicle v = VehicleFactory.Make(VehicleFactory.Category.Car, VehicleFactory.DrivingStyle.Powerful, VehicleColor.Blue);
			Console.WriteLine(v);
		}
	}
}
