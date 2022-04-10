using System;
using System.IO;

namespace HadGadya
{
	class Program
	{
		static void Main(string[] args)
		{
			string hadGadya = File.ReadAllText("The folder where the files are located/hadGadya.txt");
			int go = HadGadya(9, hadGadya);
		}

		public static int HadGadya(int pathIndex, string text)
		{
			if (pathIndex < 0)
			{
				
				return 0;
			}
			string path = "The folder where the files are located/HadGadya/A" + pathIndex.ToString() + ".txt";

			text = File.ReadAllText(path) + "\n" + text;
			Console.WriteLine(text);
			return HadGadya(pathIndex - 1, text);
		}
	}
}
