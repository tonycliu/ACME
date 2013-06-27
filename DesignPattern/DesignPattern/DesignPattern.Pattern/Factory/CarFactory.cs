using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;

namespace DesignPattern.Pattern.Factory
{
	public class CarFactory : VehicleFactory
	{
		protected internal override IVehicle SelectVehicle(DrivingStyle style)
		{
			switch(style)
			{
				case DrivingStyle.Economical:
					return new Saloon(new StandardEngine(1300));
				case DrivingStyle.Midrange:
					return new Coupe(new StandardEngine(1600));
				case DrivingStyle.Powerful:
				default:
					return new Sport(new TurboEngine(2000));
			}
		}
	}
}
