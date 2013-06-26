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
                default:
                    Console.WriteLine("Invalid type");
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("========================================");
		}
	}
}
