using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class Pickup : AbstractVan
    {
        public Pickup(IEngine engine, VehicleColor color) : base(engine, color) { }
        public Pickup(IEngine engine) : base(engine, VehicleColor.Unpainted) { }

		public override int Price
		{
			get { return 9000; }
		}
    }
}
