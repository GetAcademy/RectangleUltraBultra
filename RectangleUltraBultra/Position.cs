namespace RectangleUltraBultra
{
    class Position
    {
        public int X;
        public int Y;

        public Position GetLinePosition(int dy)
        {
            return new Position {X = X, Y = Y + dy};
        }
    }
}
