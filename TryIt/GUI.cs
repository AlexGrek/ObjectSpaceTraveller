using System;
using System.Collections.Generic;

namespace TryIt
{
	public static class GUI {
		public static int SimpleSelector(string q, string[] ans) 
        {
            int i = 0, pos = (Console.WindowWidth - q.Length) / 2, selection = 0;
            Console.SetCursorPosition(pos, i++);
            Console.Write(q);
            foreach (string str in ans)
            {
                Console.SetCursorPosition(pos + 1, ++i);
                Console.Write(str);
            }
            ConsoleKey pressed;
            do {
            Console.SetCursorPosition(pos, 2 + selection);
            Console.Write('>');
            pressed = Console.ReadKey(true).Key;
            Console.SetCursorPosition(pos, 2 + selection);
            Console.Write(' ');
            if (pressed == ConsoleKey.UpArrow && selection > 0) selection--;
            else if (pressed == ConsoleKey.DownArrow && selection < ans.GetLength(0) - 1) selection++;
            } while(pressed != ConsoleKey.Enter);

            return selection;
        }

		public static int ItemSelector(string q, List<Item> list) 
        {
            int i = 0, pos = 4, selection = 0;
            Console.SetCursorPosition(pos++, i);
            Console.Write(q);
			Console.SetCursorPosition(pos + 30, i);
            Console.Write("Price");
			Console.SetCursorPosition(pos + 36, i++);
            Console.Write("Weight");
            foreach (Item item in list)
            {
                Console.SetCursorPosition(pos + 1, ++i);
                Console.Write(item.Name);
				Console.SetCursorPosition(pos + 30, i);
				Console.Write(item.Cost);
				Console.SetCursorPosition(pos + 36, i);
				Console.Write(item.Weight);
            }
            ConsoleKey pressed;
            do {
            	Console.SetCursorPosition(pos, 2 + selection); 
            	Console.Write('>');
            	pressed = Console.ReadKey(true).Key;
            	Console.SetCursorPosition(pos, 2 + selection);
            	Console.Write(' ');
            	if (pressed == ConsoleKey.UpArrow && selection > 0) selection--;
            	else if (pressed == ConsoleKey.DownArrow && selection < list.Count - 1) selection++;
            } while(pressed != ConsoleKey.Enter);
            return selection;
        }
		public static int ItemSelector(string q, List<Weapon> list) 
        {
            int i = 0, pos = 4, selection = 0;
            Console.SetCursorPosition(pos++, i);
            Console.Write(q);
			Console.SetCursorPosition(pos + 30, i);
            Console.Write("Price");
			Console.SetCursorPosition(pos + 38, i);
            Console.Write("Weight");
			Console.SetCursorPosition(pos + 47, i++);
            Console.Write("Damage");
            foreach (Weapon item in list)
            {
                Console.SetCursorPosition(pos + 1, ++i);
                Console.Write(item.Name);
				Console.SetCursorPosition(pos + 30, i);
				Console.Write(item.Cost.ToString() + "$");
				Console.SetCursorPosition(pos + 39, i);
				Console.Write(item.Weight.ToString() + "T");
				Console.SetCursorPosition(pos + 47, i);
				Console.Write(item.Damage.ToString());
            }
            ConsoleKey pressed;
            do {
            	Console.SetCursorPosition(pos, 2 + selection); 
            	Console.Write('>');
				Console.SetCursorPosition(1, Console.WindowHeight - 1);
				Console.Write(list[selection].Description);
				Console.SetCursorPosition(pos, 2 + selection);
            	pressed = Console.ReadKey(true).Key;
            	Console.SetCursorPosition(pos, 2 + selection);
            	Console.Write(' ');
            	if (pressed == ConsoleKey.UpArrow && selection > 0) selection--;
            	else if (pressed == ConsoleKey.DownArrow && selection < list.Count - 1) selection++;
            } while(pressed != ConsoleKey.Enter);
            return selection;
        }
	}
}

