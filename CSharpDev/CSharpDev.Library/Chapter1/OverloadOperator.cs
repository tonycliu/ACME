using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDev.Library.Chapter1
{
	public class OverloadOperator
	{
		private class Word
		{
			public string Text { get; set; }

			public static string operator +(Word w1, Word w2)
			{
				return w1.Text + " " + w2.Text;
			}

			public static string operator +(Word w1, int w2)
			{
				return w1.Text + " " + w2.ToString();
			}

			public override string ToString()
			{
				return this.Text;
			}
		}

		public static void Run()
		{
			Word w1 = new Word() { Text = "Tony" };
			Word w2 = new Word() { Text = "Luke" };

			Console.WriteLine("Word + Word: {0}", w1 + w2);
			Console.WriteLine("Word + Int: {0}", w2 + 1);
		}
	}
}
