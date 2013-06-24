using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class CarGlassware : IGlassware
    {
        public string GlasswareParts
        {
            get { return "Glassware parts for a car."; }
        }
    }
}
