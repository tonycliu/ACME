using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;

namespace DesignPattern.Pattern.Factory
{
	public class VanFactory : VehicleFactory
	{
		protected internal override IVehicle SelectVehicle(DrivingStyle style)
		{
			switch (style)
			{
				case DrivingStyle.Economical:
				case DrivingStyle.Midrange:
					return new Pickup(new StandardEngine(2000));
				case DrivingStyle.Powerful:
				default:
					return new BoxVan(new TurboEngine(2500));
			}
		}
	}
}
