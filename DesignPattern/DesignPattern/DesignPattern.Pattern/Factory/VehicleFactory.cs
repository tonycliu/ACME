using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Model;

namespace DesignPattern.Pattern.Factory
{
	public abstract class VehicleFactory
	{
		public enum DrivingStyle
		{
			Economical, Midrange, Powerful
		}

		public enum Category { Car, Van }

		public virtual IVehicle Build(DrivingStyle style, VehicleColor color)
		{
			IVehicle v = SelectVehicle(style);
			v.Paint(color);
			return v;
		}

		protected internal abstract IVehicle SelectVehicle(DrivingStyle style);

		public static IVehicle Make(Category category, DrivingStyle style, VehicleColor color)
		{
			VehicleFactory factory = null;

			if (category == Category.Car)
			{
				factory = new CarFactory();
			}
			else
			{
				factory = new VanFactory();
			}

			return factory.Build(style, color);
		}
	}
}
