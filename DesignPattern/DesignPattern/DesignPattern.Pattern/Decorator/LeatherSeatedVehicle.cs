using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;

namespace DesignPattern.Pattern.Decorator
{
	public class LeatherSeatedVehicle : AbstractVehicleOption
	{
		public LeatherSeatedVehicle(IVehicle vehicle)
			: base(vehicle) { }

		public override int Price
		{
			get { return this.decoratedVehicle.Price + 1200; }
		}
	}
}
