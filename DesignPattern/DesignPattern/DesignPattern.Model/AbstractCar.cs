using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public abstract class AbstractCar : AbstractVehicle
    {
        private IGearboxStrategy gearboxStrategy;
        public AbstractCar(IEngine engine, VehicleColor color) : base(engine, color) 
        {
            gearboxStrategy = new StandardGearboxStrategy();
        }
        public AbstractCar(IEngine engine) : this(engine, VehicleColor.Unpainted) { }

        public virtual IGearboxStrategy GearboxStrategy
        {
            get
            {
                return gearboxStrategy;
            }
            set
            {
                gearboxStrategy = value;
                Console.WriteLine("Change gearbox strategy to " + gearboxStrategy.GetType().ToString());
            }
        }

        public virtual int Speed
        {
            set
            {
                gearboxStrategy.EnsureCorrectGear(this.Engine, value);
            }
        }
    }
}
