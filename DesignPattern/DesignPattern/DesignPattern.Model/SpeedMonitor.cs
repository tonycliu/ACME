using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class SpeedMonitor
    {
        private const int speedToAlert = 70;

        public SpeedMonitor(SpeedometerSubject subject)
        {
            subject.SpeedChanged += Subject_SpeedChanged;
        }

        private void Subject_SpeedChanged(object sender, EventArgs e)
        {
            SpeedometerSubject subject = (SpeedometerSubject)sender;

            if (subject.Speed > speedToAlert)
            {
                Console.WriteLine("Your speed is " + subject.Speed + ", too fast!");
            }
            else
            {
                Console.WriteLine("Your speed is " + subject.Speed);
            }
        } 
    }
}
