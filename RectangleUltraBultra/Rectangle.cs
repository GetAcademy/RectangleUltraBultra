using System;

namespace RectangleUltraBultra
{
    class Rectangle
    {
        public Position Position1;
        public Position Position2;
        public ConsoleColor Color;

        private static Random _random = new Random();

        public static Rectangle CreateRandomRectangle()
        {
            var rectangle = new Rectangle();
            var x = _random.Next(0, 30);
            var y = _random.Next(0, 30);
            rectangle.Position1 = new Position { X = x, Y = y };
            rectangle.Position2 = new Position
            {
                X = x + _random.Next(10, 30), 
                Y = y + _random.Next(10, 30)
            };
            rectangle.Color = (ConsoleColor) _random.Next(0, 15);
            return rectangle;
        }

        public int GetWidth()
        {
            return Position2.X - Position1.X;
        }

        public int GetHeight()
        {
            return Position2.Y - Position1.Y;
        }

        public void Move(int dx, int dy)
        {
            Position1.X += dx;
            Position2.X += dx;
            Position1.Y += dy;
            Position2.Y += dy;
        }

        public void HandleKey(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.RightArrow) Move(1, 0);
            else if (key.Key == ConsoleKey.LeftArrow) Move(-1, 0);
            else if (key.Key == ConsoleKey.UpArrow) Move(0, -1);
            else if (key.Key == ConsoleKey.DownArrow) Move(0, 1);
        }

        public void Draw()
        {
            var height = GetHeight();
            for (var dy = 0; dy < height; dy++)
            {
                var linePosition = Position1.GetLinePosition(dy);
                var width = GetWidth();
                DrawLine(linePosition, Color, width);
            }
        }

        private static void DrawLine(Position position, ConsoleColor color, int length)
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
