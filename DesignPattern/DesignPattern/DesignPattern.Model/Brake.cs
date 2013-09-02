using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Model
{
    public class Brake
    {
        private EngineManagementSystem mediator;
        private bool enable;
        private bool applied;

        public Brake(EngineManagementSystem mediator)
        {
            this.enable = false;
            this.applied = false;
            this.mediator = mediator;
            this.mediator.RegisterBrake(this);
        }

        public void Enable()
        {
            this.enable = true;
            this.mediator.BrakeEnabled();
            Console.WriteLine("Brake is enabled.");
        }

        public void Disable()
        {
            this.enable = false;
            this.mediator.BrakeDisabled();
            Console.WriteLine("Brake is disabled.");
        }

        public virtual bool Enabled
        {
            get { return this.enable; }
        }

        public virtual void Apply()
        {
            if (this.enable)
            {
                this.applied = true;
                this.mediator.BrakePressed();
                Console.WriteLine("Brake is pressed");
            }
        }

        public virtual void Release()
        {
            if (this.enable)
            {
                this.applied = false;
            }
        }
    }
}
