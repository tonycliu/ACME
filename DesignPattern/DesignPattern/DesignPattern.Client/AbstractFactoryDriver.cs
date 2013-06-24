using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Pattern.AbstractFactory;
using DesignPattern.Model;

namespace DesignPattern.Client
{   
    public class AbstractFactoryDriver
    {
        public enum VehicleType { Car, Van }

        public static AbstractVehicleFactory GetFactory(VehicleType type)
        {
            switch(type)
            {
                case VehicleType.Car:
                    return new CarFactory();
                case VehicleType.Van:
                    return new VanFactory();
                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }

        public static void Run()
        {
            AbstractVehicleFactory factory = GetFactory(VehicleType.Car);
            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleGlassware.GlasswareParts);
        }
    }
}
