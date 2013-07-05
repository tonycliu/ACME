using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;

namespace DesignPattern.Pattern.Facade
{
	public class VehicleFacade
	{
		public virtual void PrepareForSale(IVehicle vehicle)
		{
			Registration reg = new Registration(vehicle);
			reg.AllocateVIN();
			reg.AllocateLicensePlate();

			Documentation.PrintBrochure(vehicle);

			vehicle.CleanInterior();
			vehicle.CleanExteriorBody();
			vehicle.PolishWindows();
			vehicle.TakeForTestDriver();
		}
	}
}
