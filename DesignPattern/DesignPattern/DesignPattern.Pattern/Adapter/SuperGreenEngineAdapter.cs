using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Adapter
{
    public class SuperGreenEngineAdapter : AbstractEngine
    {
        private SuperGreenEngine engine;

        public SuperGreenEngineAdapter(SuperGreenEngine engine)
            : base(engine.EngineSize, false)
        {
            this.engine = engine;
        }

        public override string ToString()
        {
            return engine.ToString();
        }
    }
}
