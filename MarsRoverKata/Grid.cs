using System;
using System.Collections.Generic;

namespace MarsRoverKata
{
    public class Grid
    {
        private readonly ObstacleRepo _repo;
        private const int GridHeight = 10;
        private const int GridWidth = 10;
        private const int MinYPosition = 0;
        private const int MinXPosition = 0;
        public int Y { get; private set; }
        public int X { get; private set; }

        public Grid(ObstacleRepo repo)
        {
            _repo = repo;
        }
        
        
        public void Move(int x, int y)
        {
     
            X = CalculatePosition(X + x, MinXPosition, GridWidth);

            foreach (var obstacleClass in _repo.obsticalList)
            {
                if (obstacleClass.ObstacleY == y+Y)
                {
                    Y = Y;
                }
                else
                {
                    Y = CalculatePosition(Y + y, MinYPosition, GridHeight);
                }
            }
     

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