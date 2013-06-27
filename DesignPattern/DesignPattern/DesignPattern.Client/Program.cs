using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
	public class Program
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Please select one option to run:");
            Console.WriteLine("1. Abstract Factory Pattern");
            Console.WriteLine("2. Builder Pattern");
			Console.WriteLine("3. Factory Pattern");
			Console.WriteLine("4. Prototype Pattern");
			Console.WriteLine("5. Singleton Pattern");

            Console.Write("---------> ");
            string option = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("========================================");
            switch(option)
            {
                case "1":
                    AbstractFactoryDriver.Run();
                    break;
                case "2":
                    VehicleBuilderDriver.Run();
                    break;
				case "3":
                    FactoryDriver.Run();
					break;
				case "4":
					PrototypeDriver.Run();
					break;
				case "5":
					SingletonDriver.Run();
					break;
                default:
                    Console.WriteLine("Invalid type");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("========================================");
		}
	}
}
