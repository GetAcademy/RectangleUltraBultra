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
                rectangle.Draw();

                var key = Console.ReadKey(true);
                rectangle.HandleKey(key);
            }
        }
        
        /* Kun én Rectangle
        static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            rectangle.Position1 = new Position { X = 5, Y = 7 };
            rectangle.Position2 = new Position { X = 15, Y = 11 };
            rectangle.Color = ConsoleColor.Green;

            while (true)
            {
                Console.Clear();
                rectangle.Draw();

                var key = Console.ReadKey(true);
                rectangle.HandleKey(key);
            }
        }
        */
    }
}
