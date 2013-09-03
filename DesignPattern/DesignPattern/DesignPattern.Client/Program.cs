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
            Console.WriteLine("6. Adapter Pattern");
            Console.WriteLine("7. Bridge Pattern");
            Console.WriteLine("8. Composition Pattern");
			Console.WriteLine("9. Decorator Pattern");
			Console.WriteLine("10. Facade Pattern");
            Console.WriteLine("11. Flyweight Pattern");
            Console.WriteLine("12. Proxy Pattern");
            Console.WriteLine("13. Chains of Responsibility Pattern");
            Console.WriteLine("14. Command Pattern");
            Console.WriteLine("15. Interpreter Pattern");
            Console.WriteLine("16. Iterator Pattern");
            Console.WriteLine("17. Memento Pattern");
            Console.WriteLine("18. Observer Pattern");
            Console.WriteLine("19. State Pattern");
            Console.WriteLine("20. Strategy Pattern");
            Console.WriteLine("21. Template Method Pattern");
            Console.WriteLine("22. Visitor Pattern");

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
                case "6":
                    AdapterDriver.Run();
                    break;
                case "7":
                    BridgeDriver.Run();
                    break;
                case "8":
                    CompositionDriver.Run();
                    break;
				case "9":
					DecoratorDriver.Run();
					break;
				case "10":
					FacadeDriver.Run();
					break;
                case "11":
                    FlyweightDriver.Run();
                    break;
                case "12":
                    ProxyDriver.Run();
                    break;
                case "13":
                    ChainsOfResponsibilityDriver.Run();
                    break;
                case "14":
                    CommandDriver.Run();
                    break;
                case "15":
                    InterpreterDriver.Run();
                    break;
                case "16":
                    IteratorDriver.Run();
                    break;
                case "17":
                    MementoDriver.Run();
                    break;
                case "18":
                    ObserverDriver.Run();
                    break;
                case "19":
                    StateDriver.Run();
                    break;
                case "20":
                    StrategyDriver.Run();
                    break;
                case "21":
                    TemplateMethodDriver.Run();
                    break;
                case "22":
                    VisitorDriver.Run();
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
