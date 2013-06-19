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
			Console.WriteLine("2. Operator Overload 2, coversion.");
			Console.WriteLine("3. Anonymous Function.");
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
				case "2":
					OverloadOperator2.Run();
					break;
				case "3":
					(new AnonymousFunction()).Run();
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
