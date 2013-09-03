using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class StrategyDriver
    {
        public static void Run()
        {
            AbstractCar sportCar = new Sport(new StandardEngine(2000));
            sportCar.Speed = 50;
            sportCar.Speed = 100;

            sportCar.GearboxStrategy = new SportGearboxStrategy();
            sportCar.Speed = 50;
            sportCar.Speed = 100;
        }
    }
}
