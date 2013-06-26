using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class Sport : AbstractCar
    {
        public Sport(IEngine engine, VehicleColor color) : base(engine, color) { }
        public Sport(IEngine engine) : base(engine, VehicleColor.Unpainted) { }
    }
}
