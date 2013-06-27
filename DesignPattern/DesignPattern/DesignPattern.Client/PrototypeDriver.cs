using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;
using DesignPattern.Pattern.Prototype;

namespace DesignPattern.Client
{
	public class PrototypeDriver
	{
		public static void Run()
		{
			VehicleManagerLazy mgr = new VehicleManagerLazy();

			IVehicle v1 = mgr.CreateSaloon();
			IVehicle v2 = mgr.CreateSaloon();
			IVehicle v3 = mgr.CreatePickup();

			Console.WriteLine(v1);
			Console.WriteLine(v2);
			Console.WriteLine(v3);
		}
	}
}
