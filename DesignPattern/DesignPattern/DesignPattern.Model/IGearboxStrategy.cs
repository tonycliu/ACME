using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public interface IGearboxStrategy
    {
        void EnsureCorrectGear(IEngine engine, int speed);
    }
}
