using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Pattern
{
    public class EngineProxy : IEngine
    {
        private IEngine engine;

        public EngineProxy(int size, bool turbo)
        {
            if (turbo)
            {
                engine = new StandardEngine(size);
            }
            else
            {
                engine = new TurboEngine(size);
            }
        }

        public int Size
        {
            get { return engine.Size; }
        }

        public bool Turbo
        {
            get { return engine.Turbo; }
        }

        public virtual void Diagnose(IDiagnosticTool tool)
        {
            Console.WriteLine("(Running diagnosis in a new thread...)");
            Thread t = new Thread(() => { RunDiagnosticTool(tool); });
            t.Start();
            Console.WriteLine("Engine proxy Diagnose() method completed.");
        }

        public virtual void RunDiagnosticTool(IDiagnosticTool tool)
        {
            tool.RunDiagnosis(this);
        }


        public void Start()
        {
            engine.Start();
        }

        public void Stop()
        {
            engine.Stop();
        }

        public void IncreasePower()
        {
            engine.IncreasePower();
        }

        public void DescresePower()
        {
            engine.DescresePower();
        }

        public override string ToString()
        {
            return engine.ToString();
        }
    }
}
