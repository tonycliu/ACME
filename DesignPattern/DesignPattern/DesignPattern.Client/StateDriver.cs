using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class StateDriver
    {
        public static void Run()
        {
            ClockSetup clockSetup = new ClockSetup();

            clockSetup.RotateRight();
            clockSetup.Push();

            clockSetup.RotateRight();
            clockSetup.RotateRight();
            clockSetup.Push();

            clockSetup.RotateLeft();
            clockSetup.Push();

        }
    }
}
