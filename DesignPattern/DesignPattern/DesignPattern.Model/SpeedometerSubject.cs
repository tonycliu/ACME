using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class SpeedometerSubject
    {
        private int speed;
        public event EventHandler SpeedChanged;

        public SpeedometerSubject()
        {
            speed = 0;
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
                OnSpeedChanged();
            }
        }

        public void OnSpeedChanged()
        {
            if (this.SpeedChanged != null)
            {
                SpeedChanged(this, EventArgs.Empty);
            }
        }
    }
}
