using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class EngineManagementSystem
    {
        private Ignition ignition;
        private Gearbox gearBox;
        private Accelerator accelerator;
        private Brake brake;

        int currentSpeed = 0;

        public EngineManagementSystem()
        {
            currentSpeed = 0;
        }

        public virtual void RegisterIgnition(Ignition ignition)
        {
            this.ignition = ignition;
        }

        public virtual void RegisterGearbox(Gearbox gearbox)
        {
            this.gearBox = gearbox;
        }

        public virtual void RegisterAccelerator(Accelerator accelerator)
        {
            this.accelerator = accelerator;
        }

        public virtual void RegisterBrake(Brake brake)
        {
            this.brake = brake;
        }

        public virtual void IgnitionTurnedOn()
        {
            gearBox.Enable();
            accelerator.Enable();
            brake.Enable();
        }

        public virtual void IgnitionTurnedOff()
        {
            gearBox.Disable();
            accelerator.Disable();
            brake.Disable();
        }

        public virtual void GearboxEnabled()
        {
            Console.WriteLine("EMS is controlling the gearbox.");
        }

        public virtual void GearboxDisabled()
        {
            Console.WriteLine("EMS is not controlling the gearbox.");
        }

        public virtual void GearChanged()
        {
            Console.WriteLine("EMS is notified that the gear is changed.");
        }

        public virtual void AcceleratorEnabled()
        {
            Console.WriteLine("EMS is not controlling the accelerator.");
        }

        public virtual void AcceleratorDisabled()
        {
            Console.WriteLine("EMS is not controlling the accelerator.");
        }

        public virtual void AcceleratorPressed()
        {
            brake.Disable();

            while (this.currentSpeed < accelerator.Speed)
            {
                this.currentSpeed++;
                if (this.gearBox.Gear != Gear.First && this.currentSpeed <= 10)
                {
                    this.gearBox.Gear = Gear.First;
                    Console.WriteLine("Gear First");
                }
                else if (this.gearBox.Gear != Gear.Second && this.currentSpeed <= 20)
                {
                    this.gearBox.Gear = Gear.Second;
                    Console.WriteLine("Gear Second");
                }
                else if (this.gearBox.Gear != Gear.Third && this.currentSpeed <= 30)
                {
                    this.gearBox.Gear = Gear.Third;
                    Console.WriteLine("Gear Third");
                }
                else if (this.gearBox.Gear != Gear.Fourth && this.currentSpeed <= 50)
                {
                    this.gearBox.Gear = Gear.Fourth;
                    Console.WriteLine("Gear Fourth");
                }
                else
                {
                    this.gearBox.Gear = Gear.Fifth;
                    Console.WriteLine("Gear Fifth");
                }
            }

            brake.Enable();
        }

        public virtual void BrakeEnabled()
        {
            Console.WriteLine("EMS is not controlling the brake.");
        }

        public virtual void BrakeDisabled()
        {
            Console.WriteLine("EMS is not controlling the brake.");
        }

        public virtual void BrakePressed()
        {
            accelerator.Disable();
            currentSpeed = 0;
        }

        public virtual void BrakeReleased()
        {
            accelerator.Enable();
            gearBox.Gear = Gear.First;
        }
    }
}
