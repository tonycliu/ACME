using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDev.Library.Chapter1;

namespace CSharpDev
{
	public class Program
	{
		public static void Main(string[] args)
		{
            Console.WriteLine("Hello GitHub!");
			Console.WriteLine("Enter an option to run:");
			Console.WriteLine("1. Operator Overload.");
			Console.WriteLine();
			Console.Write("====>	");
			string key = Console.ReadLine();

			Console.WriteLine();
			Console.WriteLine("============================== Results =============================");
			switch(key)
			{
				case "1":
					OverloadOperator.Run();
					break;
				default:
					Console.WriteLine("Invalid option.");
					break;
			}
			Console.WriteLine("========================= End of Results ===========================");
			Console.WriteLine();
		}
	}
}
