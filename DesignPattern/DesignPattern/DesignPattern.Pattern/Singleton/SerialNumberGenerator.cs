using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Singleton
{
	public class SerialNumberGenerator
	{
		private static SerialNumberGenerator instance;
		private int count;

		public static SerialNumberGenerator Instance
		{
			get
			{
				if (instance == null)
					instance = new SerialNumberGenerator();
				return instance;
			}
		}

		public virtual int NextSerial { get { return ++count; } }

		private SerialNumberGenerator() { }
	}
}
