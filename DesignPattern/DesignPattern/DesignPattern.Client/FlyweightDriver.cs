using DesignPattern.Model;
using DesignPattern.Pattern.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class FlyweightDriver
    {
        public static void Run()
        {
            EngineFlyweightFactory factory = new EngineFlyweightFactory();
            IDiagnosticTool tool = new EngineDiagnoseTool();

            IEngine s1 = factory.GetStandardEngine(1200);
            s1.Diagnose(tool);

            IEngine s2 = factory.GetStandardEngine(1200);
            s2.Diagnose(tool);

            IEngine s3 = factory.GetStandardEngine(1200);
            s3.Diagnose(tool);

            IEngine s4 = factory.GetTurboEngine(1600);
            s4.Diagnose(tool);

            IEngine s5 = factory.GetTurboEngine(1600);
            s5.Diagnose(tool);

            Console.WriteLine(s1.GetHashCode());
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.GetHashCode());
            Console.WriteLine(s4.GetHashCode());
            Console.WriteLine(s5.GetHashCode());
        }
    }
}
