using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Builder
{
    public class VanDirector : VehicleDirector
    {
        public override IVehicle Build(VehicleBuilder builder)
        {
            builder.BuildBody();
            builder.BuildReinforcedStorageArea();
            builder.BuildChassis();
            builder.BuildWindows();
            return builder.Vehicle;
        }
    }
}
