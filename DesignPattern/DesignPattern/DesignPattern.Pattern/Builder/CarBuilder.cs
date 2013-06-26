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
            base.BuildBody();
        }

        public override void BuildBoot()
        {
            base.BuildBoot();
        }

        public override void BuildChassis()
        {
            base.BuildChassis();
        }

        public override void BuildPassengerArea()
        {
            base.BuildPassengerArea();
        }

        public override void BuildWindows()
        {
            base.BuildWindows();
        }

        public override IVehicle Vehicle
        {
            get { return this.carInProgress; }
        }
    }
}
