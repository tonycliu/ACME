using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.AbstractFactory
{
    public class VanFactory : AbstractVehicleFactory
    {
        public override IBody CreateBody()
        {
            return new VanBody();
        }

        public override IChassis CreateChassis()
        {
            return new VanChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
}
