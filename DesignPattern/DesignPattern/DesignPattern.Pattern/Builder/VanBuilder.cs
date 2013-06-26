using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Builder
{
    public class VanBuilder : VehicleBuilder
    {
        private AbstractVan vanInProgress;

        public VanBuilder(AbstractVan van)
        {
            this.vanInProgress = van;
        }

        public override void BuildBody()
        {
            Console.WriteLine("building van body");
        }

        public override void BuildChassis()
        {
            Console.WriteLine("building van chassis");
        }

        public override void BuildReinforcedStorageArea()
        {
            Console.WriteLine("building van reinforced storage area");
        }

        public override void BuildWindows()
        {
            Console.WriteLine("building van windows");
        }

        public override IVehicle Vehicle
        {
            get { return this.vanInProgress; }
        }
    }
}
