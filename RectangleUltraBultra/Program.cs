using System;

namespace RectangleUltraBultra
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 5;
            var y = 7;
            var width = 10;
            var height = 4;
            var color = ConsoleColor.Green;

            while (true)
            {
                Console.Clear();
                for (var dy = 0; dy < height; dy++)
                {
                    DrawLine(x, y + dy, color, width);
                }

                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.RightArrow) x++;
                else if (key.Key == ConsoleKey.LeftArrow) x--;
                else if (key.Key == ConsoleKey.UpArrow) y--;
                else if (key.Key == ConsoleKey.DownArrow) y++;
            }
        }

        static void DrawLine(int x, int y, ConsoleColor color, int length)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.ForegroundColor = color;
            Console.Write(string.Empty.PadLeft(length, '█'));
            Console.CursorLeft = Console.WindowWidth - 1;
            Console.CursorTop = Console.WindowHeight - 1;
        }
    }
}
