using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public abstract class AbstractVehicle : IVehicle
    {
        private IEngine engine;
        private VehicleColor color;

        public AbstractVehicle(IEngine engine)
            : this(engine, VehicleColor.Unpainted)
        {
        }

        public AbstractVehicle(IEngine engine, VehicleColor color)
        {
            this.engine = engine;
            this.color = color;
        }

        public IEngine Engine
        {
            get { return engine; }
        }

        public VehicleColor Color
        {
            get { return color; }
        }

		public abstract int Price { get; }

        public void Paint(VehicleColor color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + engine + ", " + color + ", price: " + this.Price + ")";
        }

		#region ICloneable Members

		public virtual object Clone()
		{
			return this.MemberwiseClone();
		}

		#endregion

		#region IVehicle Members


		public virtual void CleanInterior()
		{
			Console.WriteLine("CleanInterior");
		}

		public virtual void CleanExteriorBody()
		{
			Console.WriteLine("CleanExteriorBody");
		}

		public virtual void PolishWindows()
		{
			Console.WriteLine("PolishWindows");
		}

		public virtual void TakeForTestDriver()
		{
			Console.WriteLine("TakeForTestDriver");
		}

		#endregion
	}
}
