using DesignPattern.Model;
using DesignPattern.Pattern.Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class BridgeDriver
    {
        public static void Run()
        {
            IEngine standardEngine = new StandardEngine(1200);
            StandardDriverControl sdControl = new StandardDriverControl(standardEngine);
            sdControl.IgnitionOn();
            sdControl.Accelerate();
            sdControl.Accelerate();
            sdControl.Break();
            Console.WriteLine(sdControl);

            IEngine sportEngine = new TurboEngine(2500);
            SportDriverControl sportControl = new SportDriverControl(standardEngine);
            sportControl.IgnitionOn();
            sportControl.Accelerate();
            sportControl.AccelerateHard();
            sportControl.Break();
            Console.WriteLine(sportControl);

            sdControl.IgnitionOff();
            sportControl.IgnitionOff();
            Console.WriteLine(sdControl);
            Console.WriteLine(sportControl);
        }
    }
}
