using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDev.Library.Core;

namespace CSharpDev.Library.Chapter1
{
	public class AnonymousFunction : LibraryBase
	{
		public static EventHandler myEvent;

		public static void EventHandlerMethod(object sender, EventArgs args)
		{
			Console.WriteLine("EventHandlerMethod called");
		}

		public override void Run()
		{
			myEvent += new EventHandler(EventHandlerMethod);
			myEvent += new EventHandler(delegate(object sender, EventArgs args) { Console.WriteLine("delegate called"); });
			myEvent += new EventHandler((sender, args) => { Console.WriteLine("Lamda called"); });

			myEvent.Invoke(this, new EventArgs());
		}
	}
}
