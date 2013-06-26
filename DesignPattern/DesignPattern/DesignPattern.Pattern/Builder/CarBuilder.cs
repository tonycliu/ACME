using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Builder
{
    public class CarBuilder : VehicleBuilder
    {
        private AbstractCar carInProgress;

        public CarBuilder(AbstractCar car)
        {
            this.carInProgress = car;
        }

        public override void BuildBody()
        {
            Console.WriteLine("building car body");
        }

        public override void BuildBoot()
        {
            Console.WriteLine("building car boot");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building car chassis");
        }

        public override void BuildPassengerArea()
        {
            Console.WriteLine("building car passenger area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("building car windows");
        }

        public override IVehicle Vehicle
        {
            get { return this.carInProgress; }
        }
    }
}
