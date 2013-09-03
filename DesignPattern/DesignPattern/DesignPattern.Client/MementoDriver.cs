using DesignPattern.Model;
using DesignPattern.Pattern.Memento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class MementoDriver
    {
        public static void Run()
        {
            Speedometer speedometer = new Speedometer();
            speedometer.CurrentSpeed = 50;
            speedometer.CurrentSpeed = 100;
            Console.WriteLine("Current Speed: " + speedometer.CurrentSpeed);
            Console.WriteLine("Previous Speed: " + speedometer.PreviousSpeed);

            SpeedometerMemento memnto = new SpeedometerMemento(speedometer);
            Console.WriteLine("Current Speed: " + speedometer.CurrentSpeed);
            Console.WriteLine("Previous Speed: " + speedometer.PreviousSpeed);

            memnto.CurrentSpeed = 25;
            Console.WriteLine("Current Speed: " + speedometer.CurrentSpeed);
            Console.WriteLine("Previous Speed: " + speedometer.PreviousSpeed);

            memnto.Restore();
            Console.WriteLine("Current Speed: " + speedometer.CurrentSpeed);
            Console.WriteLine("Previous Speed: " + speedometer.PreviousSpeed);
        }
    }
}
