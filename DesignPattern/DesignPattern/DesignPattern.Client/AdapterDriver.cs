using DesignPattern.Model;
using DesignPattern.Pattern.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class AdapterDriver
    {
        public static void Run()
        {
            List<IEngine> engines = new List<IEngine>();
            engines.Add(new StandardEngine(1000));
            engines.Add(new TurboEngine(2000));

            SuperGreenEngine sgEngine = new SuperGreenEngine(800);
            engines.Add(new SuperGreenEngineAdapter(sgEngine));

            foreach (var engine in engines)
            {
                Console.WriteLine(engine);
            }
        }
    }
}
