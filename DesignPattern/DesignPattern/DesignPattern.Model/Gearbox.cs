using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Model
{
    public class Gearbox
    {
        private EngineManagementSystem mediator;
        private bool enabled;
        private Gear currentGear;

        public Gearbox(EngineManagementSystem mediator)
        {
            this.mediator = mediator;
            enabled = false;
            currentGear = Gear.Neutral;
            this.mediator.RegisterGearbox(this);
        }

        public virtual void Enable()
        {
            enabled = true;
            mediator.GearboxEnabled();
            Console.WriteLine("Gear is enabled.");
        }

        public virtual void Disable()
        {
            enabled = false;
            mediator.GearboxDisabled();
            Console.WriteLine("Gear is disabled.");
        }

        public virtual bool Enabled
        {
            get { return enabled; }
        }

        public virtual Gear Gear
        {
            get
            {
                return currentGear;
            }
            set
            {
                if (this.Enabled && this.Gear != value)
                {
                    currentGear = value;
                    mediator.GearChanged();
                    Console.WriteLine("Gear is changed to " + this.Gear);
                }
            }
        }
    }
}
