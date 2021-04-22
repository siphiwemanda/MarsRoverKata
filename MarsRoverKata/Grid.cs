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

            if (Y > GridHeight)
            {
                Y %= GridHeight; 
            }
            
            if (Y < MinYPosition)
            {
                //Y =i where 0=< i <9
                //grid only knows about 10 make a negative number positive and then find the % (Like a clock only knows about 12 hours but i can move the hands backwards 24)
                //eg if y is -21 + 10 +10 +10 will be 9 
                // 10 hungry hippos try to share  9 seeds fairly
                //no hungry hippos get seeds 
                // 9 seed remain (this is the modulus)
                while (Y< MinYPosition)
                {
                    Y += GridHeight;
                }
                Y %= GridHeight;
            }

            if (X < MinXPosition)
            {
                while (X < MinXPosition)
                {
                    X += GridWidth;
                }
                X %= GridWidth;
            }
        }
    }
}