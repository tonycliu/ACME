using DesignPattern.Model;
using DesignPattern.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class ProxyDriver
    {
        public static void Run()
        {
            EngineProxy proxy = new EngineProxy(1600, true);
            IDiagnosticTool tool = new EngineDiagnoseTool();
            proxy.Diagnose(tool);
            Console.WriteLine(proxy.Size);
            proxy.Start();
            Console.WriteLine(proxy.ToString());
        }
    }
}
