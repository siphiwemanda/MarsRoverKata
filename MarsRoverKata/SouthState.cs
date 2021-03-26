namespace MarsRoverKata
{
    public class SouthState : IState
    {
        private readonly int _x;
        private readonly int _y;

        public SouthState(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public string Direction => "S";
        public string Position => $"{_x}:{_y}";

        public IState Rotate(char command)
        {
            return command == 'R' ? (IState) new WestState(_x, _y) : new EastState(_x, _y);
        }

        public IState Move()
        {
            return new SouthState(_x, _y+1);
        }

        
    }
}