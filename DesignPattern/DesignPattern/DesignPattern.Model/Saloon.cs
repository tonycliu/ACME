using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class Saloon : AbstractCar
    {
        public Saloon(IEngine engine, VehicleColor color) : base(engine, color) { }
        public Saloon(IEngine engine) : base(engine, VehicleColor.Unpainted) { }

		public override int Price
		{
			get { return 6000; }
		}
    }
}
