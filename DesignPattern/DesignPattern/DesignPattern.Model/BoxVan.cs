using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class BoxVan : AbstractVan
    {
        public BoxVan(IEngine engine, VehicleColor color) : base(engine, color) { }
        public BoxVan(IEngine engine) : base(engine, VehicleColor.Unpainted) { }
    }
}
