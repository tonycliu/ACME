using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Model
{
    public interface IVehicle
    {
        IEngine Engine { get; }
        VehicleColor Color { get; }
        void Paint(VehicleColor color);
    }
}
