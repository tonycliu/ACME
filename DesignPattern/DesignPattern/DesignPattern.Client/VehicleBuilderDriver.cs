using DesignPattern.Model;
using DesignPattern.Pattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class VehicleBuilderDriver
    {
        public static void Run()
        {
            AbstractCar car = new Saloon(new StandardEngine(1300));
            VehicleBuilder builder = new CarBuilder(car);
            VehicleDirector director = new CarDirector();
            IVehicle v = director.Build(builder);
            Console.WriteLine(v);
        }
    }
}
