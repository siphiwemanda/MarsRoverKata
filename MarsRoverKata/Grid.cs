namespace MarsRoverKata
{
    public class Grid
    {
        private const int GridHeight = 10;
        private const int GridWidth = 10;
        private const int MinYPosition = 0;
        private const int MinXPosition = 0;
        public int Y { get; private set; }
        public int X { get; private set; }


        public void Move(int x, int y)
        {
            Y += y;
            X += x;
            if (X > GridWidth)
            {
                X %= GridWidth;
            }
            
            if (Y < MinYPosition)
            {
                Y += GridHeight;
            }

            if (X < MinXPosition)
            {
                X += GridWidth; 
            }
        }
    }
}