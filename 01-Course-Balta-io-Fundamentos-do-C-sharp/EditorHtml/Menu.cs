using System;

namespace EditorHtml
{
	public static class Menu
	{
		public static void Show()
		{
			Console.Clear();
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Black;

			DrawScreen();
			WriteOptions();

			var option = short.Parse(Console.ReadLine());
			HandleMenuOptions(option);
		}

		public static void DrawScreen()
		{
			// first line
			Console.Write("+");
			for (int i = 0; i <= 38; i++)
			{
				Console.Write("-");
			}
			Console.Write("+");
			Console.Write("\n");

			// inbound lines
			for (int lines = 0; lines <= 9; lines++)
			{
				Console.Write("|");
				for (int i = 0; i <= 38; i++)
				{
					Console.Write(" ");
				}
				Console.Write("|");
				Console.Write("\n");
			}

			// last line
			Console.Write("+");
			for (int i = 0; i <= 38; i++)
			{
				Console.Write("-");
			}
			Console.Write("+");
		}

		public static void WriteOptions()
		{
			Console.SetCursorPosition(3, 2);
			Console.WriteLine("Editor HTML");
			Console.SetCursorPosition(3, 3);
			Console.WriteLine("===========");
			Console.SetCursorPosition(3, 4);
			Console.WriteLine("Select one of the options behind:");
			Console.SetCursorPosition(3, 6);
			Console.WriteLine("1 - New text file");
			Console.SetCursorPosition(3, 7);
			Console.WriteLine("0 - Exit");
			Console.SetCursorPosition(3, 9);
			Console.Write("Choosen option: ");
		}

		public static void HandleMenuOptions(short option)
		{
			switch (option)
			{
				case 1: Editor.Show(); break;
				case 0:
					{
						Console.Clear();
						Environment.Exit(0); break;
					}
				default: Show(); break;
			}
		}
	}
}
