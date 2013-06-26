using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size) : base(size, false) {}
    }
}
