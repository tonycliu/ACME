using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class AbstractEngine : IEngine
    {
        private int size;
        private bool turbo;
        private bool running;
        private int power;

        private Camshaft camshaft;
        private Piston piston;
        private SparkPlug[] sparkPlugs;

        public AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;

            camshaft = new Camshaft();
            piston = new Piston();
            sparkPlugs = new[] { new SparkPlug(), new SparkPlug(), new SparkPlug(), new SparkPlug() };
        }

        public int Size
        {
            get { return size; }
        }

        public bool Turbo
        {
            get { return turbo; }
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + this.size + ") [Is On: " + this.running + ", Speed: " + this.power + "]";
        }


        public void Start()
        {
            this.running = true;
        }

        public void Stop()
        {
            this.power = 0;
            this.running = false;
        }

        public void IncreasePower()
        {
            if (running && power < 10)
                power++;
        }

        public void DescresePower()
        {
            if (running && power > 0)
                power--;
        }


        public void Diagnose(IDiagnosticTool tool)
        {
            tool.RunDiagnosis(this);
        }

        public void AcceptEngineVisitor(IEngineVisitor visitor)
        {
            camshaft.AcceptEngineVisitor(visitor);
            piston.AcceptEngineVisitor(visitor);
            foreach (SparkPlug sp in sparkPlugs)
            {
                sp.AcceptEngineVisitor(visitor);
            }
            visitor.Visit(this);
        }
    }
}
