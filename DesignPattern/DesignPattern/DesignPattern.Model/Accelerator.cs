using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Model
{
    public class Accelerator
    {
        private EngineManagementSystem mediator;
        private bool enabled;
        private int speed;

        public Accelerator(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            this.enabled = false;
            this.speed = 0;
            this.mediator.RegisterAccelerator(this);
        }

        public virtual void Enable()
        {
            this.enabled = true;
            mediator.AcceleratorEnabled();
            Console.WriteLine("Accelerator is enabled.");
        }

        public virtual void Disable()
        {
            this.enabled = false;
            mediator.AcceleratorDisabled();
            Console.WriteLine("Accelerator is disabled.");
        }

        public virtual void AccelerateToSpeed(int speed)
        {
            if (this.enabled)
            {
                this.speed = speed;
                Console.WriteLine("Accelerate to speed " + this.speed + "mph");
            }
        }

        public virtual bool Enabled
        {
            get { return this.enabled; }
        }

        public virtual int Speed
        {
            get { return this.speed; }
        }
    }
}
