using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;
using DesignPattern.Pattern.Facade;

namespace DesignPattern.Client
{
	public class FacadeDriver
	{
		public static void Run()
		{
			VehicleFacade vf = new VehicleFacade();
			IVehicle vehicle = new Sport(new TurboEngine(1800));
			vf.PrepareForSale(vehicle);
		}
	}
}
