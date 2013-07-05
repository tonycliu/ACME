using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public abstract class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine, VehicleColor color) : base(engine, color) { }
        public AbstractCar(IEngine engine) : base(engine, VehicleColor.Unpainted) { }
    }
}
