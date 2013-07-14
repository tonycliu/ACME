using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class EngineDiagnoseTool : IDiagnosticTool
    {
        public void RunDiagnosis(object obj)
        {
            Console.WriteLine("Starting engine diagnose tool for " + obj);
            Thread.Sleep(5000);
            Console.WriteLine("Engine diagnosis complete.");
        }
    }
}
