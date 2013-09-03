using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class Speedometer
    {
        private int currentSpeed;
        private int previousSpeed;

        public Speedometer()
        {
            currentSpeed = 0;
            previousSpeed = 0;
        }

        public virtual int CurrentSpeed
        {
            set
            {
                previousSpeed = currentSpeed;
                currentSpeed = value;
            }
            get { return currentSpeed; }
        }

        public virtual int PreviousSpeed
        {
            get { return previousSpeed; }
            set { previousSpeed = value; }
        }
    }
}
