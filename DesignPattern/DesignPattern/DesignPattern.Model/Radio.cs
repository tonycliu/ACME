using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class Radio
    {
        public const int MinVolume = 0;
        public const int MaxVolume = 10;
        public const int DefaultVolume = 5;

        private bool switchedOn;
        private int volume;
 
        public Radio()
        {
            switchedOn = false;
            volume = DefaultVolume;
        }

        public virtual bool On
        {
            get
            {
                return switchedOn;
            }
        }

        public int Volume
        {
            get
            {
                return volume;
            }
        }

        public virtual void SwitchOn()
        {
            switchedOn = true;
            Console.WriteLine("Radio now on, volume level " + Volume);
        }

        public virtual void SwtichOff()
        {
            switchedOn = false;
            Console.WriteLine("Radio now off");
        }

        public virtual void VolumeUp()
        {
            if (On)
            {
                if (Volume < MaxVolume)
                {
                    volume++;
                    Console.WriteLine("Volume turned up to level " + Volume);
                }
            }
        }

        public virtual void VolumeDown()
        {
            if (On)
            {
                if (Volume > MinVolume)
                {
                    volume--;
                    Console.WriteLine("Volume turned down to level " + Volume);
                }
            }
        }
    }
}
