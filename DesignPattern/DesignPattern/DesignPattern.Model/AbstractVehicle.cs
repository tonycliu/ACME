using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class AbstractVehicle : IVehicle
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

        public void Paint(VehicleColor color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + engine + ", " + color + ")";
        }

		#region ICloneable Members

		public virtual object Clone()
		{
			return this.MemberwiseClone();
		}

		#endregion
	}
}
