using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
	public class Registration
	{
		private IVehicle vehicle;

		public Registration(IVehicle vehicle)
		{
			this.vehicle = vehicle;
		}

		public virtual void AllocateLicensePlate()
		{
			Console.WriteLine("AllocateLicensePlate");
		}

		public virtual void AllocateVIN()
		{
			Console.WriteLine("AllocateVIN");
		}
	}
}
