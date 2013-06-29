using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Bridge
{
    public abstract class AbstractDriverControl
    {
        private IEngine engine;

        public AbstractDriverControl(IEngine engine)
        {
            this.engine = engine;
        }

        public virtual void IgnitionOn()
        {
            this.engine.Start();
        }

        public virtual void IgnitionOff()
        {
            this.engine.Stop();
        }

        public virtual void Accelerate()
        {
            this.engine.IncreasePower();
        }

        public virtual void Break()
        {
            this.engine.DescresePower();
        }

        public override string ToString()
        {
            return this.engine.ToString();
        }
    }
}
