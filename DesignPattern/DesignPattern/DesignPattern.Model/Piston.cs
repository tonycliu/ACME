using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Model
{
    public class Piston : IVisitable
    {
        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
