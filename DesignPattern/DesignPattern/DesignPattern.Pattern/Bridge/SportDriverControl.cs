using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Bridge
{
    public class SportDriverControl : AbstractDriverControl
    {
        public SportDriverControl(IEngine engine) : base(engine) { }

        public virtual void AccelerateHard()
        {
            this.Accelerate();
            this.Accelerate();
        }
    }
}
