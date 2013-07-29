using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Iterator
{
    public class CarRange
    {
        private IList<IVehicle> cars;

        public CarRange()
        {
            cars = new List<IVehicle>();

            cars.Add(new Saloon(new StandardEngine(1300)));
            cars.Add(new Saloon(new StandardEngine(1600)));
            cars.Add(new Coupe(new StandardEngine(2000)));
            cars.Add(new Sport(new TurboEngine(2500)));
        }

        public virtual IList<IVehicle> Ranges
        {
            get { return cars; }
        }

        public virtual IEnumerator<IVehicle> GetEnumerator()
        {
            return cars.GetEnumerator();
        }
    }
}
