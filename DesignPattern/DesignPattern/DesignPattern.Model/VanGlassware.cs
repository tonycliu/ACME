using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class VanGlassware : IGlassware
    {
        public string GlasswareParts
        {
            get { return "Glassware parts for a van."; }
        }
    }
}
