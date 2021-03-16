using System;

namespace RectangleUltraBultra
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            rectangle.Position1 = new Position { X = 5, Y = 7 };
            rectangle.Position2 = new Position { X = 15, Y = 11 };
            rectangle.Color = ConsoleColor.Green;

            while (true)
            {
                Console.Clear();
                var height = rectangle.Position2.Y - rectangle.Position1.Y;
                for (var dy = 0; dy < height; dy++)
                {
                    var linePosition = rectangle.Position1.GetLinePosition(dy);
                    var width = rectangle.Position2.X - rectangle.Position1.X;
                    DrawLine(linePosition, rectangle.Color, width);
                }

                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.RightArrow)
                {
                    rectangle.Position1.X++;
                    rectangle.Position2.X++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    rectangle.Position1.X--;
                    rectangle.Position2.X--;
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    rectangle.Position1.Y--;
                    rectangle.Position2.Y--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    rectangle.Position1.Y++;
                    rectangle.Position2.Y++;
                }
            }
        }

        static void DrawLine(Position position, ConsoleColor color, int length)
        {
            Console.CursorLeft = position.X;
            Console.CursorTop = position.Y;
            Console.ForegroundColor = color;
            Console.Write(string.Empty.PadLeft(length, '█'));
            Console.CursorLeft = Console.WindowWidth - 1;
            Console.CursorTop = Console.WindowHeight - 1;
        }
    }
}
