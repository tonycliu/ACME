using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class AbstractEngine : IEngine
    {
        private int size;
        private bool turbo;

        public AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
        }

        public int Size
        {
            get { return size; }
        }

        public bool Turbo
        {
            get { return turbo; }
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + this.size + ")";
        }
    }
}
