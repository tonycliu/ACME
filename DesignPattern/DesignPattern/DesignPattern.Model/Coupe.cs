using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine, VehicleColor color) : base(engine, color) { }
        public Coupe(IEngine engine) : base(engine, VehicleColor.Unpainted) { }

		public override int Price
		{
			get { return 7000; }
		}
    }
}
