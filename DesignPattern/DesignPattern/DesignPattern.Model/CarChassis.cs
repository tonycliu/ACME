using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class CarChassis : IChassis
    {
        public string ChassisParts
        {
            get { return "Chassis parts for a car."; }
        }
    }
}
