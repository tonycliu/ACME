using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class ObserverDriver
    {
        public static void Run()
        {
            SpeedometerSubject subject = new SpeedometerSubject();
            SpeedMonitor monitor = new SpeedMonitor(subject);
            AutoGearbox gearBox = new AutoGearbox(subject);

            subject.Speed = 10;
            subject.Speed = 30;
            subject.Speed = 50;
            subject.Speed = 80;
            subject.Speed = 40;
            subject.Speed = 0;
        }
    }
}
