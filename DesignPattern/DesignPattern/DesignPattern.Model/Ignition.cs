using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class Ignition
    {
        private EngineManagementSystem mediator;
        private bool on;

        public Ignition(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            this.on = false;

            this.mediator.RegisterIgnition(this);
        }

        public virtual void Start()
        {
            on = true;
            mediator.IgnitionTurnedOn();
            Console.WriteLine("Ignition turned on.");
        }

        public virtual void Stop()
        {
            on = false;
            mediator.IgnitionTurnedOff();
            Console.WriteLine("Ignition turned off.");
        }

        public virtual bool On
        {
            get { return on; }
        }
    }
}
