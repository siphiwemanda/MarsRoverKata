using System;

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
          
            X = CalculatePosition(X + x, MinXPosition, GridWidth);
            Y = CalculatePosition(Y + y, MinYPosition, GridHeight);
        }

        private int CalculatePosition(int position, int minPosition, int maxPosition)
        {
            if (position < minPosition)
            {
                return (maxPosition - Math.Abs(position) % maxPosition) % maxPosition;
            }
            return position % maxPosition;
        }
    }
}