using System;
using System.IO;

namespace HadGadya
{
	class Program
	{
		static void Main(string[] args)
		{
			string hadGadya = File.ReadAllText("C:/Chamutal/Projects/HadGadya/hadGadya.txt");
			int go = HadGadya(9, hadGadya);
		}

		public static int HadGadya(int pathIndex, string text)
		{
			if (pathIndex <= 0)
			{
				
				return 0;
			}
			string path = "C:/Chamutal/Projects/HadGadya/H" + pathIndex.ToString() + ".txt";

			text = File.ReadAllText(path) + "\n" + text;
			Console.WriteLine(text);
			return HadGadya(pathIndex - 1, text);
		}
	}
}
