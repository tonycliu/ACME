using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class SuperGreenEngine
    {
        private int size;

        public SuperGreenEngine(int size)
        {
            this.size = size;
        }

        public int EngineSize { get { return this.size; } }

        public override string ToString()
        {
            return string.Format("SUPER ENGINE ({0})", this.size);
        }
    }
}
