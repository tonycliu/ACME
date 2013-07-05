using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;

namespace DesignPattern.Pattern.Decorator
{
	public class SatNavVehicle : AbstractVehicleOption
	{
		public SatNavVehicle(IVehicle vehicle)
			: base(vehicle) { }

		public override int Price
		{
			get { return this.decoratedVehicle.Price + 1500; }
		}
	}
}
