using System;
namespace AcademyApp.Helper
{
	public class Helper
	{
		public static void ChangeTextColor(ConsoleColor color, string message)
		{
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}

