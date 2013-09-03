using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class AutoGearbox
    {
        public AutoGearbox(SpeedometerSubject subject)
        {
            subject.SpeedChanged += Subject_SpeedChanged;
        }

        private void Subject_SpeedChanged(object sender, EventArgs e)
        {
            SpeedometerSubject subject = (SpeedometerSubject)sender;

            if (subject.Speed <= 10)
                Console.WriteLine("Gear first");
            else if(subject.Speed <= 20)
                Console.WriteLine("Gear second");
            else if (subject.Speed <= 30)
                Console.WriteLine("Gear third");
            else
                Console.WriteLine("Gear fourth");
        }
    }
}
