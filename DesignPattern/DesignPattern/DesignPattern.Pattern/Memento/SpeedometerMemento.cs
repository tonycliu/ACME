using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Memento
{
    public class SpeedometerMemento
    {
        private Speedometer speedometer;
        private Stack<int> speedHistory;

        public SpeedometerMemento(Speedometer speedometer)
        {
            this.speedometer = speedometer;
            this.speedHistory = new Stack<int>();
            this.speedHistory.Push(speedometer.PreviousSpeed);
        }

        public virtual int Restore()
        {
            if (this.speedHistory.Count > 0)
            {
                this.speedometer.CurrentSpeed = this.speedHistory.Pop();

                if (this.speedHistory.Count > 0)
                {
                    this.speedometer.PreviousSpeed = this.speedHistory.Peek();
                }
                else
                    this.speedometer.PreviousSpeed = 0;
            }

            return this.speedometer.CurrentSpeed;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                this.speedHistory.Push(this.speedometer.CurrentSpeed);
                this.speedometer.CurrentSpeed = value;               
            }
            get { return this.speedometer.CurrentSpeed; }
        }
    }
}
