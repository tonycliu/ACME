using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDev.Library.Chapter1
{
	public class OverloadOperator2
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

			public static explicit operator Word(string str)
			{
				return new Word() { Text = str };
			}

			public static implicit operator string(Word w)
			{
				return w.Text;
			}

			public static explicit operator int(Word w)
			{
				return w.Text.Length;
			}
		}

		public static void Run()
		{
			Word w1 = new Word() { Text = "Tony" };
			Word w2 = new Word() { Text = "Yokoshiko" };
			int num = (int)w1;
			Word w3 = (Word)"abc";

			Console.WriteLine("string: " + w1);
			Console.WriteLine("int: " + num);
			Console.WriteLine("word: " + w3);
		}
	}
}
