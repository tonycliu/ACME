using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Pattern.Singleton;

namespace DesignPattern.Client
{
	public class SingletonDriver
	{
		public static void Run()
		{
			Console.WriteLine(string.Format("Next Serial #{0}", SerialNumberGenerator.Instance.NextSerial));
			Console.WriteLine(string.Format("Next Serial #{0}", SerialNumberGenerator.Instance.NextSerial));
			Console.WriteLine(string.Format("Next Serial #{0}", SerialNumberGenerator.Instance.NextSerial));
		}
	}
}
