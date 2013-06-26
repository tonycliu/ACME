using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Builder
{
    public abstract class VehicleBuilder
    {
        public virtual void BuildBody() { }
        public virtual void BuildChassis() { }
        public virtual void BuildBoot() { }
        public virtual void BuildPassengerArea() { }
        public virtual void BuildReinforcedStorageArea() { }
        public virtual void BuildWindows() { }

        public abstract IVehicle Vehicle { get; }
    }
}
