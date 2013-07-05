using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;

namespace DesignPattern.Pattern.Decorator
{
	public abstract class AbstractVehicleOption : AbstractVehicle
	{
		protected internal IVehicle decoratedVehicle;

		public AbstractVehicleOption(IVehicle vehicle)
			: base(vehicle.Engine, vehicle.Color)
		{
			this.decoratedVehicle = vehicle; 
		}
	}
}
