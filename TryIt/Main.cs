using System;

namespace TryIt
{
    public enum Dir { Up, Down, Left, Right, Nowhere}

    internal class MainClass
    {
        private static readonly GameField field = new GameField(10);

        private static Player you = new Player(new Point(50, 50));

        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            ShowStars(50, 50);
            Console.ReadKey(true);
            Travel(50, 50);
            GUI.ItemSelector("Select", AllTheItems.Weapons);
        }

        private static void ShowStars(int centerX, int centerY)
        {
            int leftBorder = centerX - Console.WindowWidth/2,
                upBorder = centerY - Console.WindowHeight/2;

            Console.ForegroundColor = ConsoleColor.Gray;
            for (int i = leftBorder; i < Console.WindowWidth + leftBorder; i++)
                for (int j = upBorder + 1; j < Console.WindowHeight + upBorder; j++)
                {
                    if (i >= 0 && j  >= 0 &&
                        i < GameField.FieldW && j < GameField.FieldH &&
                        field.Stars[i, j])
                    {
                        Console.SetCursorPosition(i - leftBorder, j - upBorder);
                        Console.Write('.');
                    }
                }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ShowAll(Point thereIsPlayer)
        {
            Console.Clear();
            ShowStars(thereIsPlayer.X, thereIsPlayer.Y);
            Console.SetCursorPosition(Console.WindowWidth/2, Console.WindowHeight/2);
            Console.Write('0');
        }

        private static void Travel(int startX, int startY)
        {
            ShowAll(new Point(startX, startY));
            ConsoleKey pressed;
            Dir playerMove;
            do
            {
                pressed = Console.ReadKey(true).Key;
                switch (pressed)
                {
                    case ConsoleKey.DownArrow: 
                        playerMove = Dir.Down;
                        break;
                    case ConsoleKey.UpArrow:
                        playerMove = Dir.Up;
                        break;
                    case ConsoleKey.RightArrow:
                        playerMove = Dir.Right;
                        break;
                    case ConsoleKey.LeftArrow:
                        playerMove = Dir.Left;
                        break;
                    default:
                        playerMove = Dir.Nowhere;
                        break;
                }
                you.Move(playerMove);
                ShowAll(you.Position);
            } while (pressed != ConsoleKey.Escape);
        }
    }
}