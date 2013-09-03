using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public interface IEngineVisitor
    {
        void Visit(Camshaft camshaft);
        void Visit(IEngine engine);
        void Visit(Piston piston);
        void Visit(SparkPlug sparkPlug);
    }
}
