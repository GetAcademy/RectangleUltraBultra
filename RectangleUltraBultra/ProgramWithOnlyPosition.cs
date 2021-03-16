using System;

namespace RectangleUltraBultra
{
    class ProgramWithOnlyPosition
    {
        static void MainX(string[] args)
        {
            //var position = new Position {
            //    X = 5,
            //    Y = 7
            //};
            var position = new Position();
            position.X = 5;
            position.Y = 7;
            //int x = 5;
            //int y = 7;
            var width = 10;
            var height = 4;
            var color = ConsoleColor.Green;

            while (true)
            {
                Console.Clear();
                for (var dy = 0; dy < height; dy++)
                {
                    var linePosition = position.GetLinePosition(dy);
                    DrawLine(linePosition, color, width);
                }

                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.RightArrow) position.X++;
                else if (key.Key == ConsoleKey.LeftArrow) position.X--;
                else if (key.Key == ConsoleKey.UpArrow) position.Y--;
                else if (key.Key == ConsoleKey.DownArrow) position.Y++;
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

