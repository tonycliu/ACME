using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class StandardGearboxStrategy : IGearboxStrategy
    {
        public void EnsureCorrectGear(IEngine engine, int speed)
        {
            Console.WriteLine("Correct gear at " + speed + "mph for STANDARD engine...");
        }
    }
}
