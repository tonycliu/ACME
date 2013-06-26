using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class AbstractVan : AbstractVehicle
    {
        public AbstractVan(IEngine engine, VehicleColor color) : base(engine, color) { }
        public AbstractVan(IEngine engine) : base(engine, VehicleColor.Unpainted) { }
    }
}
