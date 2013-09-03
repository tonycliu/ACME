using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Visitor
{
    public class EngineInventory : IEngineVisitor
    {
        private int camshaftCount;
        private int pistonCount;
        private int sparkPlugCount;

        public EngineInventory()
        {
            camshaftCount = sparkPlugCount = pistonCount = 0;
        }

        public void Visit(Camshaft camshaft)
        {
            camshaftCount++;
        }

        public void Visit(IEngine engine)
        {
            Console.WriteLine("The engine has: " + camshaftCount + " camshaft(s), " + pistonCount + " piston(s), " + sparkPlugCount + " spark(s).");
        }

        public void Visit(Piston piston)
        {
            pistonCount++;
        }

        public void Visit(SparkPlug sparkPlug)
        {
            sparkPlugCount++;
        }
    }
}
