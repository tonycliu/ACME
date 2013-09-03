using DesignPattern.Model;
using DesignPattern.Pattern.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class VisitorDriver
    {
        public static void Run()
        {
            AbstractEngine engine = new StandardEngine(1300);

            engine.AcceptEngineVisitor(new EngineDiagnostics());
            engine.AcceptEngineVisitor(new EngineInventory());
        }
    }
}
